using Newtonsoft.Json;
using PluginInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using System.Xml.Linq;

namespace Paint
{
    public static class PluginManager
    {
        public static Dictionary<string, IPlugin> Plugins = new Dictionary<string, IPlugin>();
        public static Dictionary<string, bool> Statuses = new Dictionary<string, bool>();

        public static void LoadPlugins()
        {
            var appSettings = ConfigurationManager.AppSettings;
            if (appSettings.Count != 0)
            {
                LoadPluginsFromConfig(appSettings);
            }
            else
            {
                LoadPluginsAndCreateConfigFile();
            }
        }

        private static IPlugin? LoadPlugin(string pluginPath, bool status)
        {
            Assembly assembly = Assembly.LoadFile(pluginPath);
            foreach (Type type in assembly.GetTypes())
            {
                Type? iface = type.GetInterface("PluginInterface.IPlugin");
                if (iface != null)
                {
                    IPlugin? plugin = (IPlugin)Activator.CreateInstance(type);
                    Plugins.Add(plugin.Name, plugin);
                    Statuses.Add(plugin.Name, status);
                    return plugin;
                }
            }
            return null;
        }

        private static void LoadPluginsFromConfig(NameValueCollection? appSettings)
        {
            foreach (string? key in appSettings.AllKeys)
            {
                if (key != null && key.EndsWith("Library.dll"))
                {
                    string name = key;
                    bool enabled = Convert.ToBoolean(appSettings[key]);

                    string folder = System.AppDomain.CurrentDomain.BaseDirectory;
                    string pluginPath = Path.Combine(folder, name);
                    LoadPlugin(pluginPath, enabled);
                }
            }
        }

        private static void LoadPluginsAndCreateConfigFile()
        {
            var configFile = "App.config";
            var map = new ExeConfigurationFileMap { ExeConfigFilename = configFile };
            var config = ConfigurationManager.OpenMappedExeConfiguration(map, ConfigurationUserLevel.None);
            var newAppSettings = config.AppSettings.Settings;

            string folder = AppDomain.CurrentDomain.BaseDirectory;

            string[] files = Directory.GetFiles(folder, "*Library.dll");

            foreach (string pluginFile in files)
            {
                string pluginName = Path.GetFileName(pluginFile);
                newAppSettings.Add(pluginName, "true");
                LoadPlugin(pluginFile, true);
            }

            config.Save(ConfigurationSaveMode.Modified);
        }

        public static void ChangePluginStatus(string name)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            Type pluginType = Plugins[name].GetType();
            Assembly assembly = pluginType.Assembly;
            string assemblyName = assembly.GetName().Name;

            if (config.AppSettings.Settings[$"{assemblyName}.dll"] != null)
            {
                config.AppSettings.Settings[$"{assemblyName}.dll"].Value =
                config.AppSettings.Settings[$"{assemblyName}.dll"].Value == "true" ? "false" : "true";
                Statuses[name] = !Statuses[name];

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        public static void DeletePlugin(string name)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            Type pluginType = Plugins[name].GetType();
            Assembly assembly = pluginType.Assembly;
            string assemblyName = assembly.GetName().Name;

            if (config.AppSettings.Settings[$"{assemblyName}.dll"] != null)
            {
                config.AppSettings.Settings.Remove($"{assemblyName}.dll");
                Statuses.Remove(name);
                Plugins.Remove(name);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        public static IPlugin? AddPlugin(string pluginPath)
        {
            string pluginName = Path.GetFileNameWithoutExtension(pluginPath);

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add(pluginName + ".dll", "true");
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            return LoadPlugin(pluginPath, true);
        }
    }
}
