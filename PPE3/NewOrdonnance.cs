using PPE3.DataAccess;
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
    public partial class NewOrdonnance : Form
    {
        Patient patient;
        Medecin medecin;
        Medicament selectedMedic;
        internal NewOrdonnance(Medecin medecin, Patient patient)
        {
            InitializeComponent();
            this.medecin = medecin;
            this.patient = patient;
            MedicamentDataAccess mda = new();
            this.dataGridView1.DataSource = mda.SelectMedicamentsFromDB();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Functions fun = new Functions();
            fun.Search(Seqrch_textBox, dataGridView1);
        }
        // Importation d'une ordonnance dans la base de données et ouverture de celle ci
        private void button1_Click(object sender, EventArgs e)
        {
            // Création d'un objet de la classe ordonnance
            Ordonnance ordonnance = new(this.posologie_richTextBox.Text.ToString(), (int)numericUpDown1.Value, this.Instruction_richTextBox.Text.ToString(), DateTime.Now, this.patient, this.selectedMedic, this.medecin);
            OrdonnanceDataAccess oda = new();
            // appel de la fonction AddORdonnanceInDB permettant d'ajouter une nouvelle ordonnance dans la base de données
            string result = oda.AddOrdonnanceInDB(ordonnance);
            // Si la requete SQL c'est dérouler correctement, alors l'ordonnance s'affichera
            if (result == "Success")
            {
                MessageBox.Show("Ordonnance cree");
                OrdonnanceView ov = new(ordonnance);
                ov.Show();
                this.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.RowCount - 1)
            {
                DataGridViewRow selectedRow = this.dataGridView1.Rows[e.RowIndex];
                Medicament selectedMedic = new Medicament(selectedRow.Cells["libelle"].Value.ToString(), selectedRow.Cells["contre_indication"].Value.ToString(), (int)selectedRow.Cells["Quantite"].Value);
                this.selectedMedic = selectedMedic;
            }
        }
    }
}
