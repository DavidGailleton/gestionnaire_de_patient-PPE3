using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3.Object
{
    internal class Ordonnance
    {
        public string Posologie { get; set; }
        public int Duree { get; set; }
        public string Instruction { get; set; }
        public DateTime Date_creation { get; set; }
        public Patient Patient { get; set; }
        public Medicament Medicament { get; set; }
        public Medecin Medecin { get; set; }

        public Ordonnance(string Posologie, int Duree, string Instruction, DateTime Date_creation, Patient patient, Medicament medicament, Medecin medecin)
        {
            this.Posologie = Posologie;
            this.Duree = Duree;
            this.Instruction = Instruction;
            this.Date_creation = Date_creation;
            Patient = patient;
            Medicament = medicament;
            Medecin = medecin;

        }
    }
}
