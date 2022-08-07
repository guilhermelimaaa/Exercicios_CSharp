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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prcAplicativos.StartInfo.FileName = @"C:\Program Files\Microsoft Office\root\Office16\WINWORD.EXE";
            prcAplicativos.Start();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prcAplicativos.StartInfo.FileName = @"C:\Program Files\Microsoft Office\root\Office16\EXCEL.EXE";
            prcAplicativos.Start();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prcAplicativos.StartInfo.FileName = @"C:\Windows\System32\calc.exe";
            prcAplicativos.Start();
        }

        private void exercicio12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio12 objTela = new Exercicio12();
            objTela.ShowDialog();
        }

        private void exercicio25ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio25 objTela = new Exercicio25();
            objTela.ShowDialog();
        }
    }
}
