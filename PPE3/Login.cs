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
            // connexion sur la base utilisateur
            if (comboBox1.Text == "Utilisateur")
            {
                string login = usernameTextBox.Text;
                string password = passwordTextBox.Text;
                MedecinDataAccess dataAccess = new MedecinDataAccess();
                // Requete vérifiant la si l'identifiant et le mot de passe de l'utilisateur est correcte 
                Medecin result = dataAccess.ConnectMedecinFromDB(login, password);
                // Si la requete ne retourne rien, alors l'utilisateur est informé que l'identifiant ou le mot de est incorrecte
                if (result.Login == "")
                {
                    MessageBox.Show("Identifiant ou mot de passe incorrect");
                }
                // Si l'utilisateur se connecte pour la première fois, il devra modifier son mot de passe 
                else if (dataAccess.VerifyFirstConnection(login) == "Success")
                {
                    NewMedecinPassword newPassword = new(login, this);
                    newPassword.Show();
                    this.Hide();

                }
                // Si tout est correcte, l'utilisateur sera connecté
                else if (dataAccess.VerifyFirstConnection(login) == "Error" && result.Login == login)
                {
                    Index index = new(result, this);
                    index.Show();
                    this.Hide();
                }
                // Prévient de toutes erreurs inconnus
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
