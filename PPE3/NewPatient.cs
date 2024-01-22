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

        private void create_button_Click(object sender, EventArgs e)
        {
            if (surname_textbox.Text != null && name_textbox.Text != null && sexe == "h" | sexe == "f")
            {
                PatientDataAccess dataAccess = new PatientDataAccess();
                Patient patient = new Patient(surname_textbox.Text, name_textbox.Text, birthday_DateTimePicker.Value.Date, sexe, (long)long.Parse(noSecu_TextBox.Text));
                dataAccess.AddPatientInDB(patient);
                PatientProfile pp = new(patient, medecin);
                pp.Show();
                this.Close();
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
