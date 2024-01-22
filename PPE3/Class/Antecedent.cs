using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3.Object
{
    internal class Antecedent
    {
        public string libelle { get; set; }
        public Patient patient { get; set; }

        public Antecedent(string libelle, Patient patient)
        {
            this.libelle = libelle;
            this.patient = patient;
        }
    }
}
