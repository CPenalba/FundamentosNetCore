namespace FundamentosNetCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //SOLO ESCRIBIMOS AQUI
            this.txtNombre.Location = new Point(20, 10);
            this.txtNombre.Text = "Soy un string";
            this.txtNombre.Width = 220;
            this.txtNombre.TextAlign = HorizontalAlignment.Right;
            this.btnPulsar.BackColor = Color.Gold;

            // NO ES CONVERSION AUTOMATICA
            // int mayor = 88;
            // short peque�o = mayor;

            //ES CONVERSION AUTOMATICA
            // short peque�o = 88;
            // int mayor = peque�o;

            //STRING A PRIMITIVO
            // string textoNumero = "12345";
            // int numero = int.Parse(textoNumero);
            // double otro = double.Parse(textoNumero);

            //CASTING PRIMITIVOS
            // int mayor = 88;
            // short peque�o = (short)mayor;

            //CUAQLUIER OBJETO A STRING
            // int numero = 88;
            // string texto = numero.ToString();
            // texto = btnPulsar.ToString();

        }
    }
}
