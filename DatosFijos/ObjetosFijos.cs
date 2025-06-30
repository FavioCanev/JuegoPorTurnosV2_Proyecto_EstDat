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
        public Objeto[] obtenerObjetos()
        {
            Objeto[] objetos = new Objeto[7];

            objetos[0] = new Objeto("Frasco de Estus", "vida", 30);
            objetos[1] = new Objeto("Fragmento de alma", "vida", 40);
            objetos[2] = new Objeto("Lágrima de cristal", "vida", 50);
            objetos[3] = new Objeto("Bendición divina", "vida", 60);
            objetos[4] = new Objeto("Garra de bestia", "dano", 10);
            objetos[5] = new Objeto("Espina de dragón", "dano", 15);
            objetos[6] = new Objeto("Runa antigua", "dano", 20);

            return objetos;
        }
    }
}
