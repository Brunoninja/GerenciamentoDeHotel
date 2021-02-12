using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HopedaJa
{
    public partial class frmCadFuncionario : Form
    {
        public frmCadFuncionario()
        {
            InitializeComponent();
            AtivaBotaoInserir();
        }
        private void AtivaBotaoInserir()
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnInserir.Enabled = true;
            txtCodigo.Text = new funcDados().proxCodigo().ToString();
        }

        private void setdados(funcionario c)
        {
            txtCodigo.Text = c.idfunc.ToString();
            txtNome.Text = c.nome;
            mtbCpf.Text = c.cpf;
            txtNasc.Text = c.datanasc;
            txtFone.Text = c.telefone;
            txtCargo.Text = c.cargo;
            cmbTurno.Text = c.turno;
            txtAdm.Text = c.admissao;
            picImagem.Image = c.imagem;
            txtSenha.Text = c.senha;

        }
        private funcionario getdados()
        {
            funcionario c = new funcionario();
            c.idfunc = Int32.Parse(txtCodigo.Text);
            c.nome = txtNome.Text;
            c.cpf = mtbCpf.Text;
            c.datanasc = txtNasc.Text;
            c.telefone = txtFone.Text;
            c.cargo = txtCargo.Text;
            c.turno = cmbTurno.Text;
            c.admissao = txtAdm.Text;
            c.imagem = picImagem.Image;
            c.senha = txtSenha.Text;
            return c;
        }
        private void limpartela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            mtbCpf.Clear();
            txtNasc.Clear();
            txtFone.Clear();
            txtCargo.Clear();
            txtAdm.Clear();
            txtSenha.Clear();
            
        }
        private void ativaExcluirApagar()
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnInserir.Enabled = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcDados query = new funcDados();
            query.inserir(this.getdados());
            limpartela();
            AtivaBotaoInserir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funcDados cd = new funcDados();
            cd.AlterarFuncionario(getdados());
            limpartela();
            AtivaBotaoInserir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            funcDados cd = new funcDados();
            cd.apagarFuncionario(Int32.Parse(txtCodigo.Text));
            limpartela();
            AtivaBotaoInserir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmListaFunc frm = new frmListaFunc();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                setdados(frm.getdados());
                ativaExcluirApagar();
            }
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            CarregaImagem();
        }
        protected void CarregaImagem()
        {
            try
            {
                this.openFileDialog1.ShowDialog(this);
                string strFn = this.openFileDialog1.FileName;

                if (string.IsNullOrEmpty(strFn))
                    return;

                this.picImagem.Image = Image.FromFile(strFn);
                
                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
