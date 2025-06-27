//esta clase debería estar dentro de la biblioteca de Estructuras, pero como tuve errores al referenciar bidireccionalmente entre Modelos y Estructuras, mejor moví esta clase aquí a Modelos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ListaAtaques
    {
        NodoAtaque inicio = null;
        NodoAtaque fin = null;
        int tamano = 0;

        public void agregar(Ataque ataque)
        {
            NodoAtaque nuevo = new NodoAtaque();
            nuevo.ataque = ataque;

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

        public Ataque obtenerPorIndice(int indice) //método para obtener un ataque por su índice/orden en la lista
        {
            if (indice < 0 || indice >= tamano)
            {
                return null; // o también se podría lanzar una excepción
            }
            NodoAtaque actual = inicio;
            for (int i = 0; i < indice; i++)
            {
                actual = actual.siguiente;
            }
            return actual.ataque;
        }

        public int obtenerTamano()
        {
            return tamano;
        }

        public void mostrar()
        {
            NodoAtaque actual = inicio;
            int i = 1;
            while (actual != null)
            {
                Console.WriteLine(i + ". " + actual.ataque.nombre + " - Daño: " + actual.ataque.dano);
                actual = actual.siguiente;
                i++;
            }
        }
    }
}
