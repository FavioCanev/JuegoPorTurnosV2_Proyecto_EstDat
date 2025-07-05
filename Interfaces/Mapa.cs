using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estructuras;
using Grafo;
using Jugabilidad;

namespace Interfaces
{
    public partial class Mapa : Form
    {
        private ListaZonas grafoZonas;
        private NodoZona zonaActual;
        public Mapa(ListaZonas grafo, Bitmap img)
        {
            InitializeComponent();
            grafoZonas = grafo;
            zonaActual = grafoZonas.inicioLista;
            pj.Image = img;
        }

        private void btnZonaForSen_Click(object sender, EventArgs e)
        {

        }
    }
}

        
