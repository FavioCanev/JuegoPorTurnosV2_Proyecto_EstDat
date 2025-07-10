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
            Boss artorias = new Boss("Artorias", 240);
            artorias.agregarAtaque(new Ataque("Corte corrupto", 18));
            artorias.agregarAtaque(new Ataque("Carga", 0));// +50% de daño en el siguiente ataque
            artorias.agregarAtaque(new Ataque("Explosión oscura", 15));
            artorias.agregarAtaque(new Ataque("Grito del abismo", 10));
            return artorias;
        }

        public Boss crearMalenia()
        {
            Boss malenia = new Boss("Malenia", 220);
            malenia.agregarAtaque(new Ataque("Danza de las anátidas", 20));
            malenia.agregarAtaque(new Ataque("Flor carmesí", 17));
            malenia.agregarAtaque(new Ataque("Espina sangrienta", 12));
            malenia.agregarAtaque(new Ataque("Regeneración putrefacta", 5)); // se cura una parte del daño infligido
            return malenia;
        }

        public Boss crearGael()
        {
            Boss gael = new Boss("Gael", 180);
            gael.agregarAtaque(new Ataque("Espada sangrienta", 10));
            gael.agregarAtaque(new Ataque("Relámpago oscuro", 12));
            gael.agregarAtaque(new Ataque("Ataques rápidos", 15));
            gael.agregarAtaque(new Ataque("Explosión de almas", 25));
            return gael;
        }

        public Boss crearMaliketh()
        {
            Boss maliketh = new Boss("Maliketh", 230);
            maliketh.agregarAtaque(new Ataque("Hoja negra", 12));
            maliketh.agregarAtaque(new Ataque("Corte giratorio", 10));
            maliketh.agregarAtaque(new Ataque("Explosión de la llama negra", 15));
            maliketh.agregarAtaque(new Ataque("Muerte escrita", 25));
            return maliketh;
        }

        public Boss crearPlacidusax()
        {
            Boss placidusax = new Boss("Placidusax", 200);
            placidusax.agregarAtaque(new Ataque("Aliento de fuego", 15));
            placidusax.agregarAtaque(new Ataque("Golpe de garra", 12));
            placidusax.agregarAtaque(new Ataque("Tormenta estacionaria", 10)); // esquiva el siguiente ataque
            placidusax.agregarAtaque(new Ataque("Rayo de Placidusax", 20));
            return placidusax;
        }

        public Boss crearGargolas()
        {
            Boss gargolas = new Boss("Gárgolas", 180);
            gargolas.agregarAtaque(new Ataque("Hachazo doble", 20));
            gargolas.agregarAtaque(new Ataque("Aliento ígneo", 17));
            gargolas.agregarAtaque(new Ataque("Ala cortante", 15));
            gargolas.agregarAtaque(new Ataque("Rugido petrificante", 0)); // puede reducir daño recibido
            return gargolas;
        }

        public Boss crearGwyn()
        {
            Boss boss = new Boss("Gwyn", 220);
            boss.agregarAtaque(new Ataque("Espada en llamas", 17));
            boss.agregarAtaque(new Ataque("Estallido solar", 15));
            boss.agregarAtaque(new Ataque("Corte divino", 12));
            boss.agregarAtaque(new Ataque("Estocada", 10));
            return boss;
        }
    }
}
