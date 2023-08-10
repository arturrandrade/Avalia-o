namespace Avalição
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
            txtId = new Label();
            textBox1 = new TextBox();
            txtNome = new Label();
            textBox2 = new TextBox();
            txtCPF = new Label();
            textBox3 = new TextBox();
            txtDataNascimento = new Label();
            txtRendaMensal = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(199, 104);
            txtId.Name = "txtId";
            txtId.Size = new Size(20, 15);
            txtId.TabIndex = 0;
            txtId.Text = "Id:";
            txtId.Click += id_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(244, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.AutoSize = true;
            txtNome.Location = new Point(220, 173);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(43, 15);
            txtNome.TabIndex = 2;
            txtNome.Text = "Nome:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(269, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(323, 23);
            textBox2.TabIndex = 3;
            // 
            // txtCPF
            // 
            txtCPF.AutoSize = true;
            txtCPF.Location = new Point(220, 235);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(31, 15);
            txtCPF.TabIndex = 4;
            txtCPF.Text = "CPF:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(269, 227);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(323, 23);
            textBox3.TabIndex = 5;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.AutoSize = true;
            txtDataNascimento.Location = new Point(150, 284);
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.Size = new Size(101, 15);
            txtDataNascimento.TabIndex = 6;
            txtDataNascimento.Text = "Data Nascimento:";
            // 
            // txtRendaMensal
            // 
            txtRendaMensal.AutoSize = true;
            txtRendaMensal.Location = new Point(150, 332);
            txtRendaMensal.Name = "txtRendaMensal";
            txtRendaMensal.Size = new Size(108, 15);
            txtRendaMensal.TabIndex = 7;
            txtRendaMensal.Text = "Renda Mensal (R$):";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(269, 329);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(323, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(269, 281);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(323, 23);
            textBox5.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(601, 390);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(txtRendaMensal);
            Controls.Add(txtDataNascimento);
            Controls.Add(textBox3);
            Controls.Add(txtCPF);
            Controls.Add(textBox2);
            Controls.Add(txtNome);
            Controls.Add(textBox1);
            Controls.Add(txtId);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtId;
        private TextBox textBox1;
        private Label txtNome;
        private TextBox textBox2;
        private Label txtCPF;
        private TextBox textBox3;
        private Label txtDataNascimento;
        private Label txtRendaMensal;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
    }
}