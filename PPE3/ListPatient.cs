using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPE3.DataAccess;
using PPE3.Object;

namespace PPE3
{
    public partial class ListPatient : Form
    {
        Patient selectedPatient;
        Medecin medecin;
        internal ListPatient(Medecin medecin)
        {
            InitializeComponent();
            PatientDataAccess dataAccess = new PatientDataAccess();
            this.dataGridView1.DataSource = dataAccess.SelectPatientsFromDB();
            this.medecin = medecin;
        }
        private void Search()
        {
            BindingSource bs = new();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = dataGridView1.Columns[0 & 1].HeaderText.ToString() + " LIKE '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 & e.RowIndex < dataGridView1.RowCount - 1)
            {
                DataGridViewRow selectedRow = this.dataGridView1.Rows[e.RowIndex];
                string nom = selectedRow.Cells["Nom"].Value.ToString();
                string prenom = selectedRow.Cells["prenom"].Value.ToString();
                DateTime naissance = (DateTime)selectedRow.Cells["date_de_naissance"].Value;
                string sexe = selectedRow.Cells["sexe"].Value.ToString();
                long no_secu = (long)selectedRow.Cells["numero_de_securite_social"].Value;
                Patient patient = new Patient(nom, prenom, naissance, sexe, no_secu);
                this.selectedPatient = patient;

            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Functions fun = new();
            fun.Search(textBox1, dataGridView1);
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            if (selectedPatient != null)
            {
                PatientProfile patientProfile = new PatientProfile(selectedPatient, medecin);
                patientProfile.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Aucun patient selectionné");
            }
        }
    }
}
