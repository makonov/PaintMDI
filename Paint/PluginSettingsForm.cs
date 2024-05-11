using PluginInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Paint
{
    public partial class PluginSettingsForm : Form
    {
        public MainForm ParentForm { get; set; }
        public PluginSettingsForm(MainForm parentForm)
        {
            InitializeComponent();
            LoadPluginsToListView();
            ParentForm = parentForm;
        }

        private void LoadPluginsToListView()
        {
            foreach (var plugin in PluginManager.Plugins)
            {
                ListViewItem item = new ListViewItem(plugin.Key);
                item.SubItems.Add(PluginManager.Statuses[plugin.Key] ? "+" : "-");
                item.SubItems.Add(plugin.Value.Author);

                Type pluginType = plugin.Value.GetType();
                VersionAttribute? version = (VersionAttribute)Attribute.GetCustomAttribute(pluginType, typeof(VersionAttribute));
                item.SubItems.Add($"{version.Major}.{version.Minor}");
                pluginListView.Items.Add(item);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void changeStatusBtn_Click(object sender, EventArgs e)
        {
            SelectedListViewItemCollection selectedItems = pluginListView.SelectedItems;

            foreach (ListViewItem selectedItem in selectedItems)
            {
                try
                {
                    ToolStripMenuItem? foundItem = ParentForm.filtersToolStripMenuItem.DropDownItems
                    .OfType<ToolStripMenuItem>()
                    .FirstOrDefault(item => item.Text == selectedItem.Text);

                    if (foundItem != null)
                    {
                        PluginManager.ChangePluginStatus(foundItem.Text);
                        foundItem.Visible = PluginManager.Statuses[foundItem.Text];
                        selectedItem.SubItems[1].Text = selectedItem.SubItems[1].Text == "+" ? "-" : "+";
                        foundItem.Owner.Refresh();
                    }
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Ошибка смены статуса плагина: " + ex.Message);
                }
            }
        }

        private void deletePluginBtn_Click(object sender, EventArgs e)
        {
            SelectedListViewItemCollection selectedItems = pluginListView.SelectedItems;

            foreach (ListViewItem selectedItem in selectedItems)
            {
                try
                {
                    PluginManager.DeletePlugin(selectedItem.Text);
                    selectedItem.Remove();

                    ToolStripMenuItem? foundItem = ParentForm.filtersToolStripMenuItem.DropDownItems
                    .OfType<ToolStripMenuItem>()
                    .FirstOrDefault(item => item.Text == selectedItem.Text);
                    if (foundItem != null)
                    {
                        ParentForm.filtersToolStripMenuItem.DropDownItems.Remove(foundItem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка выгрузки плагина и сборки: " + ex.Message);
                }
            }
        }

        private void loadPluginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "DLL files (*.dll)|*.dll";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Multiselect = false;

                openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string pluginPath = openFileDialog.FileName;
                    var plugin = PluginManager.AddPlugin(pluginPath);

                    ListViewItem item = new ListViewItem(plugin.Name);
                    item.SubItems.Add(PluginManager.Statuses[plugin.Name] ? "+" : "-");
                    item.SubItems.Add(plugin.Author);
                    Type pluginType = plugin.GetType();
                    VersionAttribute? version = (VersionAttribute)Attribute.GetCustomAttribute(pluginType, typeof(VersionAttribute));
                    item.SubItems.Add($"{version.Major}.{version.Minor}");
                    pluginListView.Items.Add(item);

                    var menuItem = ParentForm.filtersToolStripMenuItem.DropDownItems.Add(plugin.Name);
                    menuItem.Click += ParentForm.OnPluginClick;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки плагина: " + ex.Message);
            }
        }
    }
}
