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
    public partial class DrugStock : Form
    {
        public DrugStock()
        {
            InitializeComponent();
            MedicamentDataAccess dataAccess = new MedicamentDataAccess();
            this.drugList_dataGridView.DataSource = dataAccess.SelectMedicamentsFromDB();
            this.stock_dataGridView.DataSource = dataAccess.SelectMedicamentsInStockFromDB();
        }
        Medicament selectedMedic;
        int qteToAdd;

        private void Search()
        {
            BindingSource bsl = new();
            BindingSource bst = new();
            bsl.DataSource = drugList_dataGridView.DataSource;
            bsl.Filter = drugList_dataGridView.Columns[0].HeaderText.ToString() + " LIKE '%" + textBox1.Text + "%'";
            drugList_dataGridView.DataSource = bsl;
            bst.DataSource = stock_dataGridView.DataSource;
            bst.Filter = stock_dataGridView.Columns[0].HeaderText.ToString() + " LIKE '%" + textBox1.Text + "%'";
            stock_dataGridView.DataSource = bst;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DrugStock_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < drugList_dataGridView.RowCount - 1)
            {
                DataGridViewRow selectedRow = this.drugList_dataGridView.Rows[e.RowIndex];
                Medicament selectedMedic = new Medicament(selectedRow.Cells["libelle"].Value.ToString(), selectedRow.Cells["contre_indication"].Value.ToString(), (int)selectedRow.Cells["quantité"].Value);
                this.selectedMedic = selectedMedic;
            }
        }

        private void stockAdd_button_Click(object sender, EventArgs e)
        {
            if (this.selectedMedic != null)
            {
                MedicamentDataAccess dataAccess = new MedicamentDataAccess();
                string result = dataAccess.AddMedicamentStockInDB(this.selectedMedic, this.qteToAdd);
                if (result == "Success")
                {
                    MessageBox.Show("Stock ajouté !");
                }
                else
                {
                    MessageBox.Show("Une erreur s'est produite...");
                }
                this.drugList_dataGridView.DataSource = dataAccess.SelectMedicamentsFromDB();
                this.stock_dataGridView.DataSource = dataAccess.SelectMedicamentsInStockFromDB();
                Search();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un médicament");
            }
        }

        private void stockAdd_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.qteToAdd = (int)stockAdd_numericUpDown.Value;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void removeStock_button_Click(object sender, EventArgs e)
        {
            if (this.selectedMedic != null)
            {
                MedicamentDataAccess dataAccess = new MedicamentDataAccess();
                string result = dataAccess.RemoveMedicamentStockInDB(this.selectedMedic, this.qteToAdd);
                if (result == "Success")
                {
                    MessageBox.Show("Stock supprimé !");
                }
                else
                {
                    MessageBox.Show("Une erreur s'est produite...");
                }
                this.drugList_dataGridView.DataSource = dataAccess.SelectMedicamentsFromDB();
                this.stock_dataGridView.DataSource = dataAccess.SelectMedicamentsInStockFromDB();
                Search();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un médicament");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void stock_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
