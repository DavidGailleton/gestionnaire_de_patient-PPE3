namespace PPE3_DEBUG
{
    partial class AddAdmin
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
            button1 = new Button();
            label4 = new Label();
            password_maskedTextBox = new MaskedTextBox();
            label3 = new Label();
            login_textBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(233, 308);
            button1.Name = "button1";
            button1.Size = new Size(165, 55);
            button1.TabIndex = 19;
            button1.Text = "Créer l'administrateur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 190);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 18;
            label4.Text = "Mot de passe";
            // 
            // password_maskedTextBox
            // 
            password_maskedTextBox.Location = new Point(209, 213);
            password_maskedTextBox.Name = "password_maskedTextBox";
            password_maskedTextBox.PasswordChar = '*';
            password_maskedTextBox.Size = new Size(218, 27);
            password_maskedTextBox.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(290, 117);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 15;
            label3.Text = "Login";
            // 
            // login_textBox
            // 
            login_textBox.Location = new Point(209, 140);
            login_textBox.Name = "login_textBox";
            login_textBox.Size = new Size(218, 27);
            login_textBox.TabIndex = 14;
            // 
            // AddAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 462);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(password_maskedTextBox);
            Controls.Add(label3);
            Controls.Add(login_textBox);
            Name = "AddAdmin";
            Text = "AddAdmin";
            FormClosing += AddAdmin_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label4;
        private MaskedTextBox password_maskedTextBox;
        private Label label3;
        private TextBox login_textBox;
    }
}