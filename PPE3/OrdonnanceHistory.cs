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
    public partial class OrdonnanceHistory : Form
    {
        Ordonnance selectedOrdonnance;
        List<Ordonnance> ordonnances;
        public OrdonnanceHistory()
        {
            InitializeComponent();
            OrdonnanceDataAccess da = new OrdonnanceDataAccess();
            this.ordonnances = da.SelectOrdonnancesFromDB();
            insertOrdonnancesInDataGridView();
        }
        private void insertOrdonnancesInDataGridView()
        {
            DataTable dt = new DataTable();
            DataColumn column;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "Date de creation";
            column.ReadOnly = true;
            column.Unique = false;

            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Medicament";
            column.ReadOnly = true;
            column.Unique = false;

            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Posologie";
            column.ReadOnly = true;
            column.Unique = false;

            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Patient";
            column.ReadOnly = true;
            column.Unique = false;

            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Medecin";
            column.ReadOnly = true;
            column.Unique = false;

            dt.Columns.Add(column);

            foreach (Ordonnance ordonnance in ordonnances)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["Date de creation"] = ordonnance.Date_creation;
                dataRow["Medicament"] = ordonnance.Medicament.Libelle;
                dataRow["Posologie"] = ordonnance.Posologie;
                dataRow["Patient"] = ordonnance.Patient.Nom + " " + ordonnance.Patient.Prenom;
                dataRow["Medecin"] = ordonnance.Medecin.Nom + " " + ordonnance.Medecin.Prenom;

                dt.Rows.Add(dataRow);
            }
            this.dataGridView1.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Functions func = new Functions();
            func.Search(textBox1, dataGridView1);
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            if (selectedOrdonnance != null)
            {
                OrdonnanceView ov = new(selectedOrdonnance);
                ov.Show();
                this.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 & e.RowIndex < dataGridView1.RowCount - 1)
            {
                DataGridViewRow selectedRow = this.dataGridView1.Rows[e.RowIndex];
                DateTime date_crea = (DateTime)selectedRow.Cells["Date de creation"].Value;
                string medic = selectedRow.Cells["Medicament"].Value.ToString();
                string posologie = selectedRow.Cells["Posologie"].Value.ToString();

                IEnumerable<Ordonnance> query = this.ordonnances.Where(ordonnance => ordonnance.Date_creation == date_crea & ordonnance.Medicament.Libelle == medic & ordonnance.Posologie == posologie);

                selectedOrdonnance = query.First();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
