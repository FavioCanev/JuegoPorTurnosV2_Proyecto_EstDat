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
            if (listaZonas.obtenerZonaPorIndice(1).bossZona.estaVivo())
            {
                btnZonaForSen.Enabled = true; // Habilita el botón si la zona está desbloqueada
            }
            else
            {
                btnZonaForSen.Enabled = false; // Deshabilita el botón si la zona no está desbloqueada
                btnZonaForSen.Size = new Size(150, 50); // Cambia el tamaño del botón si el boss está derrotado
                btnZonaForSen.Text = "Boss derrotado"; // Cambia el texto del botón si el boss está derrotado
            }
            lblAnorLon.Text = listaZonas.obtenerZonaPorIndice(2).nombrZona;
            if (listaZonas.obtenerZonaPorIndice(2).bossZona.estaVivo())
            {
                btnZonaAnor.Enabled = true; // Habilita el botón si la zona está desbloqueada
            }
            else
            {
                btnZonaAnor.Enabled = false; // Deshabilita el botón si la zona no está desbloqueada
                btnZonaAnor.Size = new Size(150, 50); // Cambia el tamaño del botón si el boss está derrotado
                btnZonaAnor.Text = "Boss derrotado"; // Cambia el texto del botón si el boss está derrotado
            }
            lblFarumAz.Text = listaZonas.obtenerZonaPorIndice(3).nombrZona;
            if (listaZonas.obtenerZonaPorIndice(3).bossZona.estaVivo())
            {
                btnZonaFarumAz.Enabled = true; // Habilita el botón si la zona está desbloqueada
            }
            else
            {
                btnZonaFarumAz.Enabled = false; // Deshabilita el botón si la zona no está desbloqueada
                btnZonaFarumAz.Size = new Size(150, 50); // Cambia el tamaño del botón si el boss está derrotado
                btnZonaFarumAz.Text = "Boss derrotado"; // Cambia el texto del botón si el boss está derrotado
            }
            lblArbMiq.Text = listaZonas.obtenerZonaPorIndice(4).nombrZona;
            if (listaZonas.obtenerZonaPorIndice(4).bossZona.estaVivo())
            {
                btnZonaArbMiq.Enabled = true; // Habilita el botón si la zona está desbloqueada
            }
            else
            {
                btnZonaArbMiq.Enabled = false; // Deshabilita el botón si la zona no está desbloqueada
                btnZonaArbMiq.Size = new Size(150, 50); // Cambia el tamaño del botón si el boss está derrotado
                btnZonaArbMiq.Text = "Boss derrotado"; // Cambia el texto del botón si el boss está derrotado
            }
            lblAbis.Text = listaZonas.obtenerZonaPorIndice(5).nombrZona;
            if (listaZonas.obtenerZonaPorIndice(5).bossZona.estaVivo())
            {
                btnZonaAbis.Enabled = true; // Habilita el botón si la zona está desbloqueada
            }
            else
            {
                btnZonaAbis.Enabled = false; // Deshabilita el botón si la zona no está desbloqueada
                btnZonaAbis.Size = new Size(150, 50); // Cambia el tamaño del botón si el boss está derrotado
                btnZonaAbis.Text = "Boss derrotado"; // Cambia el texto del botón si el boss está derrotado
            }
            lblHorno.Text = listaZonas.obtenerZonaPorIndice(6).nombrZona;
            if (listaZonas.obtenerZonaPorIndice(6).bossZona.estaVivo())
            {
                btnZonaHorno.Enabled = true; // Habilita el botón si la zona está desbloqueada
            }
            else
            {
                btnZonaHorno.Enabled = false; // Deshabilita el botón si la zona no está desbloqueada
                btnZonaHorno.Size = new Size(150, 50); // Cambia el tamaño del botón si el boss está derrotado
                btnZonaHorno.Text = "Boss derrotado"; // Cambia el texto del botón si el boss está derrotado
            }
            

            //verifica si el jugador tiene objetos y muestra el botón correspondiente
            if (jugadorActual.tieneObjetos())
            {
                btnVerObjetos.Visible = true; //muestra el botón si el jugador tiene objetos
            }
            else
            {
                btnVerObjetos.Visible = false; //oculta el botón si no tiene objetos
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
            Combate comb = new Combate(personajeImg, listaZonas.obtenerZonaPorIndice(1), jugadorActual, listaZonas);
            this.Close();
            comb.Show();
        }

        private void btnZonaAnor_Click(object sender, EventArgs e)
        {
            Combate comb = new Combate(personajeImg, listaZonas.obtenerZonaPorIndice(2), jugadorActual, listaZonas);
            this.Close();
            comb.Show();
        }

        private void btnZonaFarumAz_Click(object sender, EventArgs e)
        {
            Combate comb = new Combate(personajeImg, listaZonas.obtenerZonaPorIndice(3), jugadorActual, listaZonas);
            this.Close();
            comb.Show();
        }

        private void btnZonaArbMiq_Click(object sender, EventArgs e)
        {
            Combate comb = new Combate(personajeImg, listaZonas.obtenerZonaPorIndice(4), jugadorActual, listaZonas);
            this.Close();
            comb.Show();
        }

        private void btnZonaAbis_Click(object sender, EventArgs e)
        {
            Combate comb = new Combate(personajeImg, listaZonas.obtenerZonaPorIndice(5), jugadorActual, listaZonas);
            this.Close();
            comb.Show();
        }

        private void btnZonaHorno_Click(object sender, EventArgs e)
        {
            Combate comb = new Combate(personajeImg, listaZonas.obtenerZonaPorIndice(6), jugadorActual, listaZonas);
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

        public void verificarFinJuego(ListaZonas listaZonas, PilaHistorial pila)
        {
            Zona zonaFinal = listaZonas.obtenerZonaPorIndice(7);
            if (zonaFinal.bossZona.estaVivo() == false)
            {
                // Si el boss de la última zona está derrotado, se muestra el formulario de fin de juego
                FinJuego finJuego = new FinJuego(pila);
                this.Hide(); // Oculta el mapa actual
                finJuego.Show(); // Muestra el formulario de fin de juego
            }
        }
    }
}

        
