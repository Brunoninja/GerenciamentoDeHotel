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
    public partial class frmVenda : Form
    {
        public frmVenda()
        {
            InitializeComponent();
            AtivaBotaoInsert();
        }
        private void AtivaBotaoInsert()
        {
            btnInserir.Enabled = true;
            txtCodVenda.Text = new vendaDados().proxCodigo().ToString();
        }
        private void setdados(venda p)
        {
            txtCodVenda.Text = p.codvenda.ToString();
            txtProd.Text = p.prod;
            txtQtde.Text = p.qtde.ToString();
            txtTotal.Text = p.total;

        }
        private venda getdados()
        {
            venda p = new venda();
            p.codvenda = Int32.Parse(txtCodVenda.Text);
            p.prod = txtProd.Text;
            p.qtde = Int32.Parse(txtQtde.Text);
            p.total = txtTotal.Text;
            return p;
        }
        private void limpartela()
        {
            txtCodVenda.Clear();
            txtProd.Clear();
            txtQtde.Clear();
            txtTotal.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            vendaDados query = new vendaDados();
            query.inserir(this.getdados());
            limpartela();
            AtivaBotaoInsert();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmListaVendas frm = new frmListaVendas();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                setdados(frm.getdados());
                
            }
        }

        private void txtProd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtProd_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmListaProd frm = new frmListaProd();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                txtProd.Text = frm.getdados().nome;
                txtPrecoProd.Text = frm.getdados().preco;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((txtPrecoProd.Text == "") && (txtQtde.Text == ""))
                MessageBox.Show("Valores Invalidos", "Verificar", MessageBoxButtons.OK, MessageBoxIcon.Error);


            txtTotal.Text = (Convert.ToDouble(txtQtde.Text) * Convert.ToDouble(txtPrecoProd.Text)).ToString();

            txtTotal.Text = Convert.ToDouble(txtTotal.Text).ToString("C");
        }

        private void txtPrecoProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecoProd_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (!txtPrecoProd.Text.Contains(','))
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
    }
}
