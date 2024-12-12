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
    public partial class Form10ValidarDni : Form
    {
        public Form10ValidarDni()
        {
            InitializeComponent();
            int[] numeros = new int[] { 1, 4, 6, 7 };
            int sumaArray = 0;
            foreach (int num in numeros)
            {
                sumaArray += num;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = this.txtDNI.Text;
            //RECUPERAMOS LA LETRA DEL DNI
            char letraDni = dni[dni.Length - 1];
            //SI LO PENSAMOS CON LETRA...
            string soloNumeros =
                dni.Substring(0, dni.Length - 1);
            int dniNumber = int.Parse(soloNumeros);
            int resultado =
                (dniNumber - ((dniNumber / 23) * 23));
            string secuenciaLetras = "TRWAGMYFPDXBNJZSQVHLCKET";
            char letraValidacion = secuenciaLetras[resultado];
            if (letraDni == letraValidacion)
            {
                this.lblResultado.Text = "DNI correcto!!!";
            }
            else
            {
                this.lblResultado.Text = "Incorrecto, su letra es "
                    + letraValidacion;
            }
        }
    }
}
