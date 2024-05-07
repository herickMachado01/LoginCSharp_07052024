using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            double zero0 = double.Parse(zero.Text);

            numeros.Text = (numeros.Text + zero0);
            sequenciaN.Text = (sequenciaN.Text + zero0);
        }

        private void Um_Click(object sender, EventArgs e)
        {
            double um1 = double.Parse(um.Text);

            numeros.Text = (numeros.Text + um1);
            sequenciaN.Text = (sequenciaN.Text + um1);
        }

        private void Dois_Click(object sender, EventArgs e)
        {
            double dois2 = double.Parse(dois.Text);

            numeros.Text = (numeros.Text + dois2);
            sequenciaN.Text = (sequenciaN.Text + dois2);
        }

        private void Tres_Click(object sender, EventArgs e)
        {
            double tres3 = double.Parse(tres.Text);

            numeros.Text = (numeros.Text + tres3);
            sequenciaN.Text = (sequenciaN.Text + tres3);
        }

        private void Quatro_Click(object sender, EventArgs e)
        {
            double quatro4 = double.Parse(quatro.Text);

            numeros.Text = (numeros.Text + quatro4);
            sequenciaN.Text = (sequenciaN.Text + quatro4);
        }

        private void Cinco_Click(object sender, EventArgs e)
        {
            double cinco5 = double.Parse(cinco.Text);

            numeros.Text = (numeros.Text + cinco5);
            sequenciaN.Text = (sequenciaN.Text + cinco5);
        }

        private void Seis_Click(object sender, EventArgs e)
        {
            double seis6 = double.Parse(seis.Text);

            numeros.Text = (numeros.Text + seis6);
            sequenciaN.Text = (sequenciaN.Text + seis6);
        }

        private void Sete_Click(object sender, EventArgs e)
        {
            double sete7 = double.Parse(sete.Text);

            numeros.Text = (numeros.Text + sete7);
            sequenciaN.Text = (sequenciaN.Text + sete7);
        }

        private void Oito_Click(object sender, EventArgs e)
        {
            double oito8 = double.Parse(oito.Text);

            numeros.Text = (numeros.Text + oito8);
            sequenciaN.Text = (sequenciaN.Text + oito8);
        }

        private void Nove_Click(object sender, EventArgs e)
        {
            double nove9 = double.Parse(nove.Text);

            numeros.Text = (numeros.Text + nove9);
            sequenciaN.Text = (sequenciaN.Text + nove9);
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            numeros.Text = ("");
            sequenciaN.Text = ("");
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            double valor2 = Double.Parse(numeros.Text);
            double valor1 = Double.Parse(histo.Text);
            double resultado = 0;
            string sinal_op = histo_sinal.Text;


            switch (sinal_op)
            {
                case "+":
                    resultado = valor1 + valor2;
                    sequenciaN.Text = (sequenciaN.Text + (" = ") + resultado);
                    break;
                case "-":
                    resultado = valor1 - valor2;
                    sequenciaN.Text = (sequenciaN.Text + (" = ") + resultado);
                    break;
                case "/":
                    resultado = valor1 / valor2;
                    sequenciaN.Text = (sequenciaN.Text + (" = ") + resultado);
                    break;
                case "x":
                    resultado = valor1 * valor2;
                    sequenciaN.Text = (sequenciaN.Text + (" = ") + resultado);
                    break;
                default:
                    break;
            }
            numeros.Text = resultado.ToString();
        }

        private void Mais_Click(object sender, EventArgs e)
        {
            histo.Text = (numeros.Text);
            numeros.Text = ("");
            histo_sinal.Text = ("+");
            sequenciaN.Text = (sequenciaN.Text + " + ");
        }

        private void Menos_Click(object sender, EventArgs e)
        {
            histo.Text = (numeros.Text);
            numeros.Text = ("");
            histo_sinal.Text = ("-");
            sequenciaN.Text = (sequenciaN.Text + " - ");
        }

        private void Vezes_Click(object sender, EventArgs e)
        {
            histo.Text = (numeros.Text);
            numeros.Text = ("");
            histo_sinal.Text = ("x");
            sequenciaN.Text = (sequenciaN.Text + " x ");
        }

        private void Dividido_Click(object sender, EventArgs e)
        {
            histo.Text = (numeros.Text);
            numeros.Text = ("");
            histo_sinal.Text = ("/");
            sequenciaN.Text = (sequenciaN.Text + " / ");
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            histo.Text = ("0");
            histo_sinal.Text = ("0");
            numeros.Text = ("");
            sequenciaN.Text = ("");
        }
    }
}
