namespace FundamentosNetCore
{
    partial class Form12ColeccionMultiple
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
            lblItem = new Label();
            lblIndex = new Label();
            label2 = new Label();
            txtNuevoElemento = new TextBox();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 33);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(40, 67);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(277, 184);
            lstElementos.TabIndex = 1;
            lstElementos.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(52, 294);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(149, 20);
            lblItem.TabIndex = 2;
            lblItem.Text = "Items seleccionados: ";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(52, 356);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(155, 20);
            lblIndex.TabIndex = 3;
            lblIndex.Text = "Indexs seleccionados: ";
            lblIndex.Click += lblIndex_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 36);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 4;
            label2.Text = "Nuevo elemento";
            // 
            // txtNuevoElemento
            // 
            txtNuevoElemento.Location = new Point(410, 67);
            txtNuevoElemento.Name = "txtNuevoElemento";
            txtNuevoElemento.Size = new Size(264, 27);
            txtNuevoElemento.TabIndex = 5;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(410, 122);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(219, 34);
            btnInsertar.TabIndex = 6;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(412, 177);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(217, 32);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(412, 228);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(217, 36);
            btnBorrarTodo.TabIndex = 8;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(410, 283);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(219, 31);
            btnSeleccionados.TabIndex = 9;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form12ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeleccionados);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtNuevoElemento);
            Controls.Add(label2);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Name = "Form12ColeccionMultiple";
            Text = "Form12ColeccionMultiple";
            Load += Form12ColeccionMultiple_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstElementos;
        private Label lblItem;
        private Label lblIndex;
        private Label label2;
        private TextBox txtNuevoElemento;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Button btnSeleccionados;
    }
}