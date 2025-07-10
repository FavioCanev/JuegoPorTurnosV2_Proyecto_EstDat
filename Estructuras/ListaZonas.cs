using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grafo;
using DatosFijos;
using Modelos;

namespace Estructuras
{
    public class ListaZonas
    {
        public NodoZona inicioLista = null;
        public int[,] ma;
        private int tamano = 0; //para saber cuántas zonas hay en la lista
        
        

        public ListaZonas(int n) //constructor
        {
            ma = new int [n, n];
            //listaBosses.asignarBosses(); //mete los bosses a la lista
            //objetosFijos.crearObjetos(); //mete los objetos a un Array
        }
        //métodos para la lista enlazada
        
        public void registrarVerticeZona(Zona zona) //este método es para que no se ingresen más zonas de las que permite la matriz de adyacencia
        {
            insertarZonaALista(zona);
            tamano++;
        }

        private void insertarZonaALista(Zona zona)
        {
            NodoZona nuevaZona = new NodoZona();
            nuevaZona.zona = zona;

            if (inicioLista == null) //si la lista está vacía
            {
                inicioLista = nuevaZona; //asignamos el nuevo nodo como inicio
            }
            else //si ya hay nodos en la lista
            {
                NodoZona temp = inicioLista; //creamos un nodo temporal para recorrer la lista
                while (temp.siguiente != null) //recorremos hasta el final de la lista
                {
                    temp = temp.siguiente;
                }
                temp.siguiente = nuevaZona; //insertamos el nuevo nodo al final de la lista
            }
        }

        public Zona obtenerZonaPorIndice(int indice)
        {
            if (indice < 0 || indice >= tamano)
            {
                return null; // o también se podría lanzar una excepción
            }
            NodoZona actual = inicioLista;
            for (int i = 0; i < indice; i++)
            {
                actual = actual.siguiente;
            }
            return actual.zona;
        }

        //métodos para la matriz
        private void llenarMatriz()
        {
            //matríz por defecto para conectar el mapa
            ma = new int[,]
            {
                {0,1,1,0,0,0,0 },
                {0,0,1,1,0,0,0 },
                {0,1,0,1,0,0,0 },
                {0,0,0,0,1,1,0 },
                {0,0,0,0,0,1,1 },
                {0,0,0,0,1,0,1 },
                {0,0,0,0,0,0,0 }
            };
        }

        public void mostrarMatriz()
        {
            NodoZona actual = inicioLista;
            Console.WriteLine("\t");
            Console.ForegroundColor = ConsoleColor.Red;
            while (actual != null)
            {
                Console.Write(actual.zona.nombrZona + "\t");
                actual = actual.siguiente;
            }
            Console.WriteLine();
            Console.ResetColor();

            actual = inicioLista;
            for (int i = 0; i < ma.GetLength(0); i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(actual.zona.nombrZona + "\t");
                Console.ResetColor();
                for (int j = 0; j < ma.GetLength(1); j++)
                {
                    Console.WriteLine(ma[i, j] + "\t");
                }
                Console.WriteLine();
                actual = actual.siguiente;
            }
        }

        //métodos de grafos

