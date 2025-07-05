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


namespace Interfaces
{
    public partial class Inicio : Form
    {
        //private ListaZonas listaZonas;

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void BT_Inicio_Click(object sender, EventArgs e)
        {
            SeleccionPersonaje seleccionPersonaje = new SeleccionPersonaje(this);
            this.Hide(); // Oculta el formulario de inicio  
            seleccionPersonaje.Show();
        }

        private void BT_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra todas las ventanas y detiene la ejecución del programa
            //no usamos this.Close() porque solo cierra la ventana actual(donde se ejecuta), no cierra el programa por completo
        }
    }
}
