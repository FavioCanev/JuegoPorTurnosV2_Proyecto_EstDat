//esta clase debería estar dentro de la biblioteca de Estructuras, pero como tuve errores al referenciar bidireccionalmente entre Modelos y Estructuras, mejor moví esta clase aquí a Modelos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Modelos
{
    public class NodoAtaque
    {
        public Ataque ataque;
        public NodoAtaque siguiente = null;
        public NodoAtaque anterior = null;
    }
}
