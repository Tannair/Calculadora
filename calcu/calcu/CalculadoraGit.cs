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
            Button numerador = (Button)sender;

            if (Convert.ToDouble(numerador.Text) % 2 == 0)
            {
                picTeste.Load("1.jpg");
                pictureBox10.Load("5.jpg");
                pictureBox12.Load("2.jpg");
                pictureBox13.Load("+.jpg");
                pictureBox1.Load("8.jpg");
                pictureBox3.Load("igual.jpg");
                pictureBox5.Load("simbolo.jpg");
                pictureBox6.Load("-.jpg");
                pictureBox8.Load("dividi.jpg");
                pictureBox9.Load("10.jpg");
                pictureBox2.Load("4.jpg");


                

            } else
            {
                picTeste.Load("2.jpg");
                pictureBox10.Load("10.jpg");
                pictureBox12.Load("8.jpg");
                pictureBox13.Load("5.jpg");
                pictureBox1.Load("+.jpg");
                pictureBox3.Load("dividi.jpg");
                pictureBox5.Load("igual.jpg");
                pictureBox6.Load("x.jpg");
                pictureBox8.Load("-.jpg");
                pictureBox9.Load("1.jpg");
                pictureBox2.Load("7.jpg");

            }


            if (resultado == true)
            {
                result.Text = "";                
                tela.Text += numerador.Text;
                resultado = false;

                picTeste.Load("simbolo.jpg");
                pictureBox10.Load("simbolo.jpg");
                pictureBox12.Load("simbolo.jpg");
                pictureBox13.Load("simbolo.jpg");
                pictureBox1.Load("simbolo.jpg");
                pictureBox3.Load("simbolo.jpg");
                pictureBox5.Load("simbolo.jpg");
                pictureBox6.Load("simbolo.jpg");
                pictureBox8.Load("simbolo.jpg");
                pictureBox9.Load("simbolo.jpg");
                pictureBox2.Load("simbolo.jpg");


            } else
            {
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
