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
    public partial class frmListaProd : Form
    {
        public frmListaProd()
        {
            InitializeComponent();
            produtoDados produtodao = new produtoDados();
            dgvListaProduto.DataSource = produtodao.listaProduto();
        }
        public produto getdados()
        {
            produto p = new produto();
            p.idproduto = Int32.Parse(dgvListaProduto.CurrentRow.Cells[0].Value.ToString());
            p.nome = dgvListaProduto.CurrentRow.Cells[1].Value.ToString();
            p.preco = dgvListaProduto.CurrentRow.Cells[2].Value.ToString();
            p.qtde = Int32.Parse(dgvListaProduto.CurrentRow.Cells[3].Value.ToString());
            return p;
        }

        private void dgvListaProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            produtoDados cd = new produtoDados();
            dgvListaProduto.DataSource =
                cd.listaProduto(txtNome.Text);
        }

        private void frmListaProd_Load(object sender, EventArgs e)
        {

        }
    }
}
