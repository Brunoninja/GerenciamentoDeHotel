using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopedaJa
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void hOSPEDAGEMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCadHospede().ShowDialog();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCadFuncionario().ShowDialog();
        }

        private void quartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCadQuartos().ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCadProduto().ShowDialog();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mapaDeQuartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmMapaQuartos().ShowDialog();
        }

        private void cADASTROSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmVenda().ShowDialog();
        }

        private void controleDeReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ControleReservas().ShowDialog();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmRelHospedes().ShowDialog();
        }

        private void funcionáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmRelFunc().ShowDialog();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmRelReserva().ShowDialog();
        }
    }
    }

