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
    public partial class frmCadProduto : Form
    {
        public frmCadProduto()
        {
            InitializeComponent();
            AtivaBotaoInsert();
        }
        private void AtivaBotaoInsert()
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnInsert.Enabled = true;
            txtCodigo.Text = new produtoDados().proxCodigo().ToString();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            produtoDados query = new produtoDados();
            query.inserir(this.getdados());
            limpartela();
            AtivaBotaoInsert();
        }
        private void setdados(produto p)
        {
            txtCodigo.Text = p.idproduto.ToString();
            txtNome.Text = p.nome;
            //p.preco = Double.Parse(txtPreco.Text);
            txtPreco.Text = p.preco;
            txtQtde.Text = p.qtde.ToString();

        }
        private produto getdados()
        {
            produto p = new produto();
            p.idproduto = Int32.Parse(txtCodigo.Text);
            p.nome = txtNome.Text;
            p.preco = txtPreco.Text;
            p.qtde = Int32.Parse(txtQtde.Text);
            return p;
        }
        private void limpartela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            txtQtde.Clear();
        }
        private void ativaExcluirApagar()
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnInsert.Enabled = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            produtoDados cd = new produtoDados();
            cd.AlterarProduto(getdados());
            limpartela();
            AtivaBotaoInsert();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            produtoDados c = new produtoDados();
            c.apagarProduto(Int32.Parse(txtCodigo.Text));
            limpartela();
            AtivaBotaoInsert();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListaProd frm = new frmListaProd();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                setdados(frm.getdados());
                ativaExcluirApagar();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            produtoDados query = new produtoDados();
            query.inserir(this.getdados());
            limpartela();
            AtivaBotaoInsert();
        }

        private void txtQtde_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_Leave(object sender, EventArgs e)
        {
            txtPreco.Text = Convert.ToDouble(txtPreco.Text).ToString("C");
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtPreco.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtPreco_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtPreco.Text.Length - 1; i++)
            {
                if ((txtPreco.Text[i] >= '0' &&
                    txtPreco.Text[i] <= '9') ||
                    txtPreco.Text[i] == ',')
                {
                    x += txtPreco.Text[i];
                }
            }
            txtPreco.Text = x;
            txtPreco.SelectAll();
        }
    }
}
