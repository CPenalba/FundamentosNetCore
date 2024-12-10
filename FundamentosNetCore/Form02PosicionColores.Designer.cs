namespace FundamentosNetCore
{
    partial class Form02PosicionColores
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
            txtPosicionX = new TextBox();
            txtPosicionY = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            txtAzul = new TextBox();
            btnCambiarColor = new Button();
            btnCambiarPosicion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 44);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Posición X:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 110);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 1;
            label2.Text = "Posición Y:";
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(149, 37);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(110, 27);
            txtPosicionX.TabIndex = 2;
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(149, 103);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(110, 27);
            txtPosicionY.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(380, 44);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 5;
            label3.Text = "Rojo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(380, 103);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 6;
            label4.Text = "Verde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(380, 168);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 7;
            label5.Text = "Azul";
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(453, 41);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(138, 27);
            txtRojo.TabIndex = 8;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(453, 100);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(138, 27);
            txtVerde.TabIndex = 9;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(453, 161);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(138, 27);
            txtAzul.TabIndex = 10;
            // 
            // btnCambiarColor
            // 
            btnCambiarColor.Location = new Point(378, 222);
            btnCambiarColor.Name = "btnCambiarColor";
            btnCambiarColor.Size = new Size(218, 37);
            btnCambiarColor.TabIndex = 11;
            btnCambiarColor.Text = "Cambiar Color";
            btnCambiarColor.UseVisualStyleBackColor = true;
            btnCambiarColor.Click += btmCambiarColor_Click;
            // 
            // btnCambiarPosicion
            // 
            btnCambiarPosicion.Location = new Point(43, 168);
            btnCambiarPosicion.Name = "btnCambiarPosicion";
            btnCambiarPosicion.Size = new Size(216, 42);
            btnCambiarPosicion.TabIndex = 12;
            btnCambiarPosicion.Text = "Cambiar Posicion";
            btnCambiarPosicion.UseVisualStyleBackColor = true;
            btnCambiarPosicion.Click += btnCambiarPosicion_Click;
            // 
            // Form02PosicionColores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCambiarPosicion);
            Controls.Add(btnCambiarColor);
            Controls.Add(txtAzul);
            Controls.Add(txtVerde);
            Controls.Add(txtRojo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPosicionY);
            Controls.Add(txtPosicionX);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form02PosicionColores";
            Text = "Form02PosicionColores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPosicionX;
        private TextBox txtPosicionY;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private TextBox txtAzul;
        private Button btnCambiarColor;
        private Button btnCambiarPosicion;
    }
}