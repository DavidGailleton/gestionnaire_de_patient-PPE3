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
    public partial class AddMedecin : Form
    {
        Login login;
        public AddMedecin(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MedecinDataAccess dataAccess = new MedecinDataAccess();
            Medecin medecin = new(nom_textBox.Text, prenom_textBox.Text, (DateTime)dateTimePicker.Value, login_textBox.Text);
            string password = password_maskedTextBox.Text;


            string result = dataAccess.AddMedecinInDB(medecin, password);
            if (result == "Success")
            {
                MessageBox.Show("Medecin créé ave success");
                AdminPage adminPage = new(login);
                adminPage.Show();
                this.Close();
            } 
            else
            {
                MessageBox.Show("Une erreur est survenue");
            }
        }
    }
}
