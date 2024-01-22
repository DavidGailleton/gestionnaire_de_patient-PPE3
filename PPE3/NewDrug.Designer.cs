namespace PPE3
{
    partial class NewDrug
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            buttonaddDrugWithQuantity = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 113);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Chercher : ";
            // 
            // button1
            // 
            button1.Location = new Point(197, 247);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(146, 64);
            button1.TabIndex = 1;
            button1.Text = "Ajouter 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 110);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(173, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(501, 0);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(594, 600);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += DataGridView1_CellContentClick;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += DataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += DataGridView1_CellContentClick;
            // 
            // buttonaddDrugWithQuantity
            // 
            buttonaddDrugWithQuantity.Location = new Point(197, 351);
            buttonaddDrugWithQuantity.Name = "buttonaddDrugWithQuantity";
            buttonaddDrugWithQuantity.Size = new Size(146, 64);
            buttonaddDrugWithQuantity.TabIndex = 5;
            buttonaddDrugWithQuantity.Text = "Ajouter la quantité suivante :";
            buttonaddDrugWithQuantity.UseVisualStyleBackColor = true;
            buttonaddDrugWithQuantity.Click += ButtonaddDrugWithQuantity_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(358, 371);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(68, 27);
            numericUpDown1.TabIndex = 8;
            // 
            // NewDrug
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 600);
            Controls.Add(numericUpDown1);
            Controls.Add(buttonaddDrugWithQuantity);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NewDrug";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button buttonaddDrugWithQuantity;
        private NumericUpDown numericUpDown1;
    }
}