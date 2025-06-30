using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Jugador : Criatura
    {
        public string clase { get; set; }
        public ListaObjetos Objetos { get; set; } // lista de objetos que tiene el jugador

        public Jugador(string nombre, int vida, string clase) : base(nombre, vida)
        //el base se utiliza para llamar de nuevo al constructor de Criatura y así no tener que poner de nuevo el this.nombre, this.vida, etc
        //solo reutilizar el constructor de la clase base más el atributo de la clase hija: Jugador
        {
            this.clase = clase;
        }
    }
}
