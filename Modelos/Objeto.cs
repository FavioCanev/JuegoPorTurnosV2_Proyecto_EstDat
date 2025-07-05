using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Objeto
    {
        public string nombre;
        public string tipo; // aumento de vida o de daño
        public int valor;

        public Objeto(string nombre, string tipo, int valor)
        {
            this.nombre = nombre;
            this.tipo = tipo.ToLower(); // para evitar errores al comparar
            this.valor = valor;
        }
    }
}
