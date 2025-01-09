namespace FundamentosNetCore
{
    partial class Form23ObjetoXMLMascota
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
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            label3 = new Label();
            txtAnyos = new TextBox();
            btnLeerDato = new Button();
            btnGuardarDato = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 36);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 138);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(40, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(210, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(40, 178);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(210, 27);
            txtRaza.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 247);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 4;
            label3.Text = "Años";
            // 
            // txtAnyos
            // 
            txtAnyos.Location = new Point(41, 279);
            txtAnyos.Name = "txtAnyos";
            txtAnyos.Size = new Size(209, 27);
            txtAnyos.TabIndex = 5;
            // 
            // btnLeerDato
            // 
            btnLeerDato.Location = new Point(433, 72);
            btnLeerDato.Name = "btnLeerDato";
            btnLeerDato.Size = new Size(256, 63);
            btnLeerDato.TabIndex = 6;
            btnLeerDato.Text = "Leer dato";
            btnLeerDato.UseVisualStyleBackColor = true;
            btnLeerDato.Click += btnLeerDato_Click;
            // 
            // btnGuardarDato
            // 
            btnGuardarDato.Location = new Point(433, 178);
            btnGuardarDato.Name = "btnGuardarDato";
            btnGuardarDato.Size = new Size(256, 63);
            btnGuardarDato.TabIndex = 7;
            btnGuardarDato.Text = "Guardar dato";
            btnGuardarDato.UseVisualStyleBackColor = true;
            btnGuardarDato.Click += btnGuardarDato_Click;
            // 
            // Form23ObjetoXMLMascota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardarDato);
            Controls.Add(btnLeerDato);
            Controls.Add(txtAnyos);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form23ObjetoXMLMascota";
            Text = "Form23ObjetoXMLMascota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private Label label3;
        private TextBox txtAnyos;
        private Button btnLeerDato;
        private Button btnGuardarDato;
    }
}