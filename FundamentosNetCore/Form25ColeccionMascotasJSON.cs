using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using ProyectoClases.Models;

namespace FundamentosNetCore
{
    public partial class Form25ColeccionMascotasJSON : Form
    {
        ColeccionMascotas mascotasList;
        public Form25ColeccionMascotasJSON()
        {
            InitializeComponent();
            this.mascotasList = new ColeccionMascotas();
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.mascotasList)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtAnyos.Text);
            this.mascotasList.Add(mascota);
            this.DibujarMascotas();
            this.txtNombre.Clear();
            this.txtRaza.Clear();
            this.txtAnyos.Clear();
        }

        private async void btnGuardarMascotas_Click(object sender, EventArgs e)
        {
            string fileName = "mascotas.json";
            await using (FileStream createStream = File.Create(fileName))
            {
                await JsonSerializer.SerializeAsync(createStream, this.mascotasList);
            }
            string fileContent = File.ReadAllText(fileName);
            Console.WriteLine(fileContent);
        }

        private void btnLeerMascotas_Click(object sender, EventArgs e)
        {
            string fileName = "mascotas.json";
            using (FileStream openStream = File.OpenRead(fileName))
            {
                this.mascotasList = JsonSerializer.Deserialize<ColeccionMascotas>(openStream);
                this.DibujarMascotas();
            }
           
            //if (File.Exists(fileName))
            //{
            //string jsonContent = File.ReadAllText(fileName);
            //this.mascotasList = JsonSerializer.Deserialize<ColeccionMascotas>(jsonContent);
            //this.DibujarMascotas();
            //}
            //else
            //{
            //MessageBox.Show("El archivo no existe. Por favor, guarde una lista de mascotas primero.", "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstMascotas.SelectedIndex;
            if (index != -1)
            {
                Mascota mascota = this.mascotasList[index];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtAnyos.Text = mascota.Years.ToString();
            }
        }
    }
}
