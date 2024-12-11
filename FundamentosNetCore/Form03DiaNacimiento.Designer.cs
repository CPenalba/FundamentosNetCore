namespace FundamentosNetCore
{
    partial class Form03DiaNacimiento
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
            lblDiaSemana = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAnyo = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 19);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "Dia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 104);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 1;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 199);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 2;
            label3.Text = "Anyo";
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Location = new Point(451, 239);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(102, 20);
            lblDiaSemana.TabIndex = 3;
            lblDiaSemana.Text = "lblDiaSemana";
            lblDiaSemana.Click += label4_Click;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(39, 51);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(114, 27);
            txtDia.TabIndex = 4;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(39, 139);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(114, 27);
            txtMes.TabIndex = 5;
            // 
            // txtAnyo
            // 
            txtAnyo.Location = new Point(39, 232);
            txtAnyo.Name = "txtAnyo";
            txtAnyo.Size = new Size(114, 27);
            txtAnyo.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(368, 51);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(266, 131);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular dia nacimiento";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtAnyo);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(lblDiaSemana);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblDiaSemana;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAnyo;
        private Button btnCalcular;
    }
}