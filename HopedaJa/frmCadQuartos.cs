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
    public partial class frmCadQuartos : Form
    {
        public frmCadQuartos()
        {
            InitializeComponent();
            AtivaBotaoInserir();
        }
        private void AtivaBotaoInserir()
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnInserir.Enabled = true;
            txtCodigo.Text = new apartDados().proxCodigo().ToString();
        }

        private void setdados(apartamentos c)
        {
            txtCodigo.Text = c.id.ToString();
            txtLeitos.Text = c.leitos.ToString();
            cmbSituacao.Text = c.situacao;
            cmbCategoria.Text = c.categoria;
            txtDescricao.Text = c.descricao;
        }
        private apartamentos getdados()
        {
            apartamentos c = new apartamentos();
            c.id = Int32.Parse(txtCodigo.Text);
            c.leitos = Int32.Parse(txtLeitos.Text);
            c.situacao = cmbSituacao.Text;
            c.categoria = cmbCategoria.Text;
            c.descricao = txtDescricao.Text;
            return c;
        }
        private void limpartela()
        {
            txtCodigo.Clear();
            txtLeitos.Clear();
            txtDescricao.Clear();
        }
        private void ativaExcluirApagar()
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnInserir.Enabled = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            apartDados query = new apartDados();
            query.inserir(this.getdados());
            limpartela();
            AtivaBotaoInserir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            apartDados cd = new apartDados();
            cd.AlterarApart(getdados());
            limpartela();
            AtivaBotaoInserir();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            apartDados cd = new apartDados();
            cd.apagarApart(Int32.Parse(txtCodigo.Text));
            limpartela();
            AtivaBotaoInserir();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListaApart frm = new frmListaApart();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                setdados(frm.getdados());
                ativaExcluirApagar();
            }
        }
    }
}
