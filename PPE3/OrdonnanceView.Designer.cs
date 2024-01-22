namespace PPE3
{
    partial class OrdonnanceView
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
            NomMedecinLabel = new Label();
            DateLabel = new Label();
            PatientLabel = new Label();
            MedicamentLabel = new Label();
            print_button = new Button();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // NomMedecinLabel
            // 
            NomMedecinLabel.AutoSize = true;
            NomMedecinLabel.Location = new Point(27, 40);
            NomMedecinLabel.Name = "NomMedecinLabel";
            NomMedecinLabel.Size = new Size(101, 20);
            NomMedecinLabel.TabIndex = 0;
            NomMedecinLabel.Text = "Docteur NOM";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(698, 132);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(45, 20);
            DateLabel.TabIndex = 1;
            DateLabel.Text = "DATE";
            // 
            // PatientLabel
            // 
            PatientLabel.AutoSize = true;
            PatientLabel.Location = new Point(33, 186);
            PatientLabel.Name = "PatientLabel";
            PatientLabel.Size = new Size(134, 20);
            PatientLabel.TabIndex = 2;
            PatientLabel.Text = "Sexe NOM Prenom";
            // 
            // MedicamentLabel
            // 
            MedicamentLabel.AutoSize = true;
            MedicamentLabel.Location = new Point(35, 242);
            MedicamentLabel.Name = "MedicamentLabel";
            MedicamentLabel.Size = new Size(356, 20);
            MedicamentLabel.TabIndex = 3;
            MedicamentLabel.Text = "Libelle Medicament - posologie - instruction - duree";
            // 
            // print_button
            // 
            print_button.Location = new Point(290, 436);
            print_button.Name = "print_button";
            print_button.Size = new Size(127, 49);
            print_button.TabIndex = 5;
            print_button.Text = "Print PDF";
            print_button.UseVisualStyleBackColor = true;
            print_button.Click += print_button_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // OrdonnanceView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 549);
            Controls.Add(print_button);
            Controls.Add(MedicamentLabel);
            Controls.Add(PatientLabel);
            Controls.Add(DateLabel);
            Controls.Add(NomMedecinLabel);
            Name = "OrdonnanceView";
            Text = "OrdonnanceView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NomMedecinLabel;
        private Label DateLabel;
        private Label PatientLabel;
        private Label MedicamentLabel;
        private Button print_button;
        private SaveFileDialog saveFileDialog1;
    }
}