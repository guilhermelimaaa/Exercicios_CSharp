using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMenu
{
    public partial class Exercicio25 : Form
    {
        public Exercicio25()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "";
            txtValor3.Text = "";
            txtValor4.Text = "";
            txtValor5.Text = "";
            txtValor6.Text = "";
            txtValor7.Text = "";
            txtValor8.Text = "";
            txtValor9.Text = "";
            txtValor10.Text = "";

            txtValor1.Focus();
            txtValor2.Focus();
            txtValor3.Focus();
            txtValor4.Focus();
            txtValor5.Focus();
            txtValor6.Focus();
            txtValor7.Focus();
            txtValor8.Focus(); 
            txtValor9.Focus();
            txtValor10.Focus();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[] Valor=new double[10];

            int Intervalo = 0;
            int ForaIntervalo = 0;


            Valor[0] = Convert.ToDouble(txtValor1.Text);
            Valor[1] = Convert.ToDouble(txtValor2.Text);
            Valor[2] = Convert.ToDouble(txtValor3.Text);
            Valor[3] = Convert.ToDouble(txtValor4.Text);
            Valor[4] = Convert.ToDouble(txtValor5.Text);
            Valor[5] = Convert.ToDouble(txtValor6.Text);
            Valor[6] = Convert.ToDouble(txtValor7.Text);
            Valor[7] = Convert.ToDouble(txtValor8.Text);
            Valor[8] = Convert.ToDouble(txtValor9.Text);
            Valor[9] = Convert.ToDouble(txtValor10.Text);

            if (Valor[0] <=9)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else if (Valor[0] >= 21)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
             else
            {
                Intervalo = Intervalo + 1;
            }

            if (Valor[1] <= 9)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else if (Valor[1] >= 21)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else
            {
                Intervalo = Intervalo + 1;
            }

            if (Valor[2] <= 9)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else if (Valor[2] >= 21)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else
            {
                Intervalo = Intervalo + 1;
            }

            if (Valor[3] <= 9)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else if (Valor[3] >= 21)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else
            {
                Intervalo = Intervalo + 1;
            }

            if (Valor[4] <= 9)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else if (Valor[4] >= 21)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else
            {
                Intervalo = Intervalo + 1;
            }

            if (Valor[5] <= 9)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else if (Valor[5] >= 21)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else
            {
                Intervalo = Intervalo + 1;
            }

            if (Valor[6] <= 9)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else if (Valor[6] >= 21)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else
            {
                Intervalo = Intervalo + 1;
            }

            if (Valor[7] <= 9)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else if (Valor[7] >= 21)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else
            {
                Intervalo = Intervalo + 1;
            }

            if (Valor[8] <= 9)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else if (Valor[8] >= 21)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else
            {
                Intervalo = Intervalo + 1;
            }
            if (Valor[9] <= 9)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else if (Valor[9] >= 21)
            {
                ForaIntervalo = ForaIntervalo + 1;
            }
            else
            {
                Intervalo = Intervalo + 1;
            }

            

            MessageBox.Show("A Quantidade de número no intervalo entre 10-20 é: " + Intervalo + "\n A Quantidade de numeros fora do intervalo entre 10-20 é: " + ForaIntervalo, "Intervalo de números entre 10-20", MessageBoxButtons.OK);


        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
