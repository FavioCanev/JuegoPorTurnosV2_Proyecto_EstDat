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
            artorias.ataques.agregar(new Ataque("Corte corrupto", 20));
            artorias.ataques.agregar(new Ataque("Carga", 0));// +50% de daño en el siguiente ataque
            artorias.ataques.agregar(new Ataque("Explosión oscura", 25));
            artorias.ataques.agregar(new Ataque("Grito del abismo", 10));
            return artorias;
        }

        public Boss crearMalenia()
        {
            Boss malenia = new Boss("Malenia, espada de Miquella", 220);
            malenia.ataques.agregar(new Ataque("Danza de las anátidas", 25));
            malenia.ataques.agregar(new Ataque("Flor carmesí", 20));
            malenia.ataques.agregar(new Ataque("Espina sangrienta", 15));
            malenia.ataques.agregar(new Ataque("Regeneración putrefacta", 17)); // se cura una parte del daño infligido
            return malenia;
        }

        public Boss crearGael()
        {
            Boss gael = new Boss("Gael, caballero esclavo", 180);
            gael.ataques.agregar(new Ataque("Espada sangrienta", 10));
            gael.ataques.agregar(new Ataque("Relámpago oscuro", 12));
            gael.ataques.agregar(new Ataque("Ataques rápidos", 15));
            gael.ataques.agregar(new Ataque("Explosión de almas", 30));
            return gael;
        }

        public Boss crearMaliketh()
        {
            Boss maliketh = new Boss("Maliketh, la Espada Negra", 230);
            maliketh.ataques.agregar(new Ataque("Hoja negra", 15));
            maliketh.ataques.agregar(new Ataque("Corte giratorio", 12));
            maliketh.ataques.agregar(new Ataque("Explosión de la llama negra", 20));
            maliketh.ataques.agregar(new Ataque("Muerte escrita", 30));
            return maliketh;
        }

        public Boss crearPlacidusax()
        {
            Boss placidusax = new Boss("Placidusax, dragón del tiempo", 200);
            placidusax.ataques.agregar(new Ataque("Aliento de fuego", 15));
            placidusax.ataques.agregar(new Ataque("Golpe de garra", 12));
            placidusax.ataques.agregar(new Ataque("Tormenta estacionaria", 10)); // esquiva el siguiente ataque
            placidusax.ataques.agregar(new Ataque("Rayo de Placidusax", 20));
            return placidusax;
        }

        public Boss crearGargolas()
        {
            Boss gargolas = new Boss("Gárgolas del Campanario", 180);
            gargolas.ataques.agregar(new Ataque("Hachazo doble", 20));
            gargolas.ataques.agregar(new Ataque("Aliento ígneo", 17));
            gargolas.ataques.agregar(new Ataque("Ala cortante", 15));
            gargolas.ataques.agregar(new Ataque("Rugido petrificante", 0)); // puede reducir daño recibido o aumentar defensa
            return gargolas;
        }

        public Boss crearGwyn()
        {
            Boss boss = new Boss("Gwyn, señor de la ceniza", 220);
            boss.ataques.agregar(new Ataque("Espada en llamas", 20));
            boss.ataques.agregar(new Ataque("Estallido solar", 15));
            boss.ataques.agregar(new Ataque("Corte divino", 12));
            boss.ataques.agregar(new Ataque("Estocada", 17));
            return boss;
        }
    }
}
