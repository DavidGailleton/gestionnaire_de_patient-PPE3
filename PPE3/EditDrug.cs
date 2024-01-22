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

namespace PPE3
{
    public partial class EditDrug : Form
    {
        string originalName;
        public EditDrug(string name, string description, int quantity)
        {
            InitializeComponent();
            this.textBox1.Text = name;
            this.textBox2.Text = description;
            this.quantityNumericUpDown.Text = quantity.ToString();
            originalName = name;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals("") || !textBox2.Text.Equals(""))
            {
                // use editDrugFromDB function
                DrugDataAccess dataAccess = new DrugDataAccess();
                dataAccess.EditDrugFromDB(this.originalName, textBox1.Text, textBox2.Text, (int)quantityNumericUpDown.Value);
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void EditDrug_Load(object sender, EventArgs e)
        {

        }
    }
}
