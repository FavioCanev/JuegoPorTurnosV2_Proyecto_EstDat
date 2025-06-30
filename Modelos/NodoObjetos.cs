//esta clase debería estar dentro de la biblioteca de Estructuras, pero como tuve errores al referenciar bidireccionalmente entre Modelos y Estructuras, mejor moví esta clase aquí a Modelos
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class NodoObjetos
    {
        public Objeto objeto;
        public NodoObjetos siguiente = null;
        public NodoObjetos anterior = null;
    }
}
