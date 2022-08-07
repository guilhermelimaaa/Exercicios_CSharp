using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMenu
{
    public partial class Exercicio12 : Form
    {
        public Exercicio12()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAnoNascimento.Text = "";

            txtAnoNascimento.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int lblIdade;
            
            lblIdade = 2020 - (Int32.Parse(txtAnoNascimento.Text));
   
            if (lblIdade >= 16)
            {
                MessageBox.Show("Sua Idade é:" + lblIdade + " e você pode votar em 2020", "Pode ou não votar ?", MessageBoxButtons.OK);
            }

            else MessageBox.Show("Sua Idade é:" + lblIdade + " e você não pode votar em 2020", "Pode ou não votar ?", MessageBoxButtons.OK);

        }

        private void txtAnoNascimento_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


