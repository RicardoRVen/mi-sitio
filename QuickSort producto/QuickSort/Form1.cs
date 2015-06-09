using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickSort
{
    public partial class Form1 : Form
    {
        //atributos de la clese
        private QuickSort qSort;
        private int indice;
        private producto[] arregloP;
        private producto pr;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           arregloP = new producto[2];
            
            //vector = new int[2];
            indice = 0;
          
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
         
            pr = new producto();
     
            pr.IdProducto=Int16.Parse(txtidProducto.Text);
            pr.Descripcion = txtProducto.Text;
            arregloP[indice] = pr;
           //vector[indice] = pr.IdProducto;
            indice++;//incremento
            //instrucciones para mostrar los elementos
            lstElemento.Items.Add(indice.ToString().PadLeft(5)
                + " " + txtidProducto.Text.PadRight(10)
                + " " + txtProducto.Text.PadRight(5)
                );
            txtidProducto.Text = "";
            txtProducto.Text = "";
            txtidProducto.Focus();

          //  MessageBox.Show(arregloP+"");

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            qSort = new QuickSort();
            qSort.ordenarVector(arregloP, 0, arregloP.Length - 1);

            indice = 0;
            foreach (producto elemento in qSort.devolverVector())
            {
                indice++;
                lstOrdenado.Items.Add(indice.ToString().PadLeft(5)
                    + " " + elemento.IdProducto.ToString().PadRight(10)
                    + " " + elemento.Descripcion.PadRight(5)
                    );
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
