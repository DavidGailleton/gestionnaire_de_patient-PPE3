using System.Collections.Generic;
using System.Xml.Linq;
using PPE3.DataAccess;
using PPE3.Object;

namespace PPE3
{
    public partial class NewDrug : Form
    {
        string nameSelected = "";
        string descriptionSelected = "";

        private DrugDataAccess dataAccess = new DrugDataAccess();
        public NewDrug()
        {
            InitializeComponent();
            DrugDataAccess dataAccess = new DrugDataAccess();
            this.dataGridView1.DataSource = dataAccess.ImportAuthorizedDrugFromDB();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (nameSelected == "" || descriptionSelected == "")
            {
                MessageBox.Show("Veuillez selectionner une valeur");
            }
            else
            {
                //supprimer la ligne de valeur séléctionner dans la base de donnée
                Drug newDrug = new Drug(nameSelected, descriptionSelected);
                DrugDataAccess dataAccess = new DrugDataAccess();
                dataAccess.AddDrugToDB(newDrug);

                MessageBox.Show("Médicament ajouté au stock");
            }
        }

        public void UpdateDataGridWiew()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = dataAccess.GetDrugList();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = dataGridView1.Columns[0].HeaderText.ToString() + " LIKE '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = bs;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = this.dataGridView1.Rows[e.RowIndex];
                nameSelected = selectedRow.Cells["Name"].Value.ToString();
                descriptionSelected = selectedRow.Cells["Description"].Value.ToString();
            }
        }

        private void ButtonaddDrugWithQuantity_Click(object sender, EventArgs e)
        {
            if (nameSelected == "" || descriptionSelected == "")
            {
                MessageBox.Show("Veuillez selectionner une valeur");
            }
            else if (numericUpDown1.Value < 1)
            {
                MessageBox.Show("Veuillez entrer une quantité valide");
            }
            else
            {
                Drug newDrug = new Drug(nameSelected, descriptionSelected);
                DrugDataAccess dataAccess = new DrugDataAccess();
                dataAccess.AddDrugFromDBWithQuantity(newDrug, (int)numericUpDown1.Value);

                MessageBox.Show("Médicament ajouté au stock");
            }
        }
    }
}