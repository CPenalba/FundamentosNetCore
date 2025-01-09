namespace FundamentosNetCore
{
    partial class Form25ColeccionMascotasJSON
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
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            txtAnyos = new TextBox();
            btnNuevaMascota = new Button();
            label4 = new Label();
            lstMascotas = new ListBox();
            btnLeerMascotas = new Button();
            btnGuardarMascotas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 38);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 125);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Raza";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 211);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 2;
            label3.Text = "Años";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(39, 61);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(39, 148);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(191, 27);
            txtRaza.TabIndex = 4;
            // 
            // txtAnyos
            // 
            txtAnyos.Location = new Point(39, 234);
            txtAnyos.Name = "txtAnyos";
            txtAnyos.Size = new Size(191, 27);
            txtAnyos.TabIndex = 5;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(39, 294);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(191, 50);
            btnNuevaMascota.TabIndex = 6;
            btnNuevaMascota.Text = "Nueva mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 38);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 7;
            label4.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(334, 61);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(186, 284);
            lstMascotas.TabIndex = 8;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // btnLeerMascotas
            // 
            btnLeerMascotas.Location = new Point(568, 110);
            btnLeerMascotas.Name = "btnLeerMascotas";
            btnLeerMascotas.Size = new Size(191, 50);
            btnLeerMascotas.TabIndex = 9;
            btnLeerMascotas.Text = "Leer mascotas";
            btnLeerMascotas.UseVisualStyleBackColor = true;
            btnLeerMascotas.Click += btnLeerMascotas_Click;
            // 
            // btnGuardarMascotas
            // 
            btnGuardarMascotas.Location = new Point(568, 234);
            btnGuardarMascotas.Name = "btnGuardarMascotas";
            btnGuardarMascotas.Size = new Size(191, 50);
            btnGuardarMascotas.TabIndex = 10;
            btnGuardarMascotas.Text = "Guardar mascotas";
            btnGuardarMascotas.UseVisualStyleBackColor = true;
            btnGuardarMascotas.Click += btnGuardarMascotas_Click;
            // 
            // Form25ColeccionMascotasJSON
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardarMascotas);
            Controls.Add(btnLeerMascotas);
            Controls.Add(lstMascotas);
            Controls.Add(label4);
            Controls.Add(btnNuevaMascota);
            Controls.Add(txtAnyos);
            Controls.Add(txtRaza);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form25ColeccionMascotasJSON";
            Text = "Form25ColeccionMascotasJSON";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private TextBox txtAnyos;
        private Button btnNuevaMascota;
        private Label label4;
        private ListBox lstMascotas;
        private Button btnLeerMascotas;
        private Button btnGuardarMascotas;
    }
}