using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estructuras;
using Modelos;
using DatosFijos;
using Grafo;
using System.Threading;

namespace Jugabilidad
{
    public class Juego
    {
        private Jugador jugador;
        private ListaZonas listaZonas;
        private PilaHistorial historial;
        private ColaTurnos colaTurnos;

        public void iniciarJuego()
        {
            mostrarPantallaInicio();
            seleccionarPersonaje();
            prepararMapa();
            iniciarExploracion();
        }

        public void mostrarPantallaInicio()
        {
            Console.Clear();
            Console.WriteLine("¡Bienvenido al juego!");
            Console.WriteLine("Presiona cualquier tecla para comenzar...");
            Console.ReadKey();
        }

        public void seleccionarPersonaje()
        {
            ClasesFijas clases = new ClasesFijas();
            Console.Clear();
            Console.WriteLine("Selecciona tu personaje:");
            Console.WriteLine("1. Caballero\n2. Hechicero\n3. Ladrón");
            Console.Write("Elige: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    jugador = clases.crearCaballero();
                    break;
                case 2:
                    jugador = clases.crearHechicero();
                    break;
                case 3:
                    jugador = clases.crearLadron();
                    break;
                default:
                    Console.WriteLine("Opción no válida. Selecciona nuevamente");
                    seleccionarPersonaje();
                    break;
            }
        }

        public void prepararMapa()
        {
            //se inicializan las estructuras de datos necesarias para el juego
            listaZonas = new ListaZonas(7);//grafo
            historial = new PilaHistorial();//pila
            colaTurnos = new ColaTurnos();//cola

            //se cargan los bosses y objetos fijos
            BossesFijos bossesFijos = new BossesFijos();
            Objeto[] objetos = new ObjetosFijos().crearObjetos();
            Boss[] bosses = new Boss[]
            {
                bossesFijos.crearArtorias(),
                bossesFijos.crearMalenia(),
                bossesFijos.crearGael(),
                bossesFijos.crearMaliketh(),
                bossesFijos.crearPlacidusax(),
                bossesFijos.crearGargolas(),
                bossesFijos.crearGwyn()
            };

            Random random = new Random();

            //se crean 7 zonas con bosses y objetos aleatorios
            for (int i = 0; i < 7; i++)
            {
                //elige un boss aleatorio
                int asignarBoss = random.Next(0, bosses.Length);
                Boss boss = bosses[asignarBoss];
                bosses[asignarBoss] = bosses[bosses.Length - 1];
                Array.Resize(ref bosses, bosses.Length - 1);

                //elige un objeto aleatorio
                int asignarObjeto = random.Next(0, objetos.Length);

                Objeto obj = objetos[asignarObjeto];
                objetos[asignarObjeto] = objetos[objetos.Length - 1];
                Array.Resize(ref objetos, objetos.Length - 1);

                //se instancia la zona
                Zona nuevaZona = new Zona($"Zona {i + 1}", boss, obj);//le pasa los párámetros ede objetos y bosses aleatorios creados antes
                NodoZona nodo = new NodoZona();
                nodo.zona = nuevaZona;

                //insertar un nodo/zona a la lista enlazadaa
                if (listaZonas.inicioLista == null)
                {
                    listaZonas.inicioLista = nodo;
                }
                else
                {
                    NodoZona actual = listaZonas.inicioLista;
                    while (actual.siguiente != null)
                    {
                        actual = actual.siguiente;
                    }
                    actual.siguiente = nodo;
                }
            }
            listaZonas.llenarMatriz();
            listaZonas.crearGrafo();
        }

        private void iniciarExploracion()
        {
            listaZonas.mostrarMatriz();
            listaZonas.navegarGrafo(listaZonas.inicioLista);
        }

        private void aplicarObjeto(Objeto objetoObtenido)
        {
            Console.WriteLine($"\nHas obtenido el objeto: {objetoObtenido.nombre}");

            if(objetoObtenido.tipo == "vida")
            {
                jugador.vida = jugador.vida + objetoObtenido.valor;
                Console.WriteLine($"Tu vida ha aumentado en +{objetoObtenido.valor} puntos\nVida actual: {jugador.vida}");
            }
            else if (objetoObtenido.tipo == "dano")
            {
                for (int i = 0; i < jugador.obtenerTamanoAtaques()/*aquí podría también haber usado un getLenght en lugar de crear un método solo para sacar el tamaño, solo que me di cuenta ya tarde xd*/; i++)
                {
                    Ataque ataque = jugador.obtenerAtaquePorIndice(i);
                    ataque.dano = ataque.dano + objetoObtenido.valor;
                    Console.WriteLine($"El ataque {ataque.nombre} ha aumentado su daño en +{objetoObtenido.valor} puntos");
                }
                Console.WriteLine($"Todos tus ataques han aumentado en +{objetoObtenido.valor} puntos de daño.");
            }

            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

        public void mostrarResultadoFinal(bool resultado, Combate combate)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            if (resultado)
            {
                Console.WriteLine("¡FELICITACIONES! Has derrotado a todos los bosses");
                Console.WriteLine("El mundo ha sido salvado por tu valor\n");
            }
            else
            {
                Console.WriteLine("Has sido derrotado...");
                Console.WriteLine("El mundo ha caído en la oscuridad\n");
            }

            Console.ResetColor();

            Console.WriteLine("===== HISTORIAL DE COMBATE =====\n");
            combate.mostrarHistorialDeAtaques();

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
