using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace DatosFijos
{
    public class ListaJugador
    {
        NodoJugador inicio = null;
        NodoJugador fin = null;
        int tamano = 0;

        public void agregarJugador(Jugador jugador)
        {
            NodoJugador nuevo = new NodoJugador();
            nuevo.jugador = jugador;

            if (inicio == null)
            {
                inicio = nuevo;
                fin = nuevo; //se podría ahorrar una línea, pero es más claro así
            }
            else
            {
                fin.siguiente = nuevo;
                nuevo.anterior = fin;
                fin = nuevo; //esta es la que se ahorraría
            }
            tamano++;
        }

        public Jugador obtenerJugadorPorIndice(int indice) //método para obtener un ataque por su índice/orden en la lista
        {
            if (indice < 0 || indice >= tamano)
            {
                return null; // o también se podría lanzar una excepción
            }
            NodoJugador actual = inicio;
            for (int i = 0; i < indice; i++)
            {
                actual = actual.siguiente;
            }
            return actual.jugador;
        }

        public int obtenerTamanoJugadores()
        {
            return tamano;
        }
        public void asignarPersonaje()
        {
            agregarJugador(new ClasesFijas().crearCaballero());
            agregarJugador(new ClasesFijas().crearHechicero());
            agregarJugador(new ClasesFijas().crearLadron());
        }
    }
}
