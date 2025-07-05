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
using Grafo;
using Jugabilidad;

namespace Interfaces
{
    public partial class Mapa : Form
    {
        private NodoZona zonaActual;
        public Mapa(Bitmap img)
        {
            InitializeComponent();
            pj.Image = img;
        }

        private void btnZonaForSen_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            Inicio inicio = new Inicio();
            SeleccionPersonaje seleccionPersonaje = new SeleccionPersonaje(inicio);
            seleccionPersonaje.Show();
        }
    }
}

        
