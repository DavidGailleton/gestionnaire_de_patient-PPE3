using PPE3.DataAccess;
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
    public partial class NewMedecinPassword : Form
    {
        string login;
        Login loginPage;
        public NewMedecinPassword(string login, Login loginPage)
        {
            InitializeComponent();
            this.login = login;
            this.loginPage = loginPage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedecinDataAccess dataAccess = new MedecinDataAccess();
            string result = dataAccess.VerifyPassword(this.login, original_maskedTextBox.Text.ToString());
            if (result == "Success")
            {
                if (new_maskedTextBox.Text == confirmeNew_maskedTextBox.Text)
                {
                    string result2 = dataAccess.UpdateMedecinPasswordInDB(login, new_maskedTextBox.Text);
                    if (result2 == "Success")
                    {
                        MessageBox.Show("Nouveau mot de passe établie");
                        loginPage.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("La confirmation du nouveau mot de passe n'est pas valide");
                }
            }
            else
            {
                MessageBox.Show("Mot de passe original incorrect");
            }
        }
    }
}
