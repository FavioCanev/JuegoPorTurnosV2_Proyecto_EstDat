using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
{
    public class ListaZonas
    {
        public NodoZona inicioLista = null;
        public int[,] ma;

        public ListaZonas(int n) //constructor
        {
            ma = new int [n, n];
        }

        public void llenarMatriz()
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
    }
}
