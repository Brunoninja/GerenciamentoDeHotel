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
    public partial class frmMapaQuartos : Form
    {
        public frmMapaQuartos()
        {
            InitializeComponent();
            //quarto 01
            btnLivre.Visible = true;
            btnOcupado.Visible = false;
            //quarto 02
            btnLivre02.Visible = true;
            btnOcup02.Visible = false;
            //quarto03
            btnLivre03.Visible = true;
            btnOcup03.Visible = false;
            //quarto04
            btnLivre04.Visible = true;
            btnOcup04.Visible = false;
            //quarto05
            btnLivre05.Visible = true;
            btnOcup05.Visible = false;
            //quarto06
            btnLivre06.Visible = true;
            btnOcup06.Visible = false;
            //quarto07
            btnLivre07.Visible = true;
            btnOcup07.Visible = false;
            //quarto08
            btnLivre08.Visible = true;
            btnOcup08.Visible = false;

            List<reservas> lista = new reservaDados().listaReserva();
            foreach (reservas rev in lista) {
                if (rev.idapartamento == 1)
                {
                    btnLivre.Visible = false;
                    btnOcupado.Visible = true;
                }
                if (rev.idapartamento == 2)
                {
                    btnLivre02.Visible = false;
                    btnOcup02.Visible = true;
                }
                if (rev.idapartamento == 3)
                {
                    btnLivre03.Visible = false;
                    btnOcup03.Visible = true;
                }
                if (rev.idapartamento == 4)
                {
                    btnLivre04.Visible = false;
                    btnOcup04.Visible = true;
                }
                if (rev.idapartamento == 5)
                {
                    btnLivre05.Visible = false;
                    btnOcup05.Visible = true;
                }
                if (rev.idapartamento == 6)
                {
                    btnLivre06.Visible = false;
                    btnOcup06.Visible = true;
                }
                if (rev.idapartamento == 7)
                {
                    btnLivre07.Visible = false;
                    btnOcup07.Visible = true;
                }
                if (rev.idapartamento == 8)
                {
                    btnLivre08.Visible = false;
                    btnOcup08.Visible = true;
                }

            }
           
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

        }


        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }


        private void btnLivre_Click(object sender, EventArgs e)
        {
           
           btnOcupado.Visible = true;
           btnLivre.Visible = false;
        }

        private void btnOcupado_Click(object sender, EventArgs e)
        {
            btnLivre.Visible = true;
            btnOcupado.Visible = false;
        }

        private void btnOcup02_Click(object sender, EventArgs e)
        {
            btnLivre02.Visible = true;
            btnOcup02.Visible = false;
        }

        private void btnLivre02_Click(object sender, EventArgs e)
        {
            btnOcup02.Visible = true;
            btnLivre02.Visible = false;
        }

        private void btnOcup03_Click(object sender, EventArgs e)
        {
            btnLivre03.Visible = true;
            btnOcup03.Visible = false;
        }

        private void btnLivre03_Click(object sender, EventArgs e)
        {
            btnOcup03.Visible = true;
            btnLivre03.Visible = false;
        }

        private void btnOcup04_Click(object sender, EventArgs e)
        {
           btnLivre04.Visible = true;
           btnOcup04.Visible = false;
        }

        private void btnLivre04_Click(object sender, EventArgs e)
        {
           btnOcup04.Visible = true;
           btnLivre04.Visible = false;
        }

        private void frmMapaQuartos_Load(object sender, EventArgs e)
        {

        }
    }
}
