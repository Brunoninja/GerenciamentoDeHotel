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
    public partial class frmListaApart : Form
    {
        public frmListaApart()
        {
            InitializeComponent();
            apartDados funcdados = new apartDados();
            dgvListaApartamentos.DataSource = funcdados.listaApart();
            //Teste para tentar ocultar apartamento quando reservado
            /*List<reservas> lista = new reservaDados().listaReserva();
            foreach (reservas rev in lista)
            {
                if (rev.idapartamento == 1)
                {
                    frmListaApart list = new frmListaApart();
                    //dgvListaApartamentos.CurrentRow.Cells[2].Value = "ocupado".ToString();
                    dgvListaApartamentos.Columns[2].Visible = false;
                    //Visible = false;
                }
            }*/
        }
        public apartamentos getdados()
        {
            apartamentos c = new apartamentos();
            c.id = Int32.Parse(dgvListaApartamentos.CurrentRow.Cells[0].Value.ToString());
            c.leitos = Int32.Parse(dgvListaApartamentos.CurrentRow.Cells[1].Value.ToString());
            c.situacao = dgvListaApartamentos.CurrentRow.Cells[2].Value.ToString();
            c.categoria = dgvListaApartamentos.CurrentRow.Cells[3].Value.ToString();
            c.descricao = dgvListaApartamentos.CurrentRow.Cells[4].Value.ToString();
            return c;
        }

        private void dgvListaHospede_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmListaApart_Load(object sender, EventArgs e)
        {

        }
    }
}
