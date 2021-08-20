using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraRaices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            if (float.TryParse(Amtbox.Text, out _) && float.TryParse(Bmtbox.Text, out _) && float.TryParse(Cmtbox.Text, out _))
            {
                float a = float.Parse(Amtbox.Text);
                float b = float.Parse(Bmtbox.Text);
                float c = float.Parse(Cmtbox.Text);

                float aux = b * b - 4 * a * c;

                float X = 0;
                float Y = 0;

                //Caso raices reales distintas: ----------
                if (aux > 0)
                {
                    Raiz1tbox.Text = (-1 * b + (float)Math.Sqrt(aux) / (2 * a)).ToString();
                    Raiz2tbox.Text = (-1 * b - (float)Math.Sqrt(aux) / (2 * a)).ToString();
                }

                //Caso raices reales dobles: ----------
                if (aux == 0)
                {
                    Raiz1tbox.Text = (-1 * b / (2 * a)).ToString();
                    Raiz2tbox.Text = (-1 * b / (2 * a)).ToString();
                }

                //Caso raices imaginarias conjugadas ----------
                if (aux < 0)
                {
                    //Parte imaginaria:
                    Y = (float)Math.Sqrt(-1 * aux) / (2 * a);

                    //Parte real:
                    X = -1 * b / (2 * a);

                    Raiz1tbox.Text = (X).ToString() + " + i " + (Y).ToString();
                    Raiz2tbox.Text = (X).ToString() + " - i " + (Y).ToString();
                }

            }

        }
    }
}
