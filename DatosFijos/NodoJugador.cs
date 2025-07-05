using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace DatosFijos
{
    public class NodoJugador
    {
        public Jugador jugador;
        public NodoJugador siguiente = null;
        public NodoJugador anterior = null;
    }
}
