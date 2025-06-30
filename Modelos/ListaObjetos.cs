using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ListaObjetos
    {
        NodoObjetos inicio = null;
        NodoObjetos fin = null;
        int tamano = 0;

        public void agregar(Objeto objeto)
        {
            NodoObjetos nuevo = new NodoObjetos();
            nuevo.objeto = objeto;
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

        public Objeto obtenerPorIndice(int indice) //método para obtener un objeto por su índice/orden en la lista
        {
            if (indice < 0 || indice >= tamano)
            {
                return null; // o también se podría lanzar una excepción
            }
            NodoObjetos actual = inicio;
            for (int i = 0; i < indice; i++)
            {
                actual = actual.siguiente;
            }
            return actual.objeto;
        }

        public int obtenerTamano()
        {
            return tamano;
        }
        public void mostrar()
        {
            NodoObjetos actual = inicio;
            int i = 1;
            while (actual != null)
            {
                Console.WriteLine(i + ". " + actual.objeto.nombre + " - Descripción: " + actual.objeto.descripcion);
                actual = actual.siguiente;
                i++;
            }
        }
    }
}
