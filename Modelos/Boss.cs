using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Boss : Criatura
    {
        public Boss(string nombre, int vida) : base(nombre, vida)
        {
            // el constructor de Boss hereda de Criatura y no necesita inicializar nada más, porque Criatura ya inicializa todoss los atributos comunes
        }
    }
}
