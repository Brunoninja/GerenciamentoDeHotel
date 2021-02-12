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
    public partial class frmTeladeAbertura : Form
    {
        public frmTeladeAbertura()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 1;
            }else
            {
                timer1.Enabled = false;
                this.Visible = false;

                frmLogin login = new frmLogin();
                login.ShowDialog();
            }

        }

        private void frmTeladeAbertura_Load(object sender, EventArgs e)
        {
            // Escolha uma cor de fundo não utilizada
            //this.BackColor = Color.Thistle;
            // Agora defina o TransparencyKey para a mesma cor
            //this.TransparencyKey = Color.Thistle;
            // Opcional. Deixe o form sem bordas e barra de título
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 5)
                label3.Text = "05%";
            else
                if (progressBar1.Value == 18)
                label3.Text = "18%";
            else
                if (progressBar1.Value == 31)
                label3.Text = "31%";
            else
                if (progressBar1.Value == 50)
            {
                label3.Text = "50%";
                label2.Text = "Restaurando Dados";
            }
            else
                if (progressBar1.Value == 55)
                label3.Text = "55%";
            else
                if (progressBar1.Value == 60)
                label3.Text = "60%";
            else
                if (progressBar1.Value == 85)
                label3.Text = "85%";
            else
                if (progressBar1.Value == 96)
            {
                label3.Text = "96%";
                label2.Text = "Carregamento Completo";
            }
            else
                if (progressBar1.Value == 100)
                label3.Text = "100%";
        }
    }
}
