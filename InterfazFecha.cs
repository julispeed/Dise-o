using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFecha
{
    public partial class InterfazFecha : Form
    {
        public InterfazFecha()
        {
            InitializeComponent();
        }

        private Fecha[] ListaFechas = new Fecha[maximo];
        private static int maximo=50;

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {            
        }

        
    }
}
