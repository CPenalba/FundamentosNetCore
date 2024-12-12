using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string isbn = this.txtIsbn.Text;
            if (isbn.Length != 10)
            {
                this.lblResultado.Text = "El ISBN debe tener 10 caracteres";
            }
            bool textIsNumber = true;
            for (int i = 0; i < isbn.Length; i++)
            {
                char caracter = isbn[i];
                if (char.IsDigit(caracter) == false)
                {
                    textIsNumber = false;
                    break;
                }
            }
            if (textIsNumber == false)
            {
                this.lblResultado.Text = "El ISBN debe contener solo números";
            }
            else
            {
                int suma = 0;
                for (int i = 0; i < isbn.Length; i++)
                {
                    char caracter = isbn[i];
                    int numero = int.Parse(caracter.ToString());
                    int multiplicacion = numero * (i + 1);
                    suma += multiplicacion;
                }
                if (suma % 11 == 0)
                {
                    this.lblResultado.Text = "ISBN correcto";
                    this.lblResultado.ForeColor = Color.Blue;
                }
                else
                {
                    this.lblResultado.Text = "El ISBN introducido no es válido";
                    this.lblResultado.ForeColor = Color.Red;
                }
            }
        }
    }
}
