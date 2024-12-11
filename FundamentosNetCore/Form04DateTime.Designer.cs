namespace FundamentosNetCore
{
    partial class Form04DateTime
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
            txtFechaActual = new TextBox();
            chkCambiarFormato = new CheckBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            btnIncrementar = new Button();
            txtIncremento = new TextBox();
            rdbAnyos = new RadioButton();
            rdbMeses = new RadioButton();
            rdbDias = new RadioButton();
            label3 = new Label();
            txtNuevaFecha = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha Actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(31, 69);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(469, 27);
            txtFechaActual.TabIndex = 1;
            txtFechaActual.TextChanged += txtFechaActual_TextChanged;
            // 
            // chkCambiarFormato
            // 
            chkCambiarFormato.AutoSize = true;
            chkCambiarFormato.Location = new Point(31, 117);
            chkCambiarFormato.Name = "chkCambiarFormato";
            chkCambiarFormato.Size = new Size(185, 24);
            chkCambiarFormato.TabIndex = 2;
            chkCambiarFormato.Text = "Cambiar formato fecha";
            chkCambiarFormato.UseVisualStyleBackColor = true;
            chkCambiarFormato.CheckedChanged += chkCambiarFormato_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnIncrementar);
            groupBox1.Controls.Add(txtIncremento);
            groupBox1.Controls.Add(rdbAnyos);
            groupBox1.Controls.Add(rdbMeses);
            groupBox1.Controls.Add(rdbDias);
            groupBox1.Location = new Point(31, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 178);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 34);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 5;
            label2.Text = "Incremento";
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(282, 94);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(125, 32);
            btnIncrementar.TabIndex = 4;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(301, 61);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(84, 27);
            txtIncremento.TabIndex = 3;
            // 
            // rdbAnyos
            // 
            rdbAnyos.AutoSize = true;
            rdbAnyos.Location = new Point(18, 92);
            rdbAnyos.Name = "rdbAnyos";
            rdbAnyos.Size = new Size(70, 24);
            rdbAnyos.TabIndex = 2;
            rdbAnyos.TabStop = true;
            rdbAnyos.Text = "Anyos";
            rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(18, 62);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(71, 24);
            rdbMeses.TabIndex = 1;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(18, 32);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(59, 24);
            rdbDias.TabIndex = 0;
            rdbDias.TabStop = true;
            rdbDias.Text = "Dias";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 362);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 4;
            label3.Text = "Nueva fecha";
            // 
            // txtNuevaFecha
            // 
            txtNuevaFecha.Location = new Point(31, 395);
            txtNuevaFecha.Name = "txtNuevaFecha";
            txtNuevaFecha.Size = new Size(277, 27);
            txtNuevaFecha.TabIndex = 5;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNuevaFecha);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(chkCambiarFormato);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            Load += Form04DateTime_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFechaActual;
        private CheckBox chkCambiarFormato;
        private GroupBox groupBox1;
        private RadioButton rdbDias;
        private Label label2;
        private Button btnIncrementar;
        private TextBox txtIncremento;
        private RadioButton rdbAnyos;
        private RadioButton rdbMeses;
        private Label label3;
        private TextBox txtNuevaFecha;
    }
}