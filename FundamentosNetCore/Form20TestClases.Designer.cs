﻿namespace FundamentosNetCore
{
    partial class Form20TestClases
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
            btnPersona = new Button();
            lstClases = new ListBox();
            btnEmpleado = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 17);
            label1.Name = "label1";
            label1.Size = new Size(101, 41);
            label1.TabIndex = 0;
            label1.Text = "Clases";
            // 
            // btnPersona
            // 
            btnPersona.Location = new Point(39, 397);
            btnPersona.Name = "btnPersona";
            btnPersona.Size = new Size(247, 64);
            btnPersona.TabIndex = 2;
            btnPersona.Text = "Persona";
            btnPersona.UseVisualStyleBackColor = true;
            btnPersona.Click += btnPersona_Click;
            // 
            // lstClases
            // 
            lstClases.FormattingEnabled = true;
            lstClases.Location = new Point(37, 55);
            lstClases.Name = "lstClases";
            lstClases.Size = new Size(634, 291);
            lstClases.TabIndex = 1;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Location = new Point(424, 397);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(247, 61);
            btnEmpleado.TabIndex = 3;
            btnEmpleado.Text = "Empleado";
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += button1_Click;
            // 
            // Form20TestClases
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 488);
            Controls.Add(btnEmpleado);
            Controls.Add(lstClases);
            Controls.Add(btnPersona);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form20TestClases";
            Text = "Form20TestClases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPersona;
        private ListBox lstClases;
        private Button btnEmpleado;
    }
}