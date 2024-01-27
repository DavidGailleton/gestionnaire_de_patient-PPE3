namespace PPE3
{
    partial class AddMedecin
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
            nom_textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            prenom_textBox = new TextBox();
            label3 = new Label();
            login_textBox = new TextBox();
            dateTimePicker = new DateTimePicker();
            password_maskedTextBox = new MaskedTextBox();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // nom_textBox
            // 
            nom_textBox.Location = new Point(278, 102);
            nom_textBox.Name = "nom_textBox";
            nom_textBox.Size = new Size(218, 27);
            nom_textBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(359, 79);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 1;
            label1.Text = "NOM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 149);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 3;
            label2.Text = "Prenom";
            // 
            // prenom_textBox
            // 
            prenom_textBox.Location = new Point(278, 172);
            prenom_textBox.Name = "prenom_textBox";
            prenom_textBox.Size = new Size(218, 27);
            prenom_textBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 224);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 5;
            label3.Text = "Login";
            // 
            // login_textBox
            // 
            login_textBox.Location = new Point(278, 247);
            login_textBox.Name = "login_textBox";
            login_textBox.Size = new Size(218, 27);
            login_textBox.TabIndex = 4;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(268, 312);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 6;
            // 
            // password_maskedTextBox
            // 
            password_maskedTextBox.Location = new Point(278, 404);
            password_maskedTextBox.Name = "password_maskedTextBox";
            password_maskedTextBox.Size = new Size(218, 27);
            password_maskedTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 381);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 8;
            label4.Text = "Mot de passe";
            // 
            // button1
            // 
            button1.Location = new Point(313, 485);
            button1.Name = "button1";
            button1.Size = new Size(141, 44);
            button1.TabIndex = 9;
            button1.Text = "Créer le medecin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddMedecin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(password_maskedTextBox);
            Controls.Add(dateTimePicker);
            Controls.Add(label3);
            Controls.Add(login_textBox);
            Controls.Add(label2);
            Controls.Add(prenom_textBox);
            Controls.Add(label1);
            Controls.Add(nom_textBox);
            Name = "AddMedecin";
            Text = "AddMedecin";
            FormClosing += AddMedecin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nom_textBox;
        private Label label1;
        private Label label2;
        private TextBox prenom_textBox;
        private Label label3;
        private TextBox login_textBox;
        private DateTimePicker dateTimePicker;
        private MaskedTextBox password_maskedTextBox;
        private Label label4;
        private Button button1;
    }
}