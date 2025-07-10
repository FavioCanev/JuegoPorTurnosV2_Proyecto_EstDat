using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using Estructuras;
using Grafo;
using Modelos;

namespace Interfaces
{
    public partial class Combate : Form
    {
        private Zona zonaActual;
        private Jugador jugadorActual;
        private Bitmap bitmapPersonaje;
        private ColaTurnos cola;
        private ResumenObjetos resumenObjetos;
        private ListaObjetos objetosObtenidos;
        private ListaZonas listaZonas;
        public PilaHistorial pila = new PilaHistorial();

        public Combate(Bitmap personaje, Zona zona, Jugador jugador, ListaZonas zonas)
        {
            InitializeComponent();
            zonaActual = zona;
            jugadorActual = jugador;
            bitmapPersonaje = personaje;
            pbPersonajeCombate.Image = personaje;
            listaZonas = zonas;

            objetosObtenidos = jugadorActual.objetos ?? new ListaObjetos();
            jugadorActual.objetos = objetosObtenidos;

            pila = new PilaHistorial();
            cola = new ColaTurnos();
            cola.encolar(jugadorActual); // Encolamos al jugador actual
            cola.encolar(zonaActual.bossZona); // Encolamos al boss de la zona actual

            pgrbrBarraVidaBoss.Maximum = zonaActual.bossZona.vida; // Asignamos el máximo de vida del boss
            pgrbrBarraVidaPersonaje.Maximum = jugadorActual.vida; // Asignamos el máximo de vida del jugador
            pgrbrBarraVidaBoss.Minimum = 0; // Establecemos el mínimo de vida del boss
            pgrbrBarraVidaPersonaje.Minimum = 0; // Establecemos el mínimo de vida del jugador
            mostrarPictureBoxBoss();
            mostrarLabelsDelCombate();
        }

        private void mostrarLabelsDelCombate()
        {
            lblNombreBoss.Text = zonaActual.bossZona.nombre;
            lblNombrePersonaje.Text = jugadorActual.nombre;
            lblNombreZona.Text = zonaActual.nombrZona;

            //para controlar que la vida nunca sea menor que cero utilizamos algo llamado operador ternario, que es una forma abreviada de un if-else:
            int vidaBoss = zonaActual.bossZona.vida < 0 ? 0 : zonaActual.bossZona.vida;
            int vidaJugador = jugadorActual.vida < 0 ? 0 : jugadorActual.vida;


            //en lugar de utilizar operadores ternarios, también se podría utilizar un if-else tradicional, pero el operador ternario es más conciso. Aquí un ejemplo de cómo sería con if-else tradicional:

            /*
            int vidaBoss;
            if (zonaActual.bossZona.vida < 0)
            {
                vidaBoss = 0;
            }
            else
            {
                vidaBoss = zonaActual.bossZona.vida;
            }

            int vidaJugador;
            if (jugadorActual.vida < 0)
            {
                vidaJugador = 0;
            }
            else
            {
                vidaJugador = jugadorActual.vida;
            }
            */


            lblVidaBoss.Text = vidaBoss.ToString();
            lblVidaPersonaje.Text = vidaJugador.ToString();

            // Asignar valor seguro a las barras de vida
            if (vidaBoss >= pgrbrBarraVidaBoss.Minimum && vidaBoss <= pgrbrBarraVidaBoss.Maximum)
            {
                pgrbrBarraVidaBoss.Value = vidaBoss;
            }

            if (vidaJugador >= pgrbrBarraVidaPersonaje.Minimum && vidaJugador <= pgrbrBarraVidaPersonaje.Maximum)
            {
                pgrbrBarraVidaPersonaje.Value = vidaJugador;
            }
        }

        private void mostrarPictureBoxBoss()
        {
            if (zonaActual.bossZona.nombre == "Artorias")
            {
                pbBossCombate.Image = Interfaces.Properties.Resources.Artorias_removebg_preview;
            }
            else if (zonaActual.bossZona.nombre == "Malenia")
            {
                pbBossCombate.Image = Interfaces.Properties.Resources.Malenia_removebg_preview;
            }
            else if (zonaActual.bossZona.nombre == "Gael")
            {
                pbBossCombate.Image = Interfaces.Properties.Resources.Gael_removebg_preview;
            }
            else if (zonaActual.bossZona.nombre == "Maliketh")
            {
                pbBossCombate.Image = Interfaces.Properties.Resources.Maliketh_removebg_preview;
            }
            else if (zonaActual.bossZona.nombre == "Placidusax")
            {
                pbBossCombate.Image = Interfaces.Properties.Resources.Placidusax_removebg_preview;
            }
            else if (zonaActual.bossZona.nombre == "Gárgolas")
            {
                pbBossCombate.Image = Interfaces.Properties.Resources.GargolasCampanario_removebg_preview;
            }
            else if (zonaActual.bossZona.nombre == "Gwyn")
            {
                pbBossCombate.Image = Interfaces.Properties.Resources.Gwyn_removebg_preview;
            }
        }

        private void atacarABoss(int indice)
        {
            Ataque ataqueUsado = jugadorActual.obtenerAtaquePorIndice(indice);
            MessageBox.Show($"Has usado {ataqueUsado.nombre} con un daño de {ataqueUsado.dano}", "Ataque", MessageBoxButtons.OK);
            zonaActual.bossZona.vida = zonaActual.bossZona.vida - ataqueUsado.dano;
            pila.apilar(ataqueUsado); //apilamos el ataque realizado por el Jugador

            mostrarLabelsDelCombate();
        }

