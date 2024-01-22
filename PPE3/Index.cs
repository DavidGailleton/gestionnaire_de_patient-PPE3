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
    public partial class Index : Form
    {
        Medecin medecin;
        Login login;
        internal Index(Medecin medecin, Login login)
        {
            InitializeComponent();
            this.medecin = medecin;
            this.login = login;
        }

        private void NewDrugButton_Click(object sender, EventArgs e)
        {
            NewDrug newDrug = new();
            newDrug.Show();
        }

        private void EditDrugButton_Click(object sender, EventArgs e)
        {
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void listePatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListPatient listPatient = new(medecin);
            listPatient.Show();
        }

        private void addPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPatient addPatient = new(medecin);
            addPatient.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DrugStock ds = new();
            ds.Show();
        }

        private void historiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdonnanceHistory oh = new();
            oh.Show();
        }

        private void Index_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }
    }
}
