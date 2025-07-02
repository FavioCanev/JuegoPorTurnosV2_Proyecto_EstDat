using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Estructuras
{
    public class PilaHistorial
    {
        NodoPila cima = null;

        public void apilar(Ataque ataque)
        {
            NodoPila nuevo = new NodoPila();
            nuevo.Ataque = ataque;
            nuevo.siguiente = cima; // El nuevo nodo apunta al nodo que estaba en la cima
            cima = nuevo; // Actualizamos la cima para que sea el nuevo nodo
        }

        public Ataque desapilar()
        {
            if (cima == null)
            {
                return null; // o también se podría lanzar una excepción
            }
            Ataque ataqueRealizado = cima.Ataque; //guardamos el contenido de la cima en una variable
            cima = cima.siguiente; //pasa al siguiente
            return ataqueRealizado; //devuelve el mensaje del nodo que estaba en la cima
        }
        
        public bool estaVacia() //si la cima es null, la pila está vacía
        {
            if (cima == null)
            {
                return true; // La pila está vacía
            }
            return false; // La pila no está vacía
        }

        public void mostrarDesdeElUltimo()
        {
            NodoPila actual = cima;
            while (actual != null)
            {
                Console.WriteLine(actual.Ataque);
                actual = actual.siguiente;
            }
        }
    }
}
