﻿namespace FundamentosNetCore
{
    partial class Form01SumarNumeros
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
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            btnSumarNumeros = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 40);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 131);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Numero 2";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(64, 76);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(182, 27);
            txtNumero1.TabIndex = 3;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(60, 168);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(186, 27);
            txtNumero2.TabIndex = 4;
            // 
            // btnSumarNumeros
            // 
            btnSumarNumeros.Location = new Point(58, 307);
            btnSumarNumeros.Name = "btnSumarNumeros";
            btnSumarNumeros.Size = new Size(188, 60);
            btnSumarNumeros.TabIndex = 5;
            btnSumarNumeros.Text = "Sumar numeros";
            btnSumarNumeros.UseVisualStyleBackColor = true;
            btnSumarNumeros.Click += btnSumarNumeros_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(64, 237);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(92, 20);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "lblResultado";
            lblResultado.Click += label3_Click;
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSumarNumeros);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form01SumarNumeros";
            Text = "Form01SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Button btnSumarNumeros;
        private Label lblResultado;
    }
}