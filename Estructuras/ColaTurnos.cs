using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Estructuras
{
    public class ColaTurnos
    {
        NodoCola frente = null;
        NodoCola final = null;

        public void encolar(Criatura criatura)
        {
            NodoCola nuevo = new NodoCola();
            nuevo.elemento = criatura;

            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }

            else
            {
                final.siguiente = nuevo;
                final = nuevo;
            }
        }

        public Criatura desencolar()
        {
            if (frente == null)
            {
                return null; // o también se podría lanzar una excepción
            }
            Criatura criaturaDesencolada = frente.elemento; //crea un espacio/objeto donde guardar a la primera criatura de la cola
            frente = frente.siguiente; //avanza a la siguiente criatura en la cola
            if (frente == null)
            {
                final = null; // Si la cola queda vacía, actualizamos el final también
            }
            return criaturaDesencolada;
        }

        public bool estaVacia()
        {
            return frente == null; // Si el frente es null, la cola está vacía
        }

        public void reiniciar() // Reinicia la cola vaciándola
        {
            frente = null; 
            final = null; 
        }

        public Criatura obtenerTurnoActual()
        {
            //aquí también utilizamos un operador ternario para devolver la criatura en el frente de la cola, o null si está vacía
            return frente != null ? frente.elemento : null;
        }

        public void avanzarTurno()
        {
            if (frente == null)
            {
                return; // Si la cola está vacía, no hacemos nada
            }

            Criatura actual = desencolar(); // Desencolamos al actual
            if (actual.estaVivo()) // Verificamos si el actual está vivo
            {
                encolar(actual); // Si está vivo, lo volvemos a encolar al final
            }
            else
            {
                // Si no está vivo, simplemente no lo reencolamos y se pierde su turno
            }
        }
    }
}
