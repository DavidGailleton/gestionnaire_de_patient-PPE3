namespace PPE3_DEBUG
{
    partial class NewAdminPassword
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
            confirmeNew_maskedTextBox = new TextBox();
            new_maskedTextBox = new TextBox();
            original_maskedTextBox = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // confirmeNew_maskedTextBox
            // 
            confirmeNew_maskedTextBox.Location = new Point(291, 248);
            confirmeNew_maskedTextBox.Name = "confirmeNew_maskedTextBox";
            confirmeNew_maskedTextBox.PasswordChar = '*';
            confirmeNew_maskedTextBox.Size = new Size(197, 27);
            confirmeNew_maskedTextBox.TabIndex = 19;
            // 
            // new_maskedTextBox
            // 
            new_maskedTextBox.Location = new Point(291, 166);
            new_maskedTextBox.Name = "new_maskedTextBox";
            new_maskedTextBox.PasswordChar = '*';
            new_maskedTextBox.Size = new Size(197, 27);
            new_maskedTextBox.TabIndex = 18;
            // 
            // original_maskedTextBox
            // 
            original_maskedTextBox.Location = new Point(291, 88);
            original_maskedTextBox.Name = "original_maskedTextBox";
            original_maskedTextBox.PasswordChar = '*';
            original_maskedTextBox.Size = new Size(197, 27);
            original_maskedTextBox.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(329, 345);
            button1.Name = "button1";
            button1.Size = new Size(124, 40);
            button1.TabIndex = 16;
            button1.Text = "Confirmer";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 214);
            label3.Name = "label3";
            label3.Size = new Size(270, 20);
            label3.TabIndex = 15;
            label3.Text = "Confirmation du nouveau mot de passe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 143);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 14;
            label2.Text = "Nouveau mot de passe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 65);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 13;
            label1.Text = "Mot de passe original";
            // 
            // NewAdminPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(confirmeNew_maskedTextBox);
            Controls.Add(new_maskedTextBox);
            Controls.Add(original_maskedTextBox);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewAdminPassword";
            Text = "NewAdminPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox confirmeNew_maskedTextBox;
        private TextBox new_maskedTextBox;
        private TextBox original_maskedTextBox;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}