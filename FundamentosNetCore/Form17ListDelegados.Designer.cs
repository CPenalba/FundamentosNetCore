namespace FundamentosNetCore
{
    partial class Form17ListDelegados
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
            txtContador = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // txtContador
            // 
            txtContador.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContador.Location = new Point(56, 37);
            txtContador.Name = "txtContador";
            txtContador.Size = new Size(166, 47);
            txtContador.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(59, 108);
            button1.Name = "button1";
            button1.Size = new Size(163, 50);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(270, 108);
            button2.Name = "button2";
            button2.Size = new Size(163, 50);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(485, 108);
            button3.Name = "button3";
            button3.Size = new Size(163, 50);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(485, 204);
            button4.Name = "button4";
            button4.Size = new Size(163, 50);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(270, 204);
            button5.Name = "button5";
            button5.Size = new Size(163, 50);
            button5.TabIndex = 5;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(59, 204);
            button6.Name = "button6";
            button6.Size = new Size(163, 50);
            button6.TabIndex = 6;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form17ListDelegados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtContador);
            Name = "Form17ListDelegados";
            Text = "Form17ListDelegados";
            Load += Form17ListDelegados_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContador;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}