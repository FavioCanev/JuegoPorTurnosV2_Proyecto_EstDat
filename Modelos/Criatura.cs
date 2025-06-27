using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public abstract class Criatura
    {
        public string nombre { get; set; }
        public int vida { get; set; }
        public ListaAtaques ataques { get; set; }

        //para verificar si la criatura está viva(solo es de lectura, no modificable)
        public bool estaVivo => vida > 0;

        public Criatura(string nombre, int vida)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.ataques = new ListaAtaques();
        }
    }
}
