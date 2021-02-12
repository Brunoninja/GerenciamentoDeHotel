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
    public partial class frmRelReserva : Form
    {
        public frmRelReserva()
        {
            InitializeComponent();
        }

        private void frmRelReserva_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DadosDataSet2.reserva' table. You can move, or remove it, as needed.
            this.reservaTableAdapter.Fill(this.DadosDataSet2.reserva);

            this.reportViewer1.RefreshReport();
        }
    }
}
