using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace DatosFijos
{
    public class ListaBosses
    {
        NodoBosses inicio = null;
        NodoBosses fin = null;
        int tamano = 0;

        private void agregarBoss(Boss boss)
        {
            NodoBosses nuevo = new NodoBosses();
            nuevo.boss = boss;
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

        public Boss obtenerBossPorIndice(int indice) //método para obtener un ataque por su índice/orden en la lista
        {
            if (indice < 0 || indice >= tamano)
            {
                return null; // o también se podría lanzar una excepción
            }
            NodoBosses actual = inicio;
            for (int i = 0; i < indice; i++)
            {
                actual = actual.siguiente;
            }
            return actual.boss;
        }

        public int obtenerTamanoBosses()
        {
            return tamano;
        }

        public void asignarBosses()
        {
            agregarBoss(new BossesFijos().crearGwyn());
            agregarBoss(new BossesFijos().crearGargolas());
            agregarBoss(new BossesFijos().crearPlacidusax());
            agregarBoss(new BossesFijos().crearMaliketh());
            agregarBoss(new BossesFijos().crearGael());
            agregarBoss(new BossesFijos().crearMalenia());
            agregarBoss(new BossesFijos().crearArtorias());
        }
    }
}
