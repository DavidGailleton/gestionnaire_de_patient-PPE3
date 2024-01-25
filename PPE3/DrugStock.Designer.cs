namespace PPE3
{
    partial class DrugStock
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
            drugList_dataGridView = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            stockAdd_button = new Button();
            stockAdd_numericUpDown = new NumericUpDown();
            stockRm_numericUpDown = new NumericUpDown();
            removeStock_button = new Button();
            stock_dataGridView = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)drugList_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockAdd_numericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockRm_numericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stock_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // drugList_dataGridView
            // 
            drugList_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            drugList_dataGridView.Location = new Point(530, 237);
            drugList_dataGridView.Margin = new Padding(3, 2, 3, 2);
            drugList_dataGridView.MultiSelect = false;
            drugList_dataGridView.Name = "drugList_dataGridView";
            drugList_dataGridView.ReadOnly = true;
            drugList_dataGridView.RowHeadersWidth = 51;
            drugList_dataGridView.RowTemplate.Height = 29;
            drugList_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            drugList_dataGridView.Size = new Size(432, 197);
            drugList_dataGridView.TabIndex = 1;
            drugList_dataGridView.CellClick += dataGridView1_CellContentClick;
            drugList_dataGridView.CellContentClick += dataGridView1_CellContentClick;
            drugList_dataGridView.CellContentDoubleClick += dataGridView1_CellContentClick;
            drugList_dataGridView.CellDoubleClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(394, 175);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 178);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 4;
            label1.Text = "Chercher";
            // 
            // stockAdd_button
            // 
            stockAdd_button.Location = new Point(149, 52);
            stockAdd_button.Margin = new Padding(3, 2, 3, 2);
            stockAdd_button.Name = "stockAdd_button";
            stockAdd_button.Size = new Size(156, 28);
            stockAdd_button.TabIndex = 7;
            stockAdd_button.Text = "Ajouter du stock :";
            stockAdd_button.UseVisualStyleBackColor = true;
            stockAdd_button.Click += stockAdd_button_Click;
            // 
            // stockAdd_numericUpDown
            // 
            stockAdd_numericUpDown.Location = new Point(310, 57);
            stockAdd_numericUpDown.Margin = new Padding(3, 2, 3, 2);
            stockAdd_numericUpDown.Name = "stockAdd_numericUpDown";
            stockAdd_numericUpDown.Size = new Size(64, 23);
            stockAdd_numericUpDown.TabIndex = 8;
            stockAdd_numericUpDown.ValueChanged += stockAdd_numericUpDown_ValueChanged;
            // 
            // stockRm_numericUpDown
            // 
            stockRm_numericUpDown.Location = new Point(700, 57);
            stockRm_numericUpDown.Margin = new Padding(3, 2, 3, 2);
            stockRm_numericUpDown.Name = "stockRm_numericUpDown";
            stockRm_numericUpDown.Size = new Size(64, 23);
            stockRm_numericUpDown.TabIndex = 11;
            // 
            // removeStock_button
            // 
            removeStock_button.Location = new Point(539, 52);
            removeStock_button.Margin = new Padding(3, 2, 3, 2);
            removeStock_button.Name = "removeStock_button";
            removeStock_button.Size = new Size(156, 28);
            removeStock_button.TabIndex = 10;
            removeStock_button.Text = "Enlever du stock :";
            removeStock_button.UseVisualStyleBackColor = true;
            removeStock_button.Click += removeStock_button_Click;
            // 
            // stock_dataGridView
            // 
            stock_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            stock_dataGridView.Location = new Point(0, 237);
            stock_dataGridView.Margin = new Padding(3, 2, 3, 2);
            stock_dataGridView.Name = "stock_dataGridView";
            stock_dataGridView.RowHeadersWidth = 51;
            stock_dataGridView.RowTemplate.Height = 29;
            stock_dataGridView.Size = new Size(432, 197);
            stock_dataGridView.TabIndex = 12;
            stock_dataGridView.CellContentClick += stock_dataGridView_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 220);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 13;
            label2.Text = "Stock";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 220);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 14;
            label3.Text = "Médicament autorisé";
            label3.Click += label3_Click;
            // 
            // DrugStock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 434);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(stock_dataGridView);
            Controls.Add(stockRm_numericUpDown);
            Controls.Add(removeStock_button);
            Controls.Add(stockAdd_numericUpDown);
            Controls.Add(stockAdd_button);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(drugList_dataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DrugStock";
            Text = "DrugStock";
            Load += DrugStock_Load;
            ((System.ComponentModel.ISupportInitialize)drugList_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockAdd_numericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockRm_numericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)stock_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView drugList_dataGridView;
        private TextBox textBox1;
        private Label label1;
        private Button stockAdd_button;
        private NumericUpDown stockAdd_numericUpDown;
        private NumericUpDown stockRm_numericUpDown;
        private Button removeStock_button;
        private DataGridView stock_dataGridView;
        private Label label2;
        private Label label3;
    }
}