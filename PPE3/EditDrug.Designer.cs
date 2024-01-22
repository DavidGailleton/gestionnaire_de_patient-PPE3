namespace PPE3
{
    partial class EditDrug
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            quantityLabel = new Label();
            quantityNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(375, 131);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(375, 205);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 27);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(405, 340);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(143, 45);
            button1.TabIndex = 2;
            button1.Text = "Confirmer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(442, 39);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 3;
            label1.Text = "Modifier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 181);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 4;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 107);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 5;
            label3.Text = "Nom";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new Point(405, 277);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(66, 20);
            quantityLabel.TabIndex = 6;
            quantityLabel.Text = "Quantité";
            quantityLabel.Click += label4_Click;
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Location = new Point(472, 275);
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new Size(66, 27);
            quantityNumericUpDown.TabIndex = 7;
            quantityNumericUpDown.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // EditDrug
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(quantityNumericUpDown);
            Controls.Add(quantityLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EditDrug";
            Text = "EditDrug";
            Load += EditDrug_Load;
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label quantityLabel;
        private NumericUpDown quantityNumericUpDown;
    }
}