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
    public partial class Form19SumarCheckbox : Form
    {
        int suma;
        List<CheckBox> checkboxes;
        public Form19SumarCheckbox()
        {
            InitializeComponent();
            suma = 0;
            checkboxes = new List<CheckBox>();

            foreach (Control control in this.panel1.Controls)
            {
                if (control is CheckBox checkbox)
                {
                    checkboxes.Add(checkbox);
                    checkbox.CheckedChanged += SumarNumeros;
                }
            }
        }

        void SumarNumeros(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            int numero = int.Parse(chk.Text);
            if (chk.Checked)
            {
                this.suma += numero;
            }
            else
            {
                this.suma -= numero;
            }
            this.lblResultado.Text = this.suma.ToString();
        }
        private void GenerarNumerosAleatorios()
        {
            Random random = new Random();
            suma = 0; 
            lblResultado.Text = suma.ToString();

            foreach (CheckBox chk in this.checkboxes)
            {
                int numRandom = random.Next(1, 99); 
                chk.Text = numRandom.ToString();
                chk.Checked = false; 
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            GenerarNumerosAleatorios();
        }

        private void Form19SumarCheckbox_Load(object sender, EventArgs e)
        {
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
