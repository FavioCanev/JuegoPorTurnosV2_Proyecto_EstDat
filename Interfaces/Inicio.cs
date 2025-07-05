using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estructuras;


namespace Interfaces
{
    public partial class Inicio : Form
    {
        private ListaZonas listaZonas; // Add this field to store the required parameter  

        public Inicio(ListaZonas zonas) // Modify the constructor to accept ListaZonas  
        {
            InitializeComponent();
            listaZonas = zonas; // Initialize the field  
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void BT_Inicio_Click(object sender, EventArgs e)
        {
            SeleccionPersonaje seleccionPersonaje = new SeleccionPersonaje(this, listaZonas);
            this.Hide(); // Oculta el formulario de inicio  
            seleccionPersonaje.Show();
        }

        private void BT_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
