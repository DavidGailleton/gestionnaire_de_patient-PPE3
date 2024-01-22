namespace PPE3
{
    partial class NewAntecedent
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
            Libelle_textBox = new TextBox();
            medic_dataGridView = new DataGridView();
            confirm_button = new Button();
            Search_textBox = new TextBox();
            antecedant_label = new Label();
            search_label = new Label();
            selected_dataGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            name_label = new Label();
            return_button = new Button();
            ((System.ComponentModel.ISupportInitialize)medic_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)selected_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Libelle_textBox
            // 
            Libelle_textBox.Location = new Point(43, 225);
            Libelle_textBox.Name = "Libelle_textBox";
            Libelle_textBox.Size = new Size(300, 27);
            Libelle_textBox.TabIndex = 0;
            // 
            // medic_dataGridView
            // 
            medic_dataGridView.AllowUserToAddRows = false;
            medic_dataGridView.AllowUserToDeleteRows = false;
            medic_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            medic_dataGridView.Location = new Point(438, 42);
            medic_dataGridView.Name = "medic_dataGridView";
            medic_dataGridView.ReadOnly = true;
            medic_dataGridView.RowHeadersWidth = 51;
            medic_dataGridView.RowTemplate.Height = 29;
            medic_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            medic_dataGridView.Size = new Size(498, 209);
            medic_dataGridView.TabIndex = 1;
            medic_dataGridView.CellClick += medic_dataGridView_CellContentClick;
            medic_dataGridView.CellDoubleClick += medic_dataGridView_CellContentClick;
            // 
            // confirm_button
            // 
            confirm_button.Location = new Point(128, 322);
            confirm_button.Name = "confirm_button";
            confirm_button.Size = new Size(133, 57);
            confirm_button.TabIndex = 2;
            confirm_button.Text = "Ajouter";
            confirm_button.UseVisualStyleBackColor = true;
            confirm_button.Click += confirm_button_Click;
            // 
            // Search_textBox
            // 
            Search_textBox.Location = new Point(764, 9);
            Search_textBox.Name = "Search_textBox";
            Search_textBox.Size = new Size(172, 27);
            Search_textBox.TabIndex = 3;
            // 
            // antecedant_label
            // 
            antecedant_label.AutoSize = true;
            antecedant_label.Location = new Point(128, 171);
            antecedant_label.Name = "antecedant_label";
            antecedant_label.Size = new Size(133, 20);
            antecedant_label.TabIndex = 4;
            antecedant_label.Text = "Libelle Antecedant";
            // 
            // search_label
            // 
            search_label.AutoSize = true;
            search_label.Location = new Point(660, 12);
            search_label.Name = "search_label";
            search_label.Size = new Size(85, 20);
            search_label.TabIndex = 5;
            search_label.Text = "rechercher :";
            // 
            // selected_dataGridView
            // 
            selected_dataGridView.AllowUserToAddRows = false;
            selected_dataGridView.AllowUserToDeleteRows = false;
            selected_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selected_dataGridView.Location = new Point(438, 306);
            selected_dataGridView.Name = "selected_dataGridView";
            selected_dataGridView.ReadOnly = true;
            selected_dataGridView.RowHeadersWidth = 51;
            selected_dataGridView.RowTemplate.Height = 29;
            selected_dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            selected_dataGridView.Size = new Size(498, 209);
            selected_dataGridView.TabIndex = 6;
            selected_dataGridView.CellClick += selected_dataGridView_CellContentClick;
            selected_dataGridView.CellDoubleClick += selected_dataGridView_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(438, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 7;
            label1.Text = "Medicaments incompatible";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(438, 274);
            label2.Name = "label2";
            label2.Size = new Size(275, 20);
            label2.TabIndex = 8;
            label2.Text = "Medicaments incompatible selectionnés";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(12, 16);
            name_label.Name = "name_label";
            name_label.Size = new Size(99, 20);
            name_label.TabIndex = 9;
            name_label.Text = "NOM Prenom";
            // 
            // return_button
            // 
            return_button.Location = new Point(12, 456);
            return_button.Name = "return_button";
            return_button.Size = new Size(147, 59);
            return_button.TabIndex = 11;
            return_button.Text = "Retourner sur le profile";
            return_button.UseVisualStyleBackColor = true;
            return_button.Click += return_button_Click;
            // 
            // NewAntecedent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 527);
            Controls.Add(return_button);
            Controls.Add(name_label);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(selected_dataGridView);
            Controls.Add(search_label);
            Controls.Add(antecedant_label);
            Controls.Add(Search_textBox);
            Controls.Add(confirm_button);
            Controls.Add(medic_dataGridView);
            Controls.Add(Libelle_textBox);
            Name = "NewAntecedent";
            Text = "NewAntecedant";
            ((System.ComponentModel.ISupportInitialize)medic_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)selected_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Libelle_textBox;
        private DataGridView medic_dataGridView;
        private Button confirm_button;
        private TextBox Search_textBox;
        private Label antecedant_label;
        private Label search_label;
        private DataGridView selected_dataGridView;
        private Label label1;
        private Label label2;
        private Label name_label;
        private Button return_button;
    }
}