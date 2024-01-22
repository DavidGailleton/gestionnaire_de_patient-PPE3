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
        public void Search(System.Windows.Forms.TextBox textBox, DataGridView dataGridView)
        {
            BindingSource bs = new();
            bs.DataSource = dataGridView.DataSource;
            bs.Filter = dataGridView.Columns[0].HeaderText.ToString() + " LIKE '%" + textBox.Text + "%'";
            dataGridView.DataSource = bs;
        }
    }
}
