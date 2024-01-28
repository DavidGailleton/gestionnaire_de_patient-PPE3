using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPE3.DataAccess;
using PPE3.Object;

namespace PPE3
{
    public partial class NewPatient : Form
    {
        string sexe = "";
        Medecin medecin;
        internal NewPatient(Medecin medecin)
        {
            InitializeComponent();
            this.medecin = medecin;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
        // créer un nouveau patient
        private void create_button_Click(object sender, EventArgs e)
        {
            // Vérifie si toutes les cases sont remplie
            if (surname_textbox.Text != "" && name_textbox.Text != "" && sexe == "h" | sexe == "f")
            {
                PatientDataAccess dataAccess = new PatientDataAccess();
                // Créer un objet de la classe Patient
                Patient patient = new Patient(surname_textbox.Text, name_textbox.Text, birthday_DateTimePicker.Value.Date, sexe, (long)long.Parse(noSecu_TextBox.Text));
                // Execute la fonction AddPatientInDB pour créer un nouveau patient
                string result = dataAccess.AddPatientInDB(patient);
                // Si la création c'est bien passé, ouvrir la page de profile du patient créé
                if (result == "Success")
                {
                    PatientProfile pp = new(patient, medecin);
                    pp.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Une erreur c'est produite");
                }
            }
        }

        private void homme_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            sexe = "h";
            if (femme_checkBox.Checked == true)
            {
                femme_checkBox.Checked = false;
            }
        }

        private void femme_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            sexe = "f";
            if (homme_checkBox.Checked == true)
            {
                homme_checkBox.Checked = false;
            }
        }

        private void noSecu_TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
