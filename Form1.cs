using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoradeFiguras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularCuadrado_Click(object sender, EventArgs e)
        {
            // Obtenemos el valor del lado del cuadrado
            double lado;
            if (double.TryParse(txtLadoCuadrado.Text, out lado))
            {
                // Calculamos el perímetro y área del cuadrado
                double perimetro = 4 * lado;
                double area = lado * lado;

                // Mostramos los resultados en los TextBox correspondientes
                txtPerimetroCuadrado.Text = perimetro.ToString();
                txtAreaCuadrado.Text = area.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, introduce un valor numérico válido para el lado del cuadrado.");
            }
        }

        private void btnCalcularRectangulo_Click(object sender, EventArgs e)
        {
            // Obtenemos los valores de la base y la altura del rectángulo
            double baseRectangulo, alturaRectangulo;
            if (double.TryParse(txtBaseRectangulo.Text, out baseRectangulo) && double.TryParse(txtAlturaRectangulo.Text, out alturaRectangulo))
            {
                // Calculamos el perímetro y área del rectángulo
                double perimetro = 2 * (baseRectangulo + alturaRectangulo);
                double area = baseRectangulo * alturaRectangulo;

                // Mostramos los resultados en los TextBox correspondientes
                txtPerimetroRectangulo.Text = perimetro.ToString();
                txtAreaRectangulo.Text = area.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, introduce valores numéricos válidos para la base y la altura del rectángulo.");
            }
        }

        private void btnCalcularTriangulo_Click(object sender, EventArgs e)
        {
            // Obtenemos los valores de la base y la altura del triángulo
            double baseTriangulo, alturaTriangulo;
            if (double.TryParse(txtBaseTriangulo.Text, out baseTriangulo) && double.TryParse(txtAlturaTriangulo.Text, out alturaTriangulo))
            {
                // Calculamos el perímetro y área del triángulo equilátero
                // Perímetro: se asume un triángulo equilátero (3 lados iguales)
                double perimetro = 3 * baseTriangulo;
                double area = (baseTriangulo * alturaTriangulo) / 2;

                // Mostramos los resultados en los TextBox correspondientes
                txtPerimetroTriangulo.Text = perimetro.ToString();
                txtAreaTriangulo.Text = area.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, introduce valores numéricos válidos para la base y la altura del triángulo.");
            }
        }
    }
}
