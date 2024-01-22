using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPE3;
using PPE3.DataAccess;

namespace PPE3_DEBUG
{
    public partial class AddAdmin : Form
    {
        private Login login;
        public AddAdmin(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login_textBox.Text == "" | password_maskedTextBox.Text == "")
            {
                MessageBox.Show("Veuillez rentrer un nom d'utilisateur et un mot de passe");
            }
            else
            {
                AdminDataAccess dataAccess = new();
                string result = dataAccess.AddAdminInDB(login_textBox.Text, password_maskedTextBox.Text);
                if (result == "Success")
                {
                    AdminPage adminPage = new(login);
                    adminPage.Show();
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue");
                }
            }
        }
    }
}
