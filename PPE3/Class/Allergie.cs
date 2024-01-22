using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3.Object
{
    internal class Allergie
    {
        public string libelle { get; set; }

        public Allergie(string libelle)
        {
            this.libelle = libelle;
        }
    }
}
