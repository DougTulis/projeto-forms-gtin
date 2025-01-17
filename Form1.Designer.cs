namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblGtinValido = new Label();
            txt_nome = new TextBox();
            btnConsultar = new Button();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            Coluna1 = new DataGridViewTextBoxColumn();
            Coluna2 = new DataGridViewTextBoxColumn();
            Coluna3 = new DataGridViewTextBoxColumn();
            Coluna4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblGtinValido
            // 
            resources.ApplyResources(lblGtinValido, "lblGtinValido");
            lblGtinValido.Name = "lblGtinValido";
            lblGtinValido.Click += label1_Click;
            // 
            // txt_nome
            // 
            resources.ApplyResources(txt_nome, "txt_nome");
            txt_nome.Name = "txt_nome";
            txt_nome.TextChanged += textBox1_TextChanged;
            // 
            // btnConsultar
            // 
            resources.ApplyResources(btnConsultar, "btnConsultar");
            btnConsultar.Name = "btnConsultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += button1_Click_2;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Coluna1, Coluna2, Coluna3, Coluna4 });
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            // 
            // Coluna1
            // 
            resources.ApplyResources(Coluna1, "Coluna1");
            Coluna1.Name = "Coluna1";
            Coluna1.ReadOnly = true;
            // 
            // Coluna2
            // 
            resources.ApplyResources(Coluna2, "Coluna2");
            Coluna2.Name = "Coluna2";
            Coluna2.ReadOnly = true;
            // 
            // Coluna3
            // 
            resources.ApplyResources(Coluna3, "Coluna3");
            Coluna3.Name = "Coluna3";
            Coluna3.ReadOnly = true;
            // 
            // Coluna4
            // 
            resources.ApplyResources(Coluna4, "Coluna4");
            Coluna4.Name = "Coluna4";
            Coluna4.ReadOnly = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(btnConsultar);
            Controls.Add(txt_nome);
            Controls.Add(lblGtinValido);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblGtinValido;
        private TextBox txt_nome;
        private Button btnConsultar;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Coluna1;
        private DataGridViewTextBoxColumn Coluna2;
        private DataGridViewTextBoxColumn Coluna3;
        private DataGridViewTextBoxColumn Coluna4;
    }
}
