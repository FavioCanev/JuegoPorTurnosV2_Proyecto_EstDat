using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace DatosFijos
{
    public class BossesFijos
    {
        public Boss crearArtorias()
        {
            Boss artorias = new Boss("Artorias, caminante del abismo", 240);
            artorias.agregarAtaque(new Ataque("Corte corrupto", 20));
            artorias.agregarAtaque(new Ataque("Carga", 0));// +50% de daño en el siguiente ataque
            artorias.agregarAtaque(new Ataque("Explosión oscura", 25));
            artorias.agregarAtaque(new Ataque("Grito del abismo", 10));
            return artorias;
        }

        public Boss crearMalenia()
        {
            Boss malenia = new Boss("Malenia, espada de Miquella", 220);
            malenia.agregarAtaque(new Ataque("Danza de las anátidas", 25));
            malenia.agregarAtaque(new Ataque("Flor carmesí", 20));
            malenia.agregarAtaque(new Ataque("Espina sangrienta", 15));
            malenia.agregarAtaque(new Ataque("Regeneración putrefacta", 17)); // se cura una parte del daño infligido
            return malenia;
        }

        public Boss crearGael()
        {
            Boss gael = new Boss("Gael, caballero esclavo", 180);
            gael.agregarAtaque(new Ataque("Espada sangrienta", 10));
            gael.agregarAtaque(new Ataque("Relámpago oscuro", 12));
            gael.agregarAtaque(new Ataque("Ataques rápidos", 15));
            gael.agregarAtaque(new Ataque("Explosión de almas", 30));
            return gael;
        }

        public Boss crearMaliketh()
        {
            Boss maliketh = new Boss("Maliketh, la Espada Negra", 230);
            maliketh.agregarAtaque(new Ataque("Hoja negra", 15));
            maliketh.agregarAtaque(new Ataque("Corte giratorio", 12));
            maliketh.agregarAtaque(new Ataque("Explosión de la llama negra", 20));
            maliketh.agregarAtaque(new Ataque("Muerte escrita", 30));
            return maliketh;
        }

        public Boss crearPlacidusax()
        {
            Boss placidusax = new Boss("Placidusax, dragón del tiempo", 200);
            placidusax.agregarAtaque(new Ataque("Aliento de fuego", 15));
            placidusax.agregarAtaque(new Ataque("Golpe de garra", 12));
            placidusax.agregarAtaque(new Ataque("Tormenta estacionaria", 10)); // esquiva el siguiente ataque
            placidusax.agregarAtaque(new Ataque("Rayo de Placidusax", 20));
            return placidusax;
        }

        public Boss crearGargolas()
        {
            Boss gargolas = new Boss("Gárgolas del Campanario", 180);
            gargolas.agregarAtaque(new Ataque("Hachazo doble", 20));
            gargolas.agregarAtaque(new Ataque("Aliento ígneo", 17));
            gargolas.agregarAtaque(new Ataque("Ala cortante", 15));
            gargolas.agregarAtaque(new Ataque("Rugido petrificante", 0)); // puede reducir daño recibido o aumentar defensa
            return gargolas;
        }

        public Boss crearGwyn()
        {
            Boss boss = new Boss("Gwyn, señor de la ceniza", 220);
            boss.agregarAtaque(new Ataque("Espada en llamas", 20));
            boss.agregarAtaque(new Ataque("Estallido solar", 15));
            boss.agregarAtaque(new Ataque("Corte divino", 12));
            boss.agregarAtaque(new Ataque("Estocada", 17));
            return boss;
        }
    }
}
