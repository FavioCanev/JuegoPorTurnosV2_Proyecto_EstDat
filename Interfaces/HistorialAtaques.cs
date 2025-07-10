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
    public partial class HistorialAtaques : Form
    {
        private PilaHistorial pila;
        public HistorialAtaques(PilaHistorial pilaRecibida)
        {
            InitializeComponent();//Nota mental: este método siempre se tiene que llamar al inicio de un constructor de un formulario, porque si no, no se inicializan los componentes del formulario y da error al intentar acceder a ellos
            pila = pilaRecibida;
            insertarAHistorial();
        }
        public void insertarAHistorial()
        {
            while (!pila.estaVacia())
            {
                Ataque ataque = pila.desapilar();
                dgvHistorialAtaques.Rows.Add(ataque.dataAtaques());
            }
        }
    }
}
