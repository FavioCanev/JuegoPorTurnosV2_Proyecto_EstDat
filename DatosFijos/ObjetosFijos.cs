using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace DatosFijos
{
    public class ObjetosFijos
    {
        public ListaObjetos crearObjetos()
        {
            ListaObjetos objetos = new ListaObjetos();
            objetos.agregar(new Objeto("Frasco de Estus", "vida", 30));
            objetos.agregar(new Objeto("Fragmento de alma", "vida", 40));
            objetos.agregar(new Objeto("Lágrima de cristal", "vida", 50));
            objetos.agregar(new Objeto("Bendición divina", "vida", 60));
            objetos.agregar(new Objeto("Garra de bestia", "dano", 10));
            objetos.agregar(new Objeto("Espina de dragón", "dano", 15));
            objetos.agregar(new Objeto("Runa antigua", "dano", 20));

            return objetos;
        }
    }
}