        public void crearGrafo()
        {
            NodoZona tempOrigen /*muestra las filas*/ = inicioLista;
            for (int i = 0; i < ma.GetLength(0); i++)
            {
                NodoZona tempDestino /*muestra las columnas*/ = inicioLista;
                for(int j = 0; j < ma.GetLength(1); j++)
                {
                    if (ma[i, j] == 1) //si hay una conexión
                    {
                        if (tempOrigen.arista1 == null)
                        {
                            tempOrigen.arista1 = tempDestino; //asignamos la arista
                        }
                        else if (tempOrigen.arista2 == null)
                        {
                            tempOrigen.arista2 = tempDestino; //asignamos la arista
                        }
                        else if (tempOrigen.arista3 == null)
                        {
                            tempOrigen.arista3 = tempDestino; //asignamos la arista
                        }
                        else if (tempOrigen.arista4 == null)
                        {
                            tempOrigen.arista4 = tempDestino; //asignamos la arista
                        }
                        else if (tempOrigen.arista5 == null)
                        {
                            tempOrigen.arista5 = tempDestino; //asignamos la arista
                        }
                        else if (tempOrigen.arista6 == null)
                        {
                            tempOrigen.arista6 = tempDestino; //asignamos la arista
                        }
                        else if (tempOrigen.arista7 == null)
                        {
                            tempOrigen.arista7 = tempDestino; //asignamos la arista
                        }
                    }
                    tempDestino = tempDestino.siguiente; //avanzamos al siguiente destino
                }
                tempOrigen = tempOrigen.siguiente; //avanzamos al siguiente origen
            }
        }
        //te devuelva los vertices adyacentes
        public void navegarGrafo(NodoZona actual)
        {
            Console.WriteLine("Recorriendo el mapa: ");
            Console.WriteLine("Zona: " + actual.zona.nombrZona);
                if (actual.arista1 != null)
                {
                    Console.WriteLine("[1]Conectada a: " + actual.arista1.zona.nombrZona);
                }
                if (actual.arista2 != null)
                {
                    Console.WriteLine("[2]Conectada a: " + actual.arista2.zona.nombrZona);
                }
                if (actual.arista3 != null)
                {
                    Console.WriteLine("[3]Conectada a: " + actual.arista3.zona.nombrZona);
                }
                if (actual.arista4 != null)
                {
                    Console.WriteLine("[4]Conectada a: " + actual.arista4.zona.nombrZona);
                }
                if (actual.arista5 != null)
                {
                    Console.WriteLine("[5]Conectada a: " + actual.arista5.zona.nombrZona);
                }
                if (actual.arista6 != null)
                {
                Console.WriteLine("[6]Conectada a: " + actual.arista6.zona.nombrZona);
                }
                if (actual.arista7 != null)
                {
                    Console.WriteLine("[7]Conectada a: " + actual.arista7.zona.nombrZona);
                }
                Console.WriteLine("-------------------------\n0. Volver a la zona inicial");
                Console.WriteLine("Seleccione una opción para continuar: ");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        if (actual.arista1 != null)
                        {
                            Console.Clear();
                            mostrarMatriz();
                            navegarGrafo(actual.arista1);
                        }
                        else
                        {
                            Console.WriteLine("No hay conexión en esa dirección.");
                        }
                        break;
                case 2:
                    if (actual.arista2 != null)
                    {
                        Console.Clear();
                        mostrarMatriz();
                        navegarGrafo(actual.arista2);
                    }
                    else
                    {
                        Console.WriteLine("No hay conexión en esa dirección.");
                    }
                    break;
                case 3:
                    if (actual.arista3 != null)
                    {
                        Console.Clear();
                        mostrarMatriz();
                        navegarGrafo(actual.arista3);
                    }
                    else
                    {
                        Console.WriteLine("No hay conexión en esa dirección.");
                    }
                    break;
                case 4:
                    if (actual.arista4 != null)
                    {
                        Console.Clear();
                        mostrarMatriz();
                        navegarGrafo(actual.arista4);
                    }
                    else
                    {
                        Console.WriteLine("No hay conexión en esa dirección.");
                    }
                    break;
                case 5:
                    if (actual.arista5 != null)
                    {
                        Console.Clear();
                        mostrarMatriz();
                        navegarGrafo(actual.arista5);
                    }
                    else
                    {
                        Console.WriteLine("No hay conexión en esa dirección.");
                    }
                    break;
                case 6:
                    if (actual.arista6 != null)
                    {
                        Console.Clear();
                        mostrarMatriz();
                        navegarGrafo(actual.arista6);
                    }
                    else
                    {
                        Console.WriteLine("No hay conexión en esa dirección.");
                    }
                    break;
                case 7:
                    if (actual.arista7 != null)
                    {
                        Console.Clear();
                        mostrarMatriz();
                        navegarGrafo(actual.arista7);
                    }
                    else
                    {
                        Console.WriteLine("No hay conexión en esa dirección.");
                    }
                    break;
                case 0:
                    Console.Clear();
                    mostrarMatriz();
                    Console.WriteLine("Volviendo a la zona inicial...");
                    navegarGrafo(inicioLista);
                    break;
                default: Console.WriteLine("Opción no válida"); break;
            }
            Console.ReadKey();
        }


