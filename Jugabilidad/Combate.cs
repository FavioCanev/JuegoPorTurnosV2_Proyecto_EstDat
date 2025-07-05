using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Estructuras;

namespace Jugabilidad
{
    public class Combate
    {
        private Jugador jugador;
        private Boss boss;
        private ColaTurnos colaTurnos;
        private PilaHistorial historial;
        private Random random;

        public void iniciarCombate()
        {
            colaTurnos.encolar(jugador);
            colaTurnos.encolar(boss);

            while (jugador.estaVivo() && boss.estaVivo())
            {
                Criatura actual = colaTurnos.desencolar();

                if (actual == jugador)
                {
                    turnoJugador();
                }
                else
                {
                    turnoBoss();
                }

                colaTurnos.encolar(actual); // Vuelve a encolar al que acaba de atacar
                Console.WriteLine($"\n{jugador.nombre}: {jugador.vida} PV ||| {boss.nombre}: {boss.vida} PV\n");
                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }

            if (jugador.vida >= 0)
            {
                Console.WriteLine("\nHas vencido al boss!");

                /* Descomentar si en lugar de void se quiere retornar un booleano para indicar el resultado del combate
                return false; // El jugador pierde
                */
            }
            else
            {
                Console.WriteLine("\nHas sido derrotado...");
                /* Descomentar si en lugar de void se quiere retornar un booleano para indicar el resultado del combate
                return true; // El jugador gana
                */
            }
        }

        private void turnoJugador()
        {
            Console.Clear();
            Console.WriteLine("=== TU TURNO ===\n");
            //jugador.listaAtaques.mostrar();
            Console.WriteLine("Selecciona un ataque (1-4): ");
            int opcion = int.Parse(Console.ReadLine());

            Ataque atq = jugador.obtenerAtaquePorIndice(opcion - 1);//-1 porque los índices de la lista comienzan en 0

            boss.vida = boss.vida - atq.dano;
            historial.apilar(atq);// Guarda el ataque en el historial/pila

            Console.WriteLine($"\n{jugador.nombre} usó {atq.nombre}, hizo {atq.dano} de daño.");
        }

        private void turnoBoss()
        {
            Console.Clear();
            Console.WriteLine("=== TURNO DEL BOSS ===\n");
            int rand = random.Next(4);
            Ataque ataque = boss.obtenerAtaquePorIndice(rand);

            jugador.vida = jugador.vida - ataque.dano;
            //historial.apilar(ataque); // Guarda el ataque en el historial/pila. si es que se quiere apilar también los ataques que ha hecho el boss

            Console.WriteLine($"\n{boss.nombre} usó {ataque.nombre}, te hizo {ataque.dano} de daño.");
        }

        public void mostrarHistorialDeAtaques()
        {
            if (historial.estaVacia())
            {
                Console.WriteLine("No hay ataques registrados.");
            }
            else
            {
                int turno = 1;
                while (!historial.estaVacia())
                {
                    Ataque ataque = historial.desapilar();
                    Console.WriteLine($"Turno {turno}: {ataque.nombre} --- Daño: {ataque.dano}");
                    turno++;
                }
            }
        }
    }
}
