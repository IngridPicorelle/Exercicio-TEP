using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex6_pg29_gustavo_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Horas_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int codigo = 0;
            double horas = 0, resultado = 0;

            codigo = int.Parse(txt_codigo.Text);
            horas = int.Parse(txt_horas.Text);

            if (codigo == 1)
            {
                resultado = horas * 15;
            }
            else if (codigo == 2)
            {
                resultado = horas * 21;
            }
            else
            {
                resultado = horas * 25;
            }

            MessageBox.Show("O valor total do salario é: R$" + resultado);
        }
    }
}
