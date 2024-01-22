namespace PPE3
{
    partial class NewPatient
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
            surname_textbox = new TextBox();
            name_textbox = new TextBox();
            birthday_DateTimePicker = new DateTimePicker();
            surname_label = new Label();
            name_label = new Label();
            birthday_label = new Label();
            create_button = new Button();
            homme_checkBox = new CheckBox();
            femme_checkBox = new CheckBox();
            noSecu_TextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // surname_textbox
            // 
            surname_textbox.Location = new Point(160, 99);
            surname_textbox.Name = "surname_textbox";
            surname_textbox.Size = new Size(194, 27);
            surname_textbox.TabIndex = 0;
            // 
            // name_textbox
            // 
            name_textbox.Location = new Point(451, 99);
            name_textbox.Name = "name_textbox";
            name_textbox.Size = new Size(194, 27);
            name_textbox.TabIndex = 1;
            // 
            // birthday_DateTimePicker
            // 
            birthday_DateTimePicker.Location = new Point(276, 207);
            birthday_DateTimePicker.Name = "birthday_DateTimePicker";
            birthday_DateTimePicker.Size = new Size(250, 27);
            birthday_DateTimePicker.TabIndex = 2;
            birthday_DateTimePicker.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // surname_label
            // 
            surname_label.AutoSize = true;
            surname_label.Location = new Point(237, 60);
            surname_label.Name = "surname_label";
            surname_label.Size = new Size(42, 20);
            surname_label.TabIndex = 3;
            surname_label.Text = "Nom";
            surname_label.Click += label1_Click;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(519, 67);
            name_label.Name = "name_label";
            name_label.Size = new Size(60, 20);
            name_label.TabIndex = 4;
            name_label.Text = "Prenom";
            name_label.Click += label1_Click_1;
            // 
            // birthday_label
            // 
            birthday_label.AutoSize = true;
            birthday_label.Location = new Point(342, 173);
            birthday_label.Name = "birthday_label";
            birthday_label.Size = new Size(132, 20);
            birthday_label.TabIndex = 5;
            birthday_label.Text = "Date de Naissance";
            birthday_label.Click += label1_Click_2;
            // 
            // create_button
            // 
            create_button.Location = new Point(328, 427);
            create_button.Name = "create_button";
            create_button.Size = new Size(134, 55);
            create_button.TabIndex = 6;
            create_button.Text = "Créer";
            create_button.UseVisualStyleBackColor = true;
            create_button.Click += create_button_Click;
            // 
            // homme_checkBox
            // 
            homme_checkBox.AutoSize = true;
            homme_checkBox.Location = new Point(277, 284);
            homme_checkBox.Name = "homme_checkBox";
            homme_checkBox.Size = new Size(85, 24);
            homme_checkBox.TabIndex = 7;
            homme_checkBox.Text = "Homme";
            homme_checkBox.UseVisualStyleBackColor = true;
            homme_checkBox.CheckedChanged += homme_checkBox_CheckedChanged;
            // 
            // femme_checkBox
            // 
            femme_checkBox.AutoSize = true;
            femme_checkBox.Location = new Point(414, 284);
            femme_checkBox.Name = "femme_checkBox";
            femme_checkBox.Size = new Size(80, 24);
            femme_checkBox.TabIndex = 8;
            femme_checkBox.Text = "Femme";
            femme_checkBox.UseVisualStyleBackColor = true;
            femme_checkBox.CheckedChanged += femme_checkBox_CheckedChanged;
            // 
            // noSecu_TextBox
            // 
            noSecu_TextBox.Location = new Point(276, 373);
            noSecu_TextBox.Name = "noSecu_TextBox";
            noSecu_TextBox.Size = new Size(233, 27);
            noSecu_TextBox.TabIndex = 9;
            noSecu_TextBox.TextChanged += noSecu_TextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 350);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
            label1.TabIndex = 10;
            label1.Text = "Numéro de sécurité social";
            // 
            // AddPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 513);
            Controls.Add(label1);
            Controls.Add(noSecu_TextBox);
            Controls.Add(femme_checkBox);
            Controls.Add(homme_checkBox);
            Controls.Add(create_button);
            Controls.Add(birthday_label);
            Controls.Add(name_label);
            Controls.Add(surname_label);
            Controls.Add(birthday_DateTimePicker);
            Controls.Add(name_textbox);
            Controls.Add(surname_textbox);
            Name = "AddPatient";
            Text = "AddPatient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox surname_textbox;
        private TextBox name_textbox;
        private DateTimePicker birthday_DateTimePicker;
        private Label surname_label;
        private Label name_label;
        private Label birthday_label;
        private Button create_button;
        private CheckBox homme_checkBox;
        private CheckBox femme_checkBox;
        private TextBox noSecu_TextBox;
        private Label label1;
    }
}