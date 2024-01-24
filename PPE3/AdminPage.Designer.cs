namespace PPE3
{
    partial class AdminPage
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
            dataGridView1 = new DataGridView();
            addMedecinButton = new Button();
            deleteMedecinButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            textBox2 = new TextBox();
            deleteAdmin_button = new Button();
            addAdmin_button = new Button();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 327);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(623, 490);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += DataGridView1_CellContentClick;
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
            dataGridView1.CellContentDoubleClick += DataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += DataGridView1_CellContentClick;
            // 
            // addMedecinButton
            // 
            addMedecinButton.Location = new Point(254, 79);
            addMedecinButton.Name = "addMedecinButton";
            addMedecinButton.Size = new Size(146, 60);
            addMedecinButton.TabIndex = 1;
            addMedecinButton.Text = "Ajouter un utilisateur";
            addMedecinButton.UseVisualStyleBackColor = true;
            addMedecinButton.Click += AddMedecinButton_Click;
            // 
            // deleteMedecinButton
            // 
            deleteMedecinButton.Location = new Point(254, 165);
            deleteMedecinButton.Name = "deleteMedecinButton";
            deleteMedecinButton.Size = new Size(146, 60);
            deleteMedecinButton.TabIndex = 3;
            deleteMedecinButton.Text = "Supprimer un utilisateur";
            deleteMedecinButton.UseVisualStyleBackColor = true;
            deleteMedecinButton.Click += DeleteMedecinButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 283);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 27);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += TextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 286);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 5;
            label1.Text = "Rechercher :";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(668, 327);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(642, 490);
            dataGridView2.TabIndex = 6;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(675, 286);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 10;
            label2.Text = "Rechercher :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(783, 283);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 27);
            textBox2.TabIndex = 9;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // deleteAdmin_button
            // 
            deleteAdmin_button.Location = new Point(906, 165);
            deleteAdmin_button.Name = "deleteAdmin_button";
            deleteAdmin_button.Size = new Size(146, 60);
            deleteAdmin_button.TabIndex = 8;
            deleteAdmin_button.Text = "Supprimer un administrateur";
            deleteAdmin_button.UseVisualStyleBackColor = true;
            deleteAdmin_button.Click += deleteAdmin_button_Click;
            // 
            // addAdmin_button
            // 
            addAdmin_button.Location = new Point(906, 79);
            addAdmin_button.Name = "addAdmin_button";
            addAdmin_button.Size = new Size(146, 60);
            addAdmin_button.TabIndex = 7;
            addAdmin_button.Text = "Ajouter un administrateur";
            addAdmin_button.UseVisualStyleBackColor = true;
            addAdmin_button.Click += addAdmin_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 22);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 11;
            label3.Text = "Utilisateur";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(923, 22);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 12;
            label4.Text = "Administrateur";
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 817);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(deleteAdmin_button);
            Controls.Add(addAdmin_button);
            Controls.Add(dataGridView2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(deleteMedecinButton);
            Controls.Add(addMedecinButton);
            Controls.Add(dataGridView1);
            Name = "AdminPage";
            Text = "AdminPage";
            FormClosed += AdminPage_FormClosed;
            Load += AdminPage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addMedecinButton;
        private Button deleteMedecinButton;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView2;
        private Label label2;
        private TextBox textBox2;
        private Button deleteAdmin_button;
        private Button addAdmin_button;
        private Label label3;
        private Label label4;
    }
}