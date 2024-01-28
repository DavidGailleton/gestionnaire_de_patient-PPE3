using MySqlX.XDevAPI.Relational;
using PPE3.DataAccess;
using PPE3.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3
{
    public partial class NewAntecedent : Form
    {
        Medecin medecin;
        Patient patient;
        internal NewAntecedent(Patient patient, Medecin medecin)
        {
            InitializeComponent();
            MedicamentDataAccess dataAccess = new MedicamentDataAccess();
            medic_dataGridView.DataSource = dataAccess.SelectMedicamentsFromDB();
            name_label.Text = patient.Nom + " " + patient.Prenom;
            this.medecin = medecin;
            this.patient = patient;
        }
        List<Medicament> medicaments = new List<Medicament>();

        private void UpdateSelectedDataGridView()
        {
            DataTable dt = new DataTable();
            DataColumn column;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Libelle";
            column.ReadOnly = true;
            column.Unique = true;

            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Contre Indication";
            column.ReadOnly = true;
            column.Unique = false;

            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Quantite";
            column.ReadOnly = true;
            column.Unique = false;

            dt.Columns.Add(column);

            foreach (Medicament medicament in this.medicaments)
            {
                DataRow dataRow = dt.NewRow();
                dataRow["Libelle"] = medicament.Libelle;
                dataRow["Contre Indication"] = medicament.Contre_indication;
                dataRow["Quantite"] = medicament.qte;

                dt.Rows.Add(dataRow);
            }
            this.selected_dataGridView.DataSource = dt;
        }

        private void medic_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = this.medic_dataGridView.Rows[e.RowIndex];
                Medicament selectedMedic = new Medicament(selectedRow.Cells["libelle"].Value.ToString(), selectedRow.Cells["contre_indication"].Value.ToString(), (int)selectedRow.Cells["Quantite"].Value);
                this.medicaments.Add(selectedMedic);
                UpdateSelectedDataGridView();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void selected_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = this.selected_dataGridView.Rows[e.RowIndex];
                Medicament selectedMedic = new Medicament(selectedRow.Cells["libelle"].Value.ToString(), selectedRow.Cells["Contre Indication"].Value.ToString(), (int)selectedRow.Cells["Quantite"].Value);
                bool result = this.medicaments.Remove(selectedMedic);
                if (result == false)
                {
                    MessageBox.Show("medicament non trouvé ou non supprimé");
                }
                UpdateSelectedDataGridView();
            }
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            AntecedentDataAccess adt = new();
            adt.AddAntecedantInDB(Libelle_textBox.Text.ToString(), patient);
            MessageBox.Show("Antécédent créé");
        }

        private void return_button_Click(object sender, EventArgs e)
        {
            PatientProfile pp = new(patient, medecin);
            pp.Show();
            this.Close();
        }
    }
}
