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
                    if (new_maskedTextBox.TextLength < 8)
                    {
                        string result2 = dataAccess.UpdateMedecinPasswordInDB(login, new_maskedTextBox.Text);
                        if (result2 == "Success")
                        {
                            MessageBox.Show("Nouveau mot de passe établie");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Une erreur inconnu c'est produite");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le mot de passe doit contenir minimum 8 caractères");
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
        }


        private void NewMedecinPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.loginPage.Show();
        }
        
    }
}
