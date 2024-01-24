using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPE3.Class;
using PPE3.DataAccess;
using PPE3.Object;
using PPE3_DEBUG;

namespace PPE3
{
    public partial class AdminPage : Form
    {
        Medecin selectedMedecin;
        Admin selectedAdmin;
        Login login;
        public AdminPage(Login login)
        {
            InitializeComponent();
            this.login = login;
            MedecinDataAccess mda = new();
            AdminDataAccess ada = new();
            this.dataGridView1.DataSource = mda.SelectMedecinsFromDB();
            this.dataGridView2.DataSource = ada.SelectAdminsFromDB();
        }

        private void AddMedecinButton_Click(object sender, EventArgs e)
        {
            AddMedecin addMedecin = new AddMedecin(login);
            addMedecin.Show();
            this.Close();
        }

        private void DeleteMedecinButton_Click(object sender, EventArgs e)
        {
            if (selectedMedecin == null)
            {
                MessageBox.Show("Veuillez selectionner un utilisateur");
            }
            else
            {
                bool result = Convert.ToBoolean(MessageBox.Show("Voulez vous réellement supprimer cette utilisateur ?", "test", MessageBoxButtons.YesNo));
                if (result = true)
                {
                    MedecinDataAccess dataAccess = new MedecinDataAccess();
                    dataAccess.DeleteMedecinInDB(selectedMedecin);

                    this.dataGridView1.DataSource = dataAccess.SelectMedecinsFromDB();

                }
                
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 & e.RowIndex < dataGridView1.RowCount - 1)
            {
                DataGridViewRow selectedRow = this.dataGridView1.Rows[e.RowIndex];
                DateTime naissance = (DateTime)selectedRow.Cells["date_de_naissance"].Value;
                string nom = selectedRow.Cells["Nom"].Value.ToString();
                string prenom = selectedRow.Cells["Prenom"].Value.ToString();
                string login = selectedRow.Cells["login"].Value.ToString();

                Medecin medecin = new(nom, prenom, naissance, login);
                this.selectedMedecin = medecin;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Functions func = new();
            func.Search(textBox1, dataGridView1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Functions func = new();
            func.Search(textBox2, dataGridView2);
        }

        private void addAdmin_button_Click(object sender, EventArgs e)
        {
            AddAdmin addAdmin = new(login);
            addAdmin.Show();
            this.Close();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {

        }

        private void AdminPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }

        private void deleteAdmin_button_Click(object sender, EventArgs e)
        {
            if (selectedAdmin == null)
            {
                MessageBox.Show("Veuillez selectionner un Admin");
            }
            else
            {
                bool result = Convert.ToBoolean(MessageBox.Show("Voulez vous réellement supprimer cette ADMIN ?", "test", MessageBoxButtons.YesNo));
                if (result = true)
                {
                    AdminDataAccess dataAccess = new();
                    dataAccess.DeleteAdminInDB(selectedAdmin.Login);
                    this.dataGridView2.DataSource = dataAccess.SelectAdminsFromDB();

                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 & e.RowIndex < dataGridView2.RowCount - 1)
            {
                DataGridViewRow selectedRow = this.dataGridView2.Rows[e.RowIndex];
                string login = selectedRow.Cells["login"].Value.ToString();
                Admin admin = new(login);


                this.selectedAdmin = admin;
            }
        }
    }
}
