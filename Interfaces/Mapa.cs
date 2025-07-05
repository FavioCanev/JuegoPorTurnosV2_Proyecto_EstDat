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
        public ListaZonas listaZonas = new ListaZonas(7);
        public Mapa(Bitmap img)
        {
            InitializeComponent();
            pj.Image = img;
            listaZonas.asignarZonasBossesObjetos();
            mostrarLabelsDeZona();
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

        private void mostrarLabelsDeZona()
        {
            lblSantEnl.Text = listaZonas.obtenerZonaPorIndice(0).nombrZona;
            lblForSen.Text = listaZonas.obtenerZonaPorIndice(1).nombrZona;
            lblAnorLon.Text = listaZonas.obtenerZonaPorIndice(2).nombrZona;
            lblFarumAz.Text = listaZonas.obtenerZonaPorIndice(3).nombrZona;
            lblArbMiq.Text = listaZonas.obtenerZonaPorIndice(4).nombrZona;
            lblAbis.Text = listaZonas.obtenerZonaPorIndice(5).nombrZona;
            lblHorno.Text = listaZonas.obtenerZonaPorIndice(6).nombrZona;
        }

        private void Mapa_Load(object sender, EventArgs e)
        {

        }
    }
}

        
