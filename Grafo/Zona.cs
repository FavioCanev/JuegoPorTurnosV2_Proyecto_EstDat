using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Grafo
{
    public class Zona
    {
        public string nombrZona;
        public Boss bossZona;
        public Objeto recompensa;

        public Zona(string nombrZona, Boss bossZona, Objeto recompensa)
        {
            this.nombrZona = nombrZona;
            this.bossZona = bossZona;
            this.recompensa = recompensa;
        }
    }
}
