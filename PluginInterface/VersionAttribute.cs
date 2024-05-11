using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginInterface
{
    public class VersionAttribute : Attribute
    {
        public int Major { get; private set; }
        public int Minor { get; private set; }
        public VersionAttribute(int major, int minor)
        {
            Major = major;
            Minor = minor;
        }
    }
}
