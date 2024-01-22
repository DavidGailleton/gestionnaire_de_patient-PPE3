namespace PPE3
{
    partial class AddAllergie
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
            select_button = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            NewAllergie_button = new Button();
            label1 = new Label();
            addAllergie_textBox = new TextBox();
            return_button = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // select_button
            // 
            select_button.Location = new Point(330, 365);
            select_button.Name = "select_button";
            select_button.Size = new Size(151, 59);
            select_button.TabIndex = 6;
            select_button.Text = "Ajouter l allergie";
            select_button.UseVisualStyleBackColor = true;
            select_button.Click += select_button_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(274, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.Location = new Point(575, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(362, 467);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // NewAllergie_button
            // 
            NewAllergie_button.Location = new Point(22, 210);
            NewAllergie_button.Name = "NewAllergie_button";
            NewAllergie_button.Size = new Size(234, 32);
            NewAllergie_button.TabIndex = 7;
            NewAllergie_button.Text = "Ajouter une nouvelle allergie ";
            NewAllergie_button.UseVisualStyleBackColor = true;
            NewAllergie_button.Click += NewAllergie_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 30);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 8;
            label1.Text = "Recherche";
            // 
            // addAllergie_textBox
            // 
            addAllergie_textBox.Location = new Point(287, 213);
            addAllergie_textBox.Name = "addAllergie_textBox";
            addAllergie_textBox.Size = new Size(194, 27);
            addAllergie_textBox.TabIndex = 9;
            // 
            // return_button
            // 
            return_button.Location = new Point(36, 365);
            return_button.Name = "return_button";
            return_button.Size = new Size(147, 59);
            return_button.TabIndex = 10;
            return_button.Text = "Retourner sur le profile";
            return_button.UseVisualStyleBackColor = true;
            return_button.Click += return_button_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // AddAllergie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 467);
            Controls.Add(return_button);
            Controls.Add(addAllergie_textBox);
            Controls.Add(label1);
            Controls.Add(NewAllergie_button);
            Controls.Add(select_button);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "AddAllergie";
            Text = "v";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button select_button;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button NewAllergie_button;
        private Label label1;
        private TextBox addAllergie_textBox;
        private Button return_button;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}