        private void atacarAJugador(int indice)
        {
            Ataque ataqueUsado = zonaActual.bossZona.obtenerAtaquePorIndice(indice);
            MessageBox.Show($"{zonaActual.bossZona.nombre} ha usado {ataqueUsado.nombre} con un daño de {ataqueUsado.dano}", "Ataque", MessageBoxButtons.OK);
            jugadorActual.vida = jugadorActual.vida - ataqueUsado.dano;
            pila.apilar(ataqueUsado); //apilamos el ataque realizado por el Jugador
            mostrarLabelsDelCombate();
        }

        private void volverAlMapa()
        {
            this.Close();
            Bitmap bitmapPersonaje = new Bitmap(pbPersonajeCombate.Image);
            Mapa mapa = new Mapa(bitmapPersonaje, jugadorActual);
            mapa.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            volverAlMapa();
        }

        private void btnAtaque1_Click(object sender, EventArgs e)
        {
            ejecutarTurnoJugador(0);
        }

        private void btnAtaque2_Click(object sender, EventArgs e)
        {
            ejecutarTurnoJugador(1);
            
        }

        private void btnAtaque3_Click(object sender, EventArgs e)
        {
            ejecutarTurnoJugador(2);
        }

        private void btnAtaque4_Click(object sender, EventArgs e)
        {
            ejecutarTurnoJugador(3);
        }

        private void ejecutarTurnoJugador(int indiceAtaque)
        {
            // Verifica si es el turno del jugador
            if (cola.obtenerTurnoActual() != jugadorActual)
            {
                MessageBox.Show("¡No es tu turno!");
                return;
            }

            atacarABoss(indiceAtaque);//atacamos al boss con el ataque seleccionado por el jugador

            if (!zonaActual.bossZona.estaVivo())//verificamos si el boss está muerto
            {
                MessageBox.Show("¡Has derrotado al boss de esta zona!");
                jugadorActual.objetos.agregar(zonaActual.recompensa);//agregamos el objeto obtenido al jugador actual
                applicarObjetoaAJugador();//aplicamos los efectos del objeto al jugador

                if (!zonaActual.bossZona.estaVivo() && zonaActual == listaZonas.obtenerZonaPorIndice(6))
                {
                    FinJuego fin = new FinJuego(pila);
                    this.Hide();
                    fin.Show();
                    return;
                }
                volverAlMapa();
                return;
                //aquí falta mostrar la ventana de zona completada con el objeto obtenido al derrotar al boss, y aplicar los efectos del objeto al jugador
            }

            cola.avanzarTurno();

            // Turno del boss
            if (cola.obtenerTurnoActual() == zonaActual.bossZona)
            {
                ejecutarTurnoBoss();
            }
            actualizarBotones();
        }

        //el async void permite que el método se ejecute de forma asíncrona, lo que significa que no bloqueará la interfaz de usuario mientras espera, a diferencia de utilizar un Thread.Sleep(), que hace que se congele toda la interfaz, lo que hace parecer que el programa se hubiera colgado
        private async void ejecutarTurnoBoss()
        {
            await Task.Delay(1000);//hace que espere dos segundos antes de que el boss ataque

            // Elige un ataque aleatorio del boss
            Random rnd = new Random();
            int numAtaques = zonaActual.bossZona.obtenerTamanoAtaques();
            int indiceAtaque = rnd.Next(0, numAtaques);//genera un índice aleatorio para que seleccione un ataque del jefe

            atacarAJugador(indiceAtaque);//y se lo pasa como parámetro al método de ataqueAJugador

            if (!jugadorActual.estaVivo())
            {
                MessageBox.Show("¡Has sido derrotado! Por: " + zonaActual.bossZona.nombre);
                this.Close();
                Inicio inicio = new Inicio();
                inicio.Show();
                return;
            }

            cola.avanzarTurno();
            actualizarBotones();
        }

        private void actualizarBotones()
        {
            bool esTurnoJugador = cola.obtenerTurnoActual() == jugadorActual;//verificamos si el turno en el que se enuentra actualmente la cola es igual a jugadorActual
            // si no lo es, entonces deshabilitamos los botones de atacar según el valor booleano de esTurnoJugador
            btnAtaque1.Enabled = esTurnoJugador;
            btnAtaque2.Enabled = esTurnoJugador;
            btnAtaque3.Enabled = esTurnoJugador;
            btnAtaque4.Enabled = esTurnoJugador;
        }

        private void btnVerObjetos_Click(object sender, EventArgs e)
        {
            
            resumenObjetos = new ResumenObjetos(jugadorActual);
            resumenObjetos.agregarObjetoATabla();
            resumenObjetos.Show();
        }

        private void applicarObjetoaAJugador()
        {
            for (int i = 0; i < jugadorActual.objetos.obtenerTamano(); i++)
            {
                if (jugadorActual.objetos.obtenerPorIndice(i).tipo == "vida")
                {
                    jugadorActual.vida = jugadorActual.vida + jugadorActual.objetos.obtenerPorIndice(i).valor;
                }
                else if (jugadorActual.objetos.obtenerPorIndice(i).tipo == "dano")
                {
                    for ( int j = 0; j < jugadorActual.obtenerTamanoAtaques(); j++)
                    {
                        //aquí se le suma el valor del objeto al daño de cada ataque del jugador
                        jugadorActual.obtenerAtaquePorIndice(j).dano = jugadorActual.obtenerAtaquePorIndice(j).dano + jugadorActual.objetos.obtenerPorIndice(i).valor;
                    }
                }
            }
        }

        //también falta apilar los ataques utilizados por el jugador en cada turno
        //también falta resetearle la vida al jugador al ganar el combate y antes de que entre a otra zona
    }
}
