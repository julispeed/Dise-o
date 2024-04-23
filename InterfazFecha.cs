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
        private int cantidad = 0;
        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            string[] dato = MTFechainicial.Text.Replace(" ", "").Split('/');            
            if (dato[0] == "" && dato[1] == "" && dato[2] == "")
            {
                MessageBox.Show("Parametros invalidos, Ingresa automaticamente la fecha predeterminada");
                InsertarOrdenado(new Fecha());
                listarfechas();
                return;
            }
            else if (dato[0] == "" || dato[1] == "" || dato[2] == "")
            {
                MessageBox.Show("Parametros invalidos, no se agrega la fecha");
                return;
            }
            InsertarOrdenado(new Fecha(int.Parse(dato[0]), int.Parse(dato[1]), int.Parse(dato[2]))); 
            listarfechas();            
        }
        public void InsertarOrdenado(Fecha f)
        {
            if (cantidad == 0)
            {
                ListaFechas[cantidad] = f;
            }
            else
            {
                for (int i = cantidad-1; i >= 0; i--)
                {
                    if (ListaFechas[i].A > f.A)
                    {
                        ListaFechas[i + 1] = ListaFechas[i];
                        ListaFechas[i] = f;
                    }
                    else if (ListaFechas[i].A == f.A)
                    {
                        if (ListaFechas[i].M > f.M)
                        {
                            ListaFechas[i + 1] = ListaFechas[i];
                            ListaFechas[i] = f;
                        }
                        else if (ListaFechas[i].D > f.D)
                        {
                            ListaFechas[i + 1] = ListaFechas[i];
                            ListaFechas[i] = f;
                        }
                        else
                        {
                            ListaFechas[i + 1] = f;
                            break;
                        }
                    }
                    else
                    {
                        ListaFechas[i + 1] = f;
                        break;
                    }
                }
            }
            cantidad++;
        }
        public void listarfechas()
        {
            LBFechas.Items.Clear();
            foreach (var fec in ListaFechas)
            {
                if (fec!=null)
                {
                    LBFechas.Items.Add(" Dia :" + fec.D + " mes: " + fec.M + " año: " + fec.A);
                }
            }
        }

    }
}
