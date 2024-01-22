namespace PPE3
{
    partial class NewPassword
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            original_maskedTextBox = new MaskedTextBox();
            new_maskedTextBox = new MaskedTextBox();
            confirmeNew_maskedTextBox = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 111);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 0;
            label1.Text = "Mot de passe original";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 189);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 2;
            label2.Text = "Nouveau mot de passe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(166, 260);
            label3.Name = "label3";
            label3.Size = new Size(270, 20);
            label3.TabIndex = 4;
            label3.Text = "Confirmation du nouveau mot de passe";
            // 
            // button1
            // 
            button1.Location = new Point(230, 391);
            button1.Name = "button1";
            button1.Size = new Size(124, 40);
            button1.TabIndex = 6;
            button1.Text = "Confirmer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // original_maskedTextBox
            // 
            original_maskedTextBox.Location = new Point(192, 134);
            original_maskedTextBox.Name = "original_maskedTextBox";
            original_maskedTextBox.Size = new Size(197, 27);
            original_maskedTextBox.TabIndex = 7;
            // 
            // new_maskedTextBox
            // 
            new_maskedTextBox.Location = new Point(192, 212);
            new_maskedTextBox.Name = "new_maskedTextBox";
            new_maskedTextBox.Size = new Size(197, 27);
            new_maskedTextBox.TabIndex = 8;
            // 
            // confirmeNew_maskedTextBox
            // 
            confirmeNew_maskedTextBox.Location = new Point(192, 283);
            confirmeNew_maskedTextBox.Name = "confirmeNew_maskedTextBox";
            confirmeNew_maskedTextBox.Size = new Size(197, 27);
            confirmeNew_maskedTextBox.TabIndex = 9;
            // 
            // NewPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 484);
            Controls.Add(confirmeNew_maskedTextBox);
            Controls.Add(new_maskedTextBox);
            Controls.Add(original_maskedTextBox);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NewPassword";
            Text = "NewPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private MaskedTextBox original_maskedTextBox;
        private MaskedTextBox new_maskedTextBox;
        private MaskedTextBox confirmeNew_maskedTextBox;
    }
}