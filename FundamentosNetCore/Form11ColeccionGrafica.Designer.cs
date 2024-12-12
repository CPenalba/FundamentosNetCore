namespace FundamentosNetCore
{
    partial class Form11ColeccionGrafica
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
            lstElementos = new ListBox();
            lblItemSeleccionado = new Label();
            lblIndexSeleccionado = new Label();
            label4 = new Label();
            txtNuevoElemento = new TextBox();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 32);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(43, 78);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(196, 164);
            lstElementos.TabIndex = 1;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // lblItemSeleccionado
            // 
            lblItemSeleccionado.AutoSize = true;
            lblItemSeleccionado.Location = new Point(43, 273);
            lblItemSeleccionado.Name = "lblItemSeleccionado";
            lblItemSeleccionado.Size = new Size(145, 20);
            lblItemSeleccionado.TabIndex = 2;
            lblItemSeleccionado.Text = "lblItemSeleccionado";
            // 
            // lblIndexSeleccionado
            // 
            lblIndexSeleccionado.AutoSize = true;
            lblIndexSeleccionado.Location = new Point(43, 323);
            lblIndexSeleccionado.Name = "lblIndexSeleccionado";
            lblIndexSeleccionado.Size = new Size(151, 20);
            lblIndexSeleccionado.TabIndex = 3;
            lblIndexSeleccionado.Text = "lblIndexSeleccionado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 50);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 4;
            label4.Text = "Nuevo elemento";
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(440, 78);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(299, 27);
            txtNuevoElemento.TabIndex = 5;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(440, 142);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(181, 45);
            btnInsertar.TabIndex = 6;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(440, 212);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(181, 44);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(440, 286);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(181, 36);
            btnBorrarTodo.TabIndex = 8;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // Form11ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label4);
            Controls.Add(lblIndexSeleccionado);
            Controls.Add(lblItemSeleccionado);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Name = "Form11ColeccionGrafica";
            Text = "Form11ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstElementos;
        private Label lblItemSeleccionado;
        private Label lblIndexSeleccionado;
        private Label label4;
        private TextBox txtNuevoElemento;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnBorrarTodo;
    }
}