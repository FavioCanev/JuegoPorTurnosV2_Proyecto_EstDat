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
        public ListaAtaques ataques;

        //para verificar si la criatura está viva(solo es de lectura, no modificable)

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
    }
}
