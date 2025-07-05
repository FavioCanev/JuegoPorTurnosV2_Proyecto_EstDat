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
            Jugador caballero = new Jugador("Orstein asesino de dragones", 140, "Caballero");
            caballero.agregarAtaque(new Ataque("Rompepostura", 15)); //el siguiente ataque hace +150% de daño
            caballero.agregarAtaque(new Ataque("Hoja del Caballero Negro", 25));
            caballero.agregarAtaque(new Ataque("Lanza de Orstein", 20));
            caballero.agregarAtaque(new Ataque("Escudo de emblema de hierba", 0)); //-20 de daño en el siguiente ataque recibido
            return caballero;
        }

        public Jugador crearHechicero()
        {
            Jugador hechicero = new Jugador("Ranni la bruja", 120, "Hechicera");
            hechicero.agregarAtaque(new Ataque("Luna llena de Ranni", 30));
            hechicero.agregarAtaque(new Ataque("Fuego del caos", 20));
            hechicero.agregarAtaque(new Ataque("Llama dame fuerza", 0));//el siguiente ataque hace +200% de daño
            hechicero.agregarAtaque(new Ataque("Ilusion de marioneta", 0));//evita todo el daño del siguiente ataque recibido
            return hechicero;
        }

        public Jugador crearLadron()
        {
            Jugador ladron = new Jugador("Patches", 100, "Ladrón");
            ladron.agregarAtaque(new Ataque("Corte fantasma", 20));
            ladron.agregarAtaque(new Ataque("Danza de las Cuchillas Negras", 25));
            ladron.agregarAtaque(new Ataque("Parry", 0));//evita todo el daño del siguiente ataque recibido y el siguiente ataque hace +250% de daño
            ladron.agregarAtaque(new Ataque("Robo", 10)); //le roba un ataque al rival, reemplaza un ataque aleatorio nuestro por el suyo
            return ladron;
        }
    }
}
