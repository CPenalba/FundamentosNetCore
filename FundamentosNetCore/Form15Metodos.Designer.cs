namespace FundamentosNetCore
{
    partial class Form15Metodos
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
            txtNumero = new TextBox();
            lblResultado = new Label();
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            label2 = new Label();
            txtSoloNumeros = new TextBox();
            label3 = new Label();
            txtSoloLetras = new TextBox();
            lblRaton = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 28);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(48, 51);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(138, 27);
            txtNumero.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(48, 101);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(92, 20);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "lblResultado";
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(48, 138);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(138, 59);
            btnDobleValor.TabIndex = 3;
            btnDobleValor.Text = "Doble Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(48, 220);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(138, 59);
            btnDobleReferencia.TabIndex = 4;
            btnDobleReferencia.Text = "Doble Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(48, 298);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(138, 56);
            btnObjetoReferencia.TabIndex = 5;
            btnObjetoReferencia.Text = "Objeto Referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 28);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 6;
            label2.Text = "Solo numeros";
            // 
            // txtSoloNumeros
            // 
            txtSoloNumeros.Location = new Point(315, 51);
            txtSoloNumeros.Name = "txtSoloNumeros";
            txtSoloNumeros.Size = new Size(206, 27);
            txtSoloNumeros.TabIndex = 7;
            txtSoloNumeros.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 101);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 8;
            label3.Text = "Solo letras";
            // 
            // txtSoloLetras
            // 
            txtSoloLetras.Location = new Point(315, 138);
            txtSoloLetras.Name = "txtSoloLetras";
            txtSoloLetras.Size = new Size(247, 27);
            txtSoloLetras.TabIndex = 9;
            txtSoloLetras.TextChanged += txtSoloLetras_TextChanged;
            txtSoloLetras.KeyPress += txtSoloLetras_KeyPress;
            // 
            // lblRaton
            // 
            lblRaton.Location = new Point(315, 208);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(240, 163);
            lblRaton.TabIndex = 10;
            lblRaton.Text = "lblRaton";
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // Form15Metodos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRaton);
            Controls.Add(txtSoloLetras);
            Controls.Add(label3);
            Controls.Add(txtSoloNumeros);
            Controls.Add(label2);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDobleValor);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form15Metodos";
            Text = "Form15Metodos";
            FormClosed += Form15Metodos_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private Label label2;
        private TextBox txtSoloNumeros;
        private Label label3;
        private TextBox txtSoloLetras;
        private Label lblRaton;
    }
}