namespace FundamentosNetCore
{
    partial class Form10ValidarDni
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
            txtDNI = new TextBox();
            btnValidar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 35);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduzca DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(58, 71);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(223, 27);
            txtDNI.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(58, 128);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(172, 37);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar DNI";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(58, 203);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(92, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "lblResultado";
            // 
            // Form10ValidarDni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnValidar);
            Controls.Add(txtDNI);
            Controls.Add(label1);
            Name = "Form10ValidarDni";
            Text = "Form10ValidarDni";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDNI;
        private Button btnValidar;
        private Label lblResultado;
    }
}