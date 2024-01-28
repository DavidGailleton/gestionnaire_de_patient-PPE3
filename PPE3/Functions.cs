using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PPE3
{
    internal class Functions
    {
        // Recherche une donnée présente dans la premiere colonne d'un tableau en fonction d'une boite de texte
        public void Search(System.Windows.Forms.TextBox textBox, DataGridView dataGridView)
        {
            BindingSource bs = new();
            bs.DataSource = dataGridView.DataSource;
            // Cherche au seins de la première colonne du tableau, une chaine de caractères présente n'importe où dans une autre chaine de caractères
            bs.Filter = dataGridView.Columns[0].HeaderText.ToString() + " LIKE '%" + textBox.Text + "%'";
            // Modifie le tableau pour afficher uniquement les lignes recherchées
            dataGridView.DataSource = bs;
        }
    }
}
