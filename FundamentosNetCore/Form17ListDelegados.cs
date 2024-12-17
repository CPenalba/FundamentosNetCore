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
    public partial class Form17ListDelegados : Form
    {
        //DECLARAMOS UNA VARIABLE CONTADOR
        int contador;
        List<Button> botones;
        public Form17ListDelegados()
        {
            InitializeComponent();
            this.contador = 0;
            this.botones = new List<Button>();
            //this.button1.Click += BotonPulsado;
            //SI ALMACENMOS TODOS LOS OBJETOS DENTRI DE LA COLECCION, 
            //PODEMOS HACER LA ACCION DELEGADA CON UN FOREACH
            //this.botones.Add(button1);
            //this.botones.Add(button2);
            // this.botones.Add(button3);
            //this.botones.Add(button4);

            //CON LA COLECCION CONTROLS POEDEMOS RECORRER UN CONJUNTO DE
            //OBJETOS Y RELLENAR DINAMICAMENTE NUESTRAS COLECCIONES PROPIAS
            foreach (Control miControl in this.Controls)
            {
                //DEBEMOS PREGUNTAR POR LOS BUTTON
                if(miControl is Button)
                {
                    this.botones.Add((Button)miControl);
                }
            }

            foreach (Button boton in this.botones)
            {
                boton.Click += BotonPulsado;
            }
        }

        //QUIERO QUE AL PULSAR CUALQUIER BOTON EN ESTE METODO CAMBIE DE 
        //COLOR EL BOTON PULSADO

        void BotonPulsado(object sender, EventArgs e)
        {
            this.contador += 1;
            this.txtContador.Text = this.contador.ToString();
            //sender es el objeto que realiza la llamada
            Button miBoton = (Button)sender;
            miBoton.BackColor = Color.Yellow;
        }

        private void Form17ListDelegados_Load(object sender, EventArgs e)
        {

        }
    }
}
