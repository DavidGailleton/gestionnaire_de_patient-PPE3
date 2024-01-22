namespace PPE3
{
    partial class PatientProfile
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
            name_label = new Label();
            antecedant_dataGridView = new DataGridView();
            allergie_dataGridView = new DataGridView();
            antecedant_button = new Button();
            allergie_button = new Button();
            newOrdonnance_button = new Button();
            label1 = new Label();
            label2 = new Label();
            noSecu_label = new Label();
            ((System.ComponentModel.ISupportInitialize)antecedant_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allergie_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(12, 20);
            name_label.Name = "name_label";
            name_label.Size = new Size(46, 20);
            name_label.TabIndex = 0;
            name_label.Text = "name";
            // 
            // antecedant_dataGridView
            // 
            antecedant_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            antecedant_dataGridView.Location = new Point(127, 90);
            antecedant_dataGridView.Name = "antecedant_dataGridView";
            antecedant_dataGridView.RowHeadersWidth = 51;
            antecedant_dataGridView.RowTemplate.Height = 29;
            antecedant_dataGridView.Size = new Size(300, 188);
            antecedant_dataGridView.TabIndex = 1;
            // 
            // allergie_dataGridView
            // 
            allergie_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allergie_dataGridView.Location = new Point(599, 90);
            allergie_dataGridView.Name = "allergie_dataGridView";
            allergie_dataGridView.RowHeadersWidth = 51;
            allergie_dataGridView.RowTemplate.Height = 29;
            allergie_dataGridView.Size = new Size(300, 188);
            allergie_dataGridView.TabIndex = 2;
            // 
            // antecedant_button
            // 
            antecedant_button.Location = new Point(219, 320);
            antecedant_button.Name = "antecedant_button";
            antecedant_button.Size = new Size(94, 29);
            antecedant_button.TabIndex = 3;
            antecedant_button.Text = "Ajouter";
            antecedant_button.UseVisualStyleBackColor = true;
            antecedant_button.Click += antecedant_button_Click;
            // 
            // allergie_button
            // 
            allergie_button.Location = new Point(707, 320);
            allergie_button.Name = "allergie_button";
            allergie_button.Size = new Size(94, 29);
            allergie_button.TabIndex = 4;
            allergie_button.Text = "Ajouter";
            allergie_button.UseVisualStyleBackColor = true;
            allergie_button.Click += allergie_button_Click;
            // 
            // newOrdonnance_button
            // 
            newOrdonnance_button.Location = new Point(414, 421);
            newOrdonnance_button.Name = "newOrdonnance_button";
            newOrdonnance_button.Size = new Size(194, 60);
            newOrdonnance_button.TabIndex = 5;
            newOrdonnance_button.Text = "Nouvelle ordonnance";
            newOrdonnance_button.UseVisualStyleBackColor = true;
            newOrdonnance_button.Click += newOrdonnance_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 46);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 6;
            label1.Text = "Antecedant";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(719, 46);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 7;
            label2.Text = "Allergie";
            // 
            // noSecu_label
            // 
            noSecu_label.AutoSize = true;
            noSecu_label.Location = new Point(877, 20);
            noSecu_label.Name = "noSecu_label";
            noSecu_label.Size = new Size(61, 20);
            noSecu_label.TabIndex = 8;
            noSecu_label.Text = "no_secu";
            // 
            // PatientProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 505);
            Controls.Add(noSecu_label);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(newOrdonnance_button);
            Controls.Add(allergie_button);
            Controls.Add(antecedant_button);
            Controls.Add(allergie_dataGridView);
            Controls.Add(antecedant_dataGridView);
            Controls.Add(name_label);
            Name = "PatientProfile";
            Text = "PatientProfile";
            ((System.ComponentModel.ISupportInitialize)antecedant_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)allergie_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label name_label;
        private DataGridView antecedant_dataGridView;
        private DataGridView allergie_dataGridView;
        private Button antecedant_button;
        private Button allergie_button;
        private Button newOrdonnance_button;
        private Label label1;
        private Label label2;
        private Label noSecu_label;
    }
}