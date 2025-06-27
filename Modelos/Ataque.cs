using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Ataque
    {
        //atributos con sus getters y setters para buenas prácticas de POO
        public string nombre { get; set; }
        public string dano { get; set; }


        // Constructor de la clase Ataque
        public Ataque(string nombre, string dano)
        {
            this.nombre = nombre;
            this.dano = dano;
        }
    }
}
