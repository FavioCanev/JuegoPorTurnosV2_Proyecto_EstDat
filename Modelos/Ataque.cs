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
        public string nombre;
        public int dano;


        // Constructor de la clase Ataque
        public Ataque(string nombre, int dano)
        {
            this.nombre = nombre;
            this.dano = dano;
        }

        public string[] dataAtaques()
        {
            string[] dt=new string[2];
            dt[0] = nombre;
            dt[1] = dano.ToString();

            return dt;
        }
    }
}
