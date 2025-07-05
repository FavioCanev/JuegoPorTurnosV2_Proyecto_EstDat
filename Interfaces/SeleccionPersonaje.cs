using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DatosFijos;
using Estructuras;
using Modelos;

namespace Interfaces
{
    public partial class SeleccionPersonaje : Form
    {
        ListaJugador lj = new ListaJugador();

        public SeleccionPersonaje(Form anterior) //guardamos la referencia al formulario anterior
        {

            lj.asignarPersonaje(); // Asignamos los personajes a la lista  

            InitializeComponent();

            int t = lj.obtenerTamanoJugadores();
            for (int i = 0; i < t; i++)
            {
                Jugador j = lj.obtenerJugadorPorIndice(i);
                CB_CuadroDesplegablePersonajes.Items.Add(j.nombre); // Añadimos los nombres de los personajes al ComboBox  
            }
        }

        private void CB_CuadroDesplegablePersonajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string personajeSeleccionado = CB_CuadroDesplegablePersonajes.SelectedItem.ToString();

            // Buscar el jugador por nombre  
            Jugador jugadorSeleccionado = lj.buscarPersonajePorNombre(personajeSeleccionado);

            if (jugadorSeleccionado != null)
            {
                DG_TablaAtaques.Rows.Clear();
                for (int i = 0; i < jugadorSeleccionado.obtenerTamanoAtaques(); i++)
                {
                    DG_TablaAtaques.Rows.Add(jugadorSeleccionado.obtenerAtaquePorIndice(i).dataAtaques());
                }

                // Cambia la imagen según el nombre  
                if (jugadorSeleccionado.nombre == "Orstein asesino de dragones")
                {
                    PB_Personaje.Image = Interfaces.Properties.Resources.Orstein_removebg_preview;
                }
                else if (jugadorSeleccionado.nombre == "Patches")
                {
                    PB_Personaje.Image = Interfaces.Properties.Resources.Patches_removebg_preview;
                }
                else if (jugadorSeleccionado.nombre == "Ranni la bruja")
                {
                    PB_Personaje.Image = Interfaces.Properties.Resources.Ranni_removebg_preview;
                }

                LB_ClaseMostrar.Text = jugadorSeleccionado.clase;
                LB_PuntosVidaMostrar.Text = jugadorSeleccionado.vida.ToString();
            }
        }

        private void BT_Atras_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show(); // Muestra el formulario anterior  
            this.Close(); // Cierra el formulario actual  
        }

        private void BT_Confirmar_Click(object sender, EventArgs e)
        {

            //Aunque el catch evita que la aplicación se cierre abruptamente, es mejor prevenir la excepción comprobando explícitamente si hay un elemento seleccionado antes de intentar acceder a él
            if (CB_CuadroDesplegablePersonajes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un personaje antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string personajeSeleccionado = CB_CuadroDesplegablePersonajes.SelectedItem.ToString();//guarda el personaje seleccionado en un string

            // Buscar el jugador por nombre  
            Jugador jugadorSeleccionado = lj.buscarPersonajePorNombre(personajeSeleccionado);

            Bitmap img = null;//un bitmap es una imagen que se puede manipular en C#

            // Cambia la imagen según el nombre  
            if (jugadorSeleccionado.nombre == "Orstein asesino de dragones")
            {
                img = Interfaces.Properties.Resources.Orstein_removebg_preview;
            }
            else if (jugadorSeleccionado.nombre == "Patches")
            {
                img= Interfaces.Properties.Resources.Patches_removebg_preview;
            }
            else if (jugadorSeleccionado.nombre == "Ranni la bruja")
            {
                img = Interfaces.Properties.Resources.Ranni_removebg_preview;
            }
            Mapa mapa = new Mapa(img); // Usamos la instancia de ListaZonas y le pasamos la imagen del personaje seleccionado como parámetro al constructor del mapa
            this.Hide(); // Oculta el formulario de selección de personaje
            mapa.Show(); // Muestra el mapa  }
        }
    }
}
