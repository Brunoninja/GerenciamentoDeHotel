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
    public partial class frmCadHospede : Form
    {
        public frmCadHospede()
        {
            InitializeComponent();
            AtivaBotaoInserir();
        }
        private void AtivaBotaoInserir()
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnInserir.Enabled = true;
            txtCodigo.Text = new hospedeDados().proxCodigo().ToString();
        }

        private void setdados(hospede c)
        {
            txtCodigo.Text = c.idhospede.ToString();
            txtNome.Text = c.nome;
            mtbCpf.Text = c.cpf;
            txtEndereco.Text = c.endereco;
            txtCidade.Text = c.cidade;
            txtEstado.Text = c.estado;
            txtFone.Text = c.telefone;

        }
        private hospede getdados()
        {
            hospede c = new hospede();
            c.idhospede = Int32.Parse(txtCodigo.Text);
            c.nome = txtNome.Text;
            c.cpf = mtbCpf.Text;
            c.endereco = txtEndereco.Text;
            c.cidade = txtCidade.Text;
            c.estado = txtEstado.Text;
            c.telefone = txtFone.Text;
            return c;
        }
        private void limpartela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            mtbCpf.Clear();
            txtEndereco.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtFone.Clear();
        }
        private void ativaExcluirApagar()
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnInserir.Enabled = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            hospedeDados query = new hospedeDados();
            query.inserir(this.getdados());
            limpartela();
            AtivaBotaoInserir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            hospedeDados cd = new hospedeDados();
            cd.AlterarHospede(getdados());
            limpartela();
            AtivaBotaoInserir();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            hospedeDados cd = new hospedeDados();
            cd.apagarHospede(Int32.Parse(txtCodigo.Text));
            limpartela();
            AtivaBotaoInserir();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListaHospede frm = new frmListaHospede();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                setdados(frm.getdados());
                ativaExcluirApagar();
            }
        }
    }
}
