using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPE3.DataAccess;
using PPE3.Object;
using PPE3_DEBUG;

namespace PPE3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Utilisateur")
            {
                string login = usernameTextBox.Text;
                string password = passwordTextBox.Text;
                MedecinDataAccess dataAccess = new MedecinDataAccess();
                Medecin result = dataAccess.ConnectMedecinFromDB(login, password);
                if (result.Login == "")
                {
                    MessageBox.Show("login ou mot de passe incorrect");
                }
                else if (dataAccess.VerifyFirstConnection(login) == "Success")
                {
                    NewMedecinPassword newPassword = new(login, this);
                    newPassword.Show();
                    this.Hide();

                }
                else if (dataAccess.VerifyFirstConnection(login) == "Error" && result.Login == login)
                {
                    Index index = new(result, this);
                    index.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue");
                }
            }
            else if (comboBox1.Text == "Base d'administration")
            {
                string login = usernameTextBox.Text;
                string password = passwordTextBox.Text;
                AdminDataAccess dataAccess = new();
                bool result = dataAccess.ConnectAdminFromDB(login, password);
                if (result == false)
                {
                    MessageBox.Show("login ou mot de passe incorrect");
                }
                else if (dataAccess.VerifyFirstConnection(login) == "Success")
                {
                    NewAdminPassword newPassword = new(login, this);
                    newPassword.Show();
                    this.Hide();

                }
                else if (result == true)
                {
                    AdminPage adminPage = new(this);
                    adminPage.Show();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue");
                }
            }
            
        }
    }
}
