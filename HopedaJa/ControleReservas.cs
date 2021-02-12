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
    public partial class ControleReservas : Form
    {
        public ControleReservas()
        {
            InitializeComponent();
            AtivaBotaoInserir();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmListaHospede frm = new frmListaHospede();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                txtIdHospede.Text = Convert.ToString(frm.getdados().idhospede);
                txtNomeHospede.Text = frm.getdados().nome;
                txtCelular.Text = frm.getdados().telefone;
                txtCpf.Text = frm.getdados().cpf;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            reservaDados query = new reservaDados();
            query.inserir(this.getdados());
            limpartela();
            AtivaBotaoInserir();
        }
        private void AtivaBotaoInserir()
        {
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnInserir.Enabled = true;
            txtCodReserva.Text = new reservaDados().proxCodigo().ToString();
        }

        private void setdados(reservas c)
        {
            txtCodReserva.Text = c.idreserva.ToString();
            txtIdHospede.Text =c.idhospede.ToString();
            txtApart.Text = c.idapartamento.ToString();
            txtEntrada.Text = c.entrada;
            txtSaida.Text = c.saida;
            txtCateg.Text = c.categoria;
            txtDiaria.Text = c.diarias.ToString();
            txtAdulto.Text = c.adultos.ToString();
            txtCrianca.Text = c.criancas.ToString();
            cmbSituacao.Text = c.situacao;
            txtDiaria.Text = c.diarias.ToString();
            txtValorTotal.Text = c.valortotal.ToString();

        }
        private reservas getdados()
        {
            reservas c = new reservas();
            c.idreserva = Int32.Parse(txtCodReserva.Text);
            c.idhospede = Int32.Parse(txtIdHospede.Text); 
            c.idapartamento = Int32.Parse(txtApart.Text); 
            c.entrada = txtEntrada.Text;
            c.saida = txtSaida.Text;
            c.categoria = txtCateg.Text;
            c.diarias = Int32.Parse(txtDiaria.Text);
            c.adultos = Int32.Parse(txtAdulto.Text);
            c.criancas = Int32.Parse(txtCrianca.Text);
            c.situacao = cmbSituacao.Text;
            c.diarias = Int32.Parse(txtDiaria.Text);
            c.valortotal = txtValorTotal.Text;
            return c;
        }
        private void limpartela()
        {
            txtNomeHospede.Clear();
            txtCelular.Clear();
            txtCpf.Clear();
            txtEntrada.Clear();
            txtSaida.Clear();
            txtApart.Clear();
            txtDiaria.Clear();
            cmbSituacao.Text = "Selecione";
            txtCateg.Clear();
            txtCrianca.Clear();
            txtTaxaServ.Clear();
            txtValorDia.Clear();
            txtValorTotal.Clear();
            txtIdHospede.Clear();
            txtAdulto.Clear();
        }
        private void ativaExcluirApagar()
        {
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnInserir.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmListaApart frm = new frmListaApart();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {

                txtApart.Text = Convert.ToString(frm.getdados().id);
                txtCateg.Text = frm.getdados().categoria;
                                                        
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if ((txtDiaria.Text == "")&&(txtTaxaServ.Text == ""))
                MessageBox.Show("Valores Invalidos" ,"Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

            txtValorTotal.Text = (Convert.ToDouble(txtValorDia.Text) + Convert.ToDouble(txtTaxaServ.Text)).ToString();

            txtValorTotal.Text = Convert.ToDouble(txtValorTotal.Text).ToString("C");

           


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpartela();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListaReserva frm = new frmListaReserva();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                setdados(frm.getdados());
                ativaExcluirApagar();
            }
        }

        private void dgvListaReserva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void ControleReservas_Load(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            reservaDados cd = new reservaDados();
            cd.apagarReserva(Int32.Parse(txtCodReserva.Text));
            limpartela();
            AtivaBotaoInserir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            reservaDados cd = new reservaDados();
            cd.AlterarReserva(getdados());
            limpartela();
            AtivaBotaoInserir();
        }

        private void txtValorTotal_Leave(object sender, EventArgs e)
        {
            txtValorTotal.Text = Convert.ToDouble(txtValorTotal.Text).ToString("C");
        }

        private void txtValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValorTotal.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtValorTotal_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtValorTotal.Text.Length - 1; i++)
            {
                if ((txtValorTotal.Text[i] >= '0' &&
                    txtValorTotal.Text[i] <= '9') ||
                    txtValorTotal.Text[i] == ',')
                {
                    x += txtValorTotal.Text[i];
                }
            }
            txtValorTotal.Text = x;
            txtValorTotal.SelectAll();

            //txtValorTotal.Text = (Convert.ToDouble(txtValorDia.Text) + Convert.ToDouble(txtTaxaServ.Text)).ToString();
        }

        private void btnCalcular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValorTotal.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void btnCalcular_Leave(object sender, EventArgs e)
        {
           // txtValorTotal.Text = Convert.ToDouble(txtValorTotal.Text).ToString("C");
        }
    }
 }

