using PPE3.DataAccess;
using PPE3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_DEBUG
{
    public partial class NewAdminPassword : Form
    {
        string login;
        Login loginPage;
        public NewAdminPassword(string login, Login loginPage)
        {
            InitializeComponent();
            this.login = login;
            this.loginPage = loginPage;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AdminDataAccess dataAccess = new();
            string result = dataAccess.VerifyPassword(this.login, original_maskedTextBox.Text.ToString());
            if (result == "Success")
            {
                if (new_maskedTextBox.Text == confirmeNew_maskedTextBox.Text)
                {
                    string result2 = dataAccess.UpdateAdminPasswordInDB(login, new_maskedTextBox.Text);
                    if (result2 == "Success")
                    {
                        MessageBox.Show("Nouveau mot de passe établie");
                        loginPage.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Le mot de passe original ou la confirmation du nouveau mot de passe n'est pas valide");
                }
            }
            else
            {
                MessageBox.Show("Mot de passe original incorrect");
            }
        }

        private void NewMedecinPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginPage.Show();
            this.Close();
        }

    }
}
