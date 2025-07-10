using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public abstract class Criatura
    {
        public string nombre;
        public int vida;
        public Ataque listaAtaques;

        public Criatura(string nombre, int vida)
        {
            this.nombre = nombre;
            this.vida = vida;
        }
        public bool estaVivo()
        {
            if (vida > 0)
            {
                return true; //si la vida es mayor a 0, la criatura está viva
            }
            return false; //si la vida es 0 o menor, la criatura está viva
        }




        NodoAtaque inicio = null;
        NodoAtaque fin = null;
        int tamano = 0;

        public void agregarAtaque(Ataque ataque)
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

        public Ataque obtenerAtaquePorIndice(int indice) //método para obtener un ataque por su índice/orden en la lista
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

        public int obtenerTamanoAtaques()
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
