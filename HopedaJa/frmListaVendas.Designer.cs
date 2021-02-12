namespace HopedaJa
{
    partial class frmListaVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaVendas));
            this.dgvListaProduto = new System.Windows.Forms.DataGridView();
            this.clcodvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clprod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clqtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProduto
            // 
            this.dgvListaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clcodvenda,
            this.clprod,
            this.clqtde,
            this.cltotal});
            this.dgvListaProduto.Location = new System.Drawing.Point(2, 1);
            this.dgvListaProduto.Name = "dgvListaProduto";
            this.dgvListaProduto.Size = new System.Drawing.Size(475, 255);
            this.dgvListaProduto.TabIndex = 7;
            this.dgvListaProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProduto_CellContentClick);
            // 
            // clcodvenda
            // 
            this.clcodvenda.DataPropertyName = "codvenda";
            this.clcodvenda.HeaderText = "Código";
            this.clcodvenda.Name = "clcodvenda";
            this.clcodvenda.ReadOnly = true;
            this.clcodvenda.Width = 80;
            // 
            // clprod
            // 
            this.clprod.DataPropertyName = "prod";
            this.clprod.HeaderText = "Produto";
            this.clprod.Name = "clprod";
            this.clprod.ReadOnly = true;
            this.clprod.Width = 150;
            // 
            // clqtde
            // 
            this.clqtde.DataPropertyName = "qtde";
            this.clqtde.HeaderText = "Quantidade";
            this.clqtde.Name = "clqtde";
            this.clqtde.ReadOnly = true;
            // 
            // cltotal
            // 
            this.cltotal.DataPropertyName = "total";
            this.cltotal.HeaderText = "Total";
            this.cltotal.Name = "cltotal";
            this.cltotal.ReadOnly = true;
            // 
            // frmListaVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 257);
            this.Controls.Add(this.dgvListaProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Vendas";
            this.Load += new System.EventHandler(this.frmListaVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcodvenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clqtde;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltotal;
    }
}