        private int[] validarNumeroRepetidos()
        {
            Random random = new Random();
            int[] numeros = new int[ma.GetLength(0)];
            int cantidad = 0;

            while (cantidad < numeros.Length)
            {
                int numeroNuevo = random.Next(0, ma.GetLength(0));
                bool repetido = false;

                for (int i = 0; i < cantidad; i++) // Solo verifica hasta los ya llenados
                {
                    if (numeros[i] == numeroNuevo)
                    {
                        repetido = true;
                        break;
                    }
                }

                if (!repetido)
                {
                    numeros[cantidad] = numeroNuevo;
                    Console.WriteLine(numeroNuevo);
                    cantidad++;
                }
            }

            return numeros;
        }

        //método para asignar bosses y objetos a las zonas
        public void asignarZonasBossesObjetos()
        {
            ListaBosses listaBosses = new ListaBosses();
            listaBosses.asignarBosses(); //llama al método que asigna los bosses a la lista
            ObjetosFijos objetosFijos = new ObjetosFijos();
            //ListaObjetos listaObjetos = new ListaObjetos();
            ListaObjetos listaObjetos = objetosFijos.crearObjetos(); //llama al método que crea los objetos y los guarda en un array
            int[] numerosRandom = validarNumeroRepetidos(); //llama al método que valida los números repetidos
            //mi hipótesis es que lo que falta es iniciar/instanciar/rellenar la lista de bosses y el array de objetos, ya que están vacías. Lo pienso porque me dice que el número 0/1 está fuera de los índices de la matríz lo que significa que la listaBosses está vacía

            //el problema: no se cómo hacerlo, ya que no tengo acceso a los métodos de las clases de DatosFijos desde aquí. Por lo tanto, creo que lo mejor es crear un método en la clase ListaZonas que se encargue de asignar los bosses y objetos a las zonas, y llamarlo desde el constructor de la clase Mapa

            //segunda hipótesis, se detiene en el índice donde el random ha generado el número 7, el error dice: Fuera de los indices de la matríz, cuando intento bajar el rango con el que se generan los números aleatorios se me congela la ventana en el formulario de selección de personaje

            Zona zona0 = new Zona("Santuario de enlace", listaBosses.obtenerBossPorIndice(numerosRandom[0]), listaObjetos.obtenerPorIndice(0));
            registrarVerticeZona(zona0);
            
            Zona zona1 = new Zona("Fortaleza de Sen", listaBosses.obtenerBossPorIndice(numerosRandom[1]), listaObjetos.obtenerPorIndice(1));
            registrarVerticeZona(zona1);

            Zona zona2 = new Zona("Anor Londo", listaBosses.obtenerBossPorIndice(numerosRandom[2]), listaObjetos.obtenerPorIndice(2));
            registrarVerticeZona(zona2);
           
            Zona zona3 = new Zona("Farum Azula", listaBosses.obtenerBossPorIndice(numerosRandom[3]), listaObjetos.obtenerPorIndice(3));
            registrarVerticeZona(zona3);
            
            Zona zona4 = new Zona("Árbol de Miquella", listaBosses.obtenerBossPorIndice(numerosRandom[4]), listaObjetos.obtenerPorIndice(4));
            registrarVerticeZona(zona4);

            Zona zona5 = new Zona("El Abismo", listaBosses.obtenerBossPorIndice(numerosRandom[5]), listaObjetos.obtenerPorIndice(5));
            registrarVerticeZona(zona5);

            Zona zona6 = new Zona("Horno de la primera llama", listaBosses.obtenerBossPorIndice(numerosRandom[6]), listaObjetos.obtenerPorIndice(6));
            registrarVerticeZona(zona6);

            // se registran las zonas con nombres predeterminados
            
        }

        public void conectarListaAGrafo()
        {
            llenarMatriz();
            asignarZonasBossesObjetos();
            crearGrafo();
        }
    }
}
