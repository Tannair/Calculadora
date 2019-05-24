using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace calcu
{
    public partial class UserControl1: UserControl
    {

        String op;
        double a = 0;
        bool resultado = false;

        public UserControl1()
        {
            InitializeComponent();
        }


        private void Numerador_Click(object sender, EventArgs e)
        {

            if (resultado == true)
            {
                result.Text = "";
                Button numerador = (Button)sender;
                tela.Text += numerador.Text;
                resultado = false;

            } else
            {
                Button numerador = (Button)sender;
                tela.Text += numerador.Text;

            }

        }

        private void Clean_Click(object sender, EventArgs e)
        {
            tela.Text = "";
            result.Text = "";
            a = 0;


        }

        private void Divisao_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(tela.Text);

            Button bt = (Button)sender;
            result.Text += a + " " + bt.Text + " ";
            tela.Text = "";

            op = "/";

        }


        private void Multiplicacao_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(tela.Text);

            Button bt = (Button)sender;
            result.Text += a + " " + bt.Text + " ";
            tela.Text = "";

            op = "x";

        }

        private void Subtracao_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(tela.Text);

            Button bt = (Button)sender;
            result.Text += a + " " + bt.Text + " ";
            tela.Text = "";

            op = "-";

        }

        private void Soma_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(tela.Text);

            Button bt = (Button)sender;
            result.Text += a + " " + bt.Text + " ";
            tela.Text = "";

            op = "+";

        }

        private void Ponto_Click(object sender, EventArgs e)
        {
            tela.Text += ".";
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            resultado = true;

            switch (op)
            {
                case "+":                    
                    result.Text += tela.Text + " = " + Convert.ToString(a + Convert.ToDouble(tela.Text));
                    tela.Text = "";
                    break;

                case "-":
                    result.Text += tela.Text + " = " + Convert.ToString(a - Convert.ToDouble(tela.Text));
                    tela.Text = "";
                    break;

                case "/":
                    result.Text += tela.Text + " = " + Convert.ToString(a / Convert.ToDouble(tela.Text));
                    tela.Text = "";
                    break;

                case "x":
                    result.Text += tela.Text + " = " + Convert.ToString(a * Convert.ToDouble(tela.Text));
                    tela.Text = "";
                    break;

                default:
                    tela.Text += "teste" + op;
                    break;

            }
        }
    }
}
