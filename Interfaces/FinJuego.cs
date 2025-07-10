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
using Modelos;

namespace Interfaces
{
    public partial class FinJuego : Form
    {
        private Combate combate;
        private PilaHistorial pilaHistorial;
        public FinJuego(PilaHistorial pila)
        {
            InitializeComponent();
            pilaHistorial = pila;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPilaAtaques_Click(object sender, EventArgs e)
        {
            HistorialAtaques historial = new HistorialAtaques(pilaHistorial);
            historial.Show();
        }
    }
}
