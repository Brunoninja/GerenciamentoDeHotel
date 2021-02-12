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
    public partial class frmListaHospede : Form
    {
        public frmListaHospede()
        {
            InitializeComponent();
            hospedeDados hospededados = new hospedeDados();
            dgvListaHospede.DataSource = hospededados.listaHospede();
        }
        public hospede getdados()
        {
            hospede c = new hospede();
            c.idhospede = Int32.Parse(dgvListaHospede.CurrentRow.Cells[0].Value.ToString());
            c.nome = dgvListaHospede.CurrentRow.Cells[1].Value.ToString();
            c.cpf = dgvListaHospede.CurrentRow.Cells[2].Value.ToString();
            c.endereco = dgvListaHospede.CurrentRow.Cells[3].Value.ToString();
            c.cidade = dgvListaHospede.CurrentRow.Cells[4].Value.ToString();
            c.estado = dgvListaHospede.CurrentRow.Cells[5].Value.ToString();
            c.telefone = dgvListaHospede.CurrentRow.Cells[6].Value.ToString();
            return c;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            hospedeDados cd = new hospedeDados();
            dgvListaHospede.DataSource =
                cd.listaHospede(txtNome.Text);
        }

        private void dgvListaHospede_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
