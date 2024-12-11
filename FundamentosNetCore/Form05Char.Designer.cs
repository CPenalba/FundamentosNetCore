namespace FundamentosNetCore
{
    partial class Form05Char
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
            label4 = new Label();
            txtNumeros = new TextBox();
            txtSimbolos = new TextBox();
            txtLetras = new TextBox();
            txtPuntuacion = new TextBox();
            btnRun = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 35);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Numeros";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 192);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Simbolos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(429, 35);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 2;
            label3.Text = "Letras";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(429, 192);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 3;
            label4.Text = "Puntuacion";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(73, 58);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(219, 121);
            txtNumeros.TabIndex = 4;
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(73, 215);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(219, 118);
            txtSimbolos.TabIndex = 5;
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(429, 58);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(219, 121);
            txtLetras.TabIndex = 6;
            txtLetras.TextChanged += txtLetras_TextChanged;
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(429, 215);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(219, 118);
            txtPuntuacion.TabIndex = 7;
            // 
            // btnRun
            // 
            btnRun.BackColor = SystemColors.ControlDarkDark;
            btnRun.Location = new Point(275, 360);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(172, 78);
            btnRun.TabIndex = 8;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRun);
            Controls.Add(txtPuntuacion);
            Controls.Add(txtLetras);
            Controls.Add(txtSimbolos);
            Controls.Add(txtNumeros);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form05Char";
            Text = "Form05Char";
            Load += Form05Char_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNumeros;
        private TextBox txtSimbolos;
        private TextBox txtLetras;
        private TextBox txtPuntuacion;
        private Button btnRun;
    }
}