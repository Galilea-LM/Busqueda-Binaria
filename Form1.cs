using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._6Busqueda_Binaria
{
    public partial class Form1 : Form
    {
        Vector vec;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int tamanoFinal = Convert.ToInt16(txtTamano.Text);
            vec = new Vector(tamanoFinal);
            txtTamano.Clear();
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            int limiteNumerico = Convert.ToInt16(txtLimite.Text);
            vec.Llenar(limiteNumerico);
            txtLimite.Clear();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = vec.ToString();

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            vec.Ordenar();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int numeroBuscar = Convert.ToInt16(txtNumeroABuscar.Text);
            vec.busquedaBinaria(numeroBuscar);
            if(numeroBuscar!= -1)
            {
                txtResultado.Text = "Se econtro " + numeroBuscar.ToString() + Environment.NewLine;
            }
            else
            {
                txtResultado.Text = "no se encontro el numero";
            }

            txtComparaciones.Text += "Comparaciones " + vec.comparaciones;
        }
    }
}
