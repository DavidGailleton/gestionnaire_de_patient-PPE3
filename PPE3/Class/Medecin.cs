using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE3.Object
{
    internal class Medecin { 
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime Naissance { get; set; }
        public string Login { get; set; }

        public Medecin(string Nom, string Prenom, DateTime Naissance, string Login)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Naissance = Naissance;
            this.Login = Login;
        }
    }
}
