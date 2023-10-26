using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRever
{
    public partial class TelaForm : Form
    {
        private int resultado;

        public TelaForm()
        {
            InitializeComponent();
        }
        private void btn_calcular_Click_1(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt32(txt_valor1.Text);
            int valor2 = Convert.ToInt32(txt_valor2.Text);
            int valor3 = Convert.ToInt32(txt_valor3.Text);
            string maior = "";


            if (valor1 > valor2 && valor2 > valor3)
            {

                maior = ("O Maior numero é " + "\n" + valor1 + "\n" + " O segundo " + "\n" + valor2 + "\n" + " O Terceiro " + valor3);
            }

            if (valor2 > valor1 && valor1 > valor3)
            {

                maior = ("O Maior numero é " + "\n" + valor2 + "\n" + "O segundo " + valor1 + "\n" + " O Terceiro " + valor3);
            }

            if (valor3 > valor2 && valor2 > valor1)
            {
                maior = ("O Maior numero é " + "\n" + valor3 + "\n" + "O segundo " + valor2 + "\n" + "O Terceiro " + valor1);
            }

            if (valor2 > valor3 && valor3 > valor1)
            {
                maior = ("O Maior numero é " + "\n" + valor2 + "\n" + " O segundo " + valor3 + "\n" + " O Terceiro " + valor1);
            }
            if (valor3 > valor1 && valor1 > valor2)
            {
                maior = ("O Maior numero é " + "\n" + valor3 + "\n" + " O segundo " + valor1 + "\n" + " O Terceiro " + valor2);
            }
            if (valor1 > valor3 && valor3 > valor2)
            {
                maior = ("O Maior numero é " + "\n" + valor1 + "\n" + " O segundo " + valor3 + "\n" + " O Terceiro " + valor2);
            }

            lbl_resultado.Text = maior;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = "";
            txt_valor1.Text = "";
            txt_valor2.Text = "";
            txt_valor3.Text = "";


        }
    }
}
