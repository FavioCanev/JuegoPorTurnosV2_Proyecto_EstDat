using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grafo;
using Modelos;

namespace Interfaces
{
    public partial class ResumenObjetos : Form
    {
        private Jugador jugador;
        public ResumenObjetos(Jugador jugadorRecibido)
        {
            jugador = jugadorRecibido;
            InitializeComponent();
        }

        public void agregarObjetoATabla()
        {
            for (int i = 0; i < jugador.objetos.obtenerTamano(); i++)
            {
                Console.WriteLine("Tamaño de los objetos" + jugador.objetos.obtenerTamano());
                jugador.objetos.mostrar();
                Console.WriteLine(jugador.objetos.obtenerPorIndice(i).nombre);
                dgvTablaObjetos.Rows.Add(jugador.objetos.obtenerPorIndice(i).dataObjetos());
            }
        }
    }
}
