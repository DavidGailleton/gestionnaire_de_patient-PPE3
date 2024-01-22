namespace PPE3
{
    partial class NewOrdonnance
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
            numericUpDown1 = new NumericUpDown();
            posologie_richTextBox = new RichTextBox();
            Instruction_richTextBox = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            Seqrch_textBox = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(751, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(304, 529);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 60);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 1;
            label1.Text = "Posologie :";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(185, 192);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(95, 27);
            numericUpDown1.TabIndex = 2;
            // 
            // posologie_richTextBox
            // 
            posologie_richTextBox.Location = new Point(159, 60);
            posologie_richTextBox.Name = "posologie_richTextBox";
            posologie_richTextBox.Size = new Size(316, 89);
            posologie_richTextBox.TabIndex = 3;
            posologie_richTextBox.Text = "";
            // 
            // Instruction_richTextBox
            // 
            Instruction_richTextBox.Location = new Point(159, 271);
            Instruction_richTextBox.Name = "Instruction_richTextBox";
            Instruction_richTextBox.Size = new Size(316, 144);
            Instruction_richTextBox.TabIndex = 4;
            Instruction_richTextBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 194);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 5;
            label2.Text = "Durée (en jours) :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 274);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 6;
            label3.Text = "Instruction :";
            // 
            // button1
            // 
            button1.Location = new Point(312, 471);
            button1.Name = "button1";
            button1.Size = new Size(134, 46);
            button1.TabIndex = 7;
            button1.Text = "Créer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Seqrch_textBox
            // 
            Seqrch_textBox.Location = new Point(591, 12);
            Seqrch_textBox.Name = "Seqrch_textBox";
            Seqrch_textBox.Size = new Size(154, 27);
            Seqrch_textBox.TabIndex = 8;
            Seqrch_textBox.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(508, 15);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 9;
            label4.Text = "Recherche :";
            // 
            // NewOrdonnance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 529);
            Controls.Add(label4);
            Controls.Add(Seqrch_textBox);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Instruction_richTextBox);
            Controls.Add(posologie_richTextBox);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "NewOrdonnance";
            Text = "NewAllergie";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private RichTextBox posologie_richTextBox;
        private RichTextBox Instruction_richTextBox;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox Seqrch_textBox;
        private Label label4;
    }
}