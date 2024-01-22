using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3.Object
{
    internal class Drug
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Drug(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }
    }
}
