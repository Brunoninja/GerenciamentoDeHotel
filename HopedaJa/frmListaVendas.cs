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
    public partial class frmListaVendas : Form
    {
        public frmListaVendas()
        {
            InitializeComponent();
            vendaDados vendadao = new vendaDados();
            dgvListaProduto.DataSource = vendadao.listaVenda();
        }
        public venda getdados()
        {
            venda p = new venda();
            p.codvenda = Int32.Parse(dgvListaProduto.CurrentRow.Cells[0].Value.ToString());
            p.prod = dgvListaProduto.CurrentRow.Cells[1].Value.ToString();
            p.qtde = Int32.Parse(dgvListaProduto.CurrentRow.Cells[2].Value.ToString());
            p.total = dgvListaProduto.CurrentRow.Cells[3].Value.ToString();
            return p;
        }

        private void frmListaVendas_Load(object sender, EventArgs e)
        {

        }

        private void dgvListaProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
