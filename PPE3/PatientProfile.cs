using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPE3.Object;

namespace PPE3
{
    public partial class PatientProfile : Form
    {
        Patient patient;
        Medecin medecin;
        internal PatientProfile(Patient patient, Medecin medecin)
        {
            InitializeComponent();
            name_label.Text = patient.Nom + " " + patient.Prenom;
            noSecu_label.Text = patient.NoSecu.ToString();
            AntecedentDataAccess antecedantDataAccess = new AntecedentDataAccess();
            AllergieDataAccess allergieDataAccess = new AllergieDataAccess();
            this.antecedant_dataGridView.DataSource = antecedantDataAccess.SelectPatientAntecedantsFromDb(patient);
            this.allergie_dataGridView.DataSource = allergieDataAccess.SelectPatientAllergiesFromDb(patient);
            this.patient = patient;
            this.medecin = medecin;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void antecedant_button_Click(object sender, EventArgs e)
        {
            NewAntecedent na = new NewAntecedent(patient, medecin);
            na.Show();
            this.Close();
        }

        private void allergie_button_Click(object sender, EventArgs e)
        {
            AddAllergie aa = new(patient, medecin);
            aa.Show();
            this.Close();
        }

        private void newOrdonnance_button_Click(object sender, EventArgs e)
        {
            NewOrdonnance no = new(medecin, patient);
            no.Show();
            this.Close();
        }
    }
}