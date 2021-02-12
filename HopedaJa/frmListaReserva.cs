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
    public partial class frmListaReserva : Form
    {
        public frmListaReserva()
        {
            InitializeComponent();
            reservaDados reservadados = new reservaDados();
            dgvListaReserva.DataSource = reservadados.listaReserva();
        }
        public reservas getdados()
        {
            reservas c = new reservas();
            c.idreserva = Int32.Parse(dgvListaReserva.CurrentRow.Cells[0].Value.ToString());
            c.idhospede = Int32.Parse(dgvListaReserva.CurrentRow.Cells[1].Value.ToString());
            c.idapartamento = Int32.Parse(dgvListaReserva.CurrentRow.Cells[2].Value.ToString());
            c.entrada = dgvListaReserva.CurrentRow.Cells[3].Value.ToString();
            c.saida = dgvListaReserva.CurrentRow.Cells[4].Value.ToString();
            c.categoria = dgvListaReserva.CurrentRow.Cells[5].Value.ToString();
            c.diarias = Int32.Parse(dgvListaReserva.CurrentRow.Cells[6].Value.ToString());
            c.valortotal = dgvListaReserva.CurrentRow.Cells[7].Value.ToString();
            return c;
        }
        private void frmListaReserva_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvListaReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
