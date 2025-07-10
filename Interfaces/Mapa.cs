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
using Modelos;

namespace Interfaces
{
    public partial class Mapa : Form
    {
        //aquí cambié la declaración de listaZonas a estática para que la randomización ocurra solo una vez
        public static ListaZonas listaZonas = new ListaZonas(7);
        private Bitmap personajeImg;
        private Jugador jugadorActual;
        public Mapa(Bitmap img, Jugador jugador)
        {
            InitializeComponent();
            personajeImg = img;//guardo el bitmap de la imagen del personaje en una variable nueva para poder usarla en todos los botones del mapa
            jugadorActual = jugador;
            pj.Image = img;
            listaZonas.conectarListaAGrafo();
            mostrarLabelsDeZona();
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


            if (jugadorActual.tieneObjetos())
            {
                btnVerObjetos.Visible = true; // Muestra el botón si el jugador tiene objetos
            }
            else
            {
                btnVerObjetos.Visible = false; // Oculta el botón si no tiene objetos
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();

            Inicio/*el primer nombre que le pasamos a una instancia es el nombre de la clase*/ inicio = new Inicio()/*el segundo es el constructor*/;
            SeleccionPersonaje seleccionPersonaje = new SeleccionPersonaje(inicio);
            seleccionPersonaje.Show();
        }

        //private Combate comb = new Combate();
        //todos los botones de las zonas del mapa, al hacer click en uno de ellos, se abre un combate con la zona correspondiente y el jugador actual
        private void btnZonaForSen_Click(object sender, EventArgs e)
        {
            Combate comb = new Combate(personajeImg, listaZonas.obtenerZonaPorIndice(1), jugadorActual);
            this.Close();
            comb.Show();
        }

        private void btnZonaAnor_Click(object sender, EventArgs e)
        {
            Combate comb = new Combate(personajeImg, listaZonas.obtenerZonaPorIndice(2), jugadorActual);
            this.Close();
            comb.Show();
        }

        private void btnZonaFarumAz_Click(object sender, EventArgs e)
        {
            Combate comb = new Combate(personajeImg, listaZonas.obtenerZonaPorIndice(3), jugadorActual);
            this.Close();
            comb.Show();
        }

        private void btnZonaArbMiq_Click(object sender, EventArgs e)
        {
            Combate comb = new Combate(personajeImg, listaZonas.obtenerZonaPorIndice(4), jugadorActual);
            this.Close();
            comb.Show();
        }

        private void btnZonaAbis_Click(object sender, EventArgs e)
        {
            Combate comb = new Combate(personajeImg, listaZonas.obtenerZonaPorIndice(5), jugadorActual);
            this.Close();
            comb.Show();
        }

        private void btnZonaHorno_Click(object sender, EventArgs e)
        {
            Combate comb = new Combate(personajeImg, listaZonas.obtenerZonaPorIndice(6), jugadorActual);
            this.Close();
            comb.Show();
        }

        private void btnVerObjetos_Click(object sender, EventArgs e)
        {
            ResumenObjetos resumenObjetos = new ResumenObjetos(jugadorActual);
            if (!jugadorActual.tieneObjetos())
            {
                MessageBox.Show("No tienes objetos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Si no hay objetos, no se muestra el resumen
            }
            resumenObjetos.agregarObjetoATabla();
            resumenObjetos.ShowDialog(); // Muestra el formulario de resumen de objetos como un diálogo modal
        }
    }
}

        
