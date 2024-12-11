namespace FundamentosNetCore
{
    partial class Form06ValidarMail
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
            txtEmail = new TextBox();
            btnValidar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 31);
            label1.Name = "label1";
            label1.Size = new Size(141, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduzca su email:";
            label1.Click += label1_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(42, 69);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(626, 27);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += textBox1_TextChanged;
            // 
            // btnValidar
            // 
            btnValidar.BackColor = Color.Pink;
            btnValidar.Location = new Point(44, 143);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(141, 46);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(235, 169);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(92, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // Form06ValidarMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnValidar);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "Form06ValidarMail";
            Text = "Form06ValidarMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button btnValidar;
        private Label lblResultado;
    }
}