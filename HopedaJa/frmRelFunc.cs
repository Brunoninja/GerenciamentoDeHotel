﻿using System;
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
    public partial class frmRelFunc : Form
    {
        public frmRelFunc()
        {
            InitializeComponent();
        }

        private void frmRelFunc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DadosDataSet1.funcionario' table. You can move, or remove it, as needed.
            this.funcionarioTableAdapter.Fill(this.DadosDataSet1.funcionario);

            this.reportViewer1.RefreshReport();
        }
    }
}
