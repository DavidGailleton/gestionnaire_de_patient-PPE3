using PPE3.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3
{
    public partial class AddAllergie : Form
    {
        AllergieDataAccess ada = new();
        Allergie selectedAllergie;
        Patient patient;
        Medecin medecin;
        internal AddAllergie(Patient patient, Medecin medecin)
        {
            InitializeComponent();
            this.patient = patient;
            this.medecin = medecin;
            this.dataGridView1.DataSource = this.ada.SelectAllergiesFromDB();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Functions fun = new();
            fun.Search(textBox1, dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 & e.RowIndex < dataGridView1.RowCount - 1)
            {
                DataGridViewRow selectedRow = this.dataGridView1.Rows[e.RowIndex];
                Allergie allergie = new(selectedRow.Cells["libelle"].Value.ToString());
                selectedAllergie = allergie;
            }
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            if (selectedAllergie != null)
            {
                string result = this.ada.AddAllergieToPatientInDB(selectedAllergie, patient);
                if (result == "Success")
                {
                    MessageBox.Show("Allergie ajoutee avec succes");
                }
            }
            else
            {
                MessageBox.Show("Veuillez selectionner une allergie");
            }
        }

        private void NewAllergie_button_Click(object sender, EventArgs e)
        {
            string allergieToAdd = addAllergie_textBox.Text.ToString();
            string result = this.ada.AddAllergieInDB(allergieToAdd);
            if (result == "Success")
            {
                MessageBox.Show(allergieToAdd + " a ete ajoute avec succes");
            }
            else
            {
                MessageBox.Show("Une erreur c est produite lors de l ajout");
            }
            this.dataGridView1.DataSource = this.ada.SelectAllergiesFromDB();
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            PatientProfile pp = new(patient, medecin);
            pp.Show();
            this.Close();
        }
    }
}
