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
    public partial class frmListaFunc : Form
    {
        public frmListaFunc()
        {
            InitializeComponent();
            funcDados funcdados = new funcDados();
            dgvListaFunc.DataSource = funcdados.listaFuncionario();
        }
        public funcionario getdados()
        {
            funcionario c = new funcionario();
            c.idfunc = Int32.Parse(dgvListaFunc.CurrentRow.Cells[0].Value.ToString());
            c.nome = dgvListaFunc.CurrentRow.Cells[1].Value.ToString();
            c.cpf = dgvListaFunc.CurrentRow.Cells[2].Value.ToString();
            c.datanasc = dgvListaFunc.CurrentRow.Cells[3].Value.ToString();
            c.telefone = dgvListaFunc.CurrentRow.Cells[4].Value.ToString();
            c.cargo = dgvListaFunc.CurrentRow.Cells[5].Value.ToString();
            c.turno = dgvListaFunc.CurrentRow.Cells[6].Value.ToString();
            c.admissao = dgvListaFunc.CurrentRow.Cells[7].Value.ToString();
            //c.imagem = (dgvListaFunc.CurrentRow.Cells[8].Value.ToString());
            
            return c;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            funcDados cd = new funcDados();
            dgvListaFunc.DataSource =
                cd.listaFunc(txtNome.Text);
        }

        private void dgvListaFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            this.DialogResult = DialogResult.OK;
            
            
        }
    }
}
