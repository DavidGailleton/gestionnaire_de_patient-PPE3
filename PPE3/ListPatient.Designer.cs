namespace PPE3
{
    partial class ListPatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            textBox1 = new TextBox();
            select_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(397, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(734, 450);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 95);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 1;
            label1.Text = "Chercher :";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // select_button
            // 
            select_button.Location = new Point(109, 279);
            select_button.Name = "select_button";
            select_button.Size = new Size(151, 59);
            select_button.TabIndex = 3;
            select_button.Text = "Selectionner";
            select_button.UseVisualStyleBackColor = true;
            select_button.Click += select_button_Click;
            // 
            // ListPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 450);
            Controls.Add(select_button);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ListPatient";
            Text = "ListPatient";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox textBox1;
        private Button select_button;
    }
}