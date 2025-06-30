using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace DatosFijos
{
    public class ClasesFijas
    {
        public Jugador crearCaballero()
        {
            Jugador caballero = new Jugador("Orstein asesino de dragones", 120, "Caballero");
            caballero.ataques.agregar(new Ataque("Rompepostura", 15));//el siguiente ataque hace +150% de daño
            caballero.ataques.agregar(new Ataque("Hoja del Caballero Negro", 25));
            caballero.ataques.agregar(new Ataque("Lanza de Orstein", 20));
            caballero.ataques.agregar(new Ataque("Escudo de emblema de hierba", 0)); //-20 de daño en el siguiente ataque recibido
            return caballero;
        }

        public Jugador crearHechicero()
        {
            Jugador hechicero = new Jugador("Ranni la bruja", 100, "Hechicero");
            hechicero.ataques.agregar(new Ataque("Alma de cristal", 30));
            hechicero.ataques.agregar(new Ataque("Fuego del caos", 20));
            hechicero.ataques.agregar(new Ataque("Llama dame fuerza", 0));//el siguiente ataque hace +200% de daño
            hechicero.ataques.agregar(new Ataque("Ilusion de marioneta", 0));//evita todo el daño del siguiente ataque recibido
            return hechicero;
        }

        public Jugador crearLadron()
        {
            Jugador ladron = new Jugador("Patches", 80, "Ladrón");
            ladron.ataques.agregar(new Ataque("Corte fantasma", 20));
            ladron.ataques.agregar(new Ataque("Danza de las Cuchillas Negras", 25));
            ladron.ataques.agregar(new Ataque("Parry", 0));//evita todo el daño del siguiente ataque recibido y el siguiente ataque hace +250% de daño
            ladron.ataques.agregar(new Ataque("Robo", 10)); //le roba un ataque al rival, reemplaza un ataque aleatorio nuestro por el suyo
            return ladron;
        }
    }
}
