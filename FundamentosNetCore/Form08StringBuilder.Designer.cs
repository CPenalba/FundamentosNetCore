namespace FundamentosNetCore
{
    partial class Form08StringBuilder
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
            txtTexto = new RichTextBox();
            btnInvertirString = new Button();
            btnInvertirStringBuilder = new Button();
            lblTiempo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 45);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 0;
            label1.Text = "Copie el texto para trabajar";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(43, 83);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(713, 223);
            txtTexto.TabIndex = 1;
            txtTexto.Text = "";
            // 
            // btnInvertirString
            // 
            btnInvertirString.BackColor = Color.FromArgb(255, 192, 255);
            btnInvertirString.Location = new Point(43, 374);
            btnInvertirString.Name = "btnInvertirString";
            btnInvertirString.Size = new Size(154, 48);
            btnInvertirString.TabIndex = 2;
            btnInvertirString.Text = "Invertir String";
            btnInvertirString.UseVisualStyleBackColor = false;
            btnInvertirString.Click += btnInvertirString_Click;
            // 
            // btnInvertirStringBuilder
            // 
            btnInvertirStringBuilder.BackColor = Color.FromArgb(192, 255, 255);
            btnInvertirStringBuilder.Location = new Point(598, 374);
            btnInvertirStringBuilder.Name = "btnInvertirStringBuilder";
            btnInvertirStringBuilder.Size = new Size(158, 48);
            btnInvertirStringBuilder.TabIndex = 3;
            btnInvertirStringBuilder.Text = "Invertir StringBuilder";
            btnInvertirStringBuilder.TextAlign = ContentAlignment.MiddleRight;
            btnInvertirStringBuilder.UseVisualStyleBackColor = false;
            btnInvertirStringBuilder.Click += btnInvertirStringBuilder_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(41, 335);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(77, 20);
            lblTiempo.TabIndex = 4;
            lblTiempo.Text = "lblTiempo";
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTiempo);
            Controls.Add(btnInvertirStringBuilder);
            Controls.Add(btnInvertirString);
            Controls.Add(txtTexto);
            Controls.Add(label1);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox txtTexto;
        private Button btnInvertirString;
        private Button btnInvertirStringBuilder;
        private Label lblTiempo;
    }
}