using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estructuras;

namespace Interfaces
{
    internal static class Program
    {
        /// <summary>  
        /// Punto de entrada principal para la aplicación.  
        /// </summary>  
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Se crea una instancia de ListaZonas para pasarla como argumento al constructor de Inicio  
            ListaZonas zonas = new ListaZonas(7);
            Application.Run(new Inicio(zonas));
        }
    }
}
