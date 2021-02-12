namespace HopedaJa
{
    partial class frmListaProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaProd));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvListaProduto = new System.Windows.Forms.DataGridView();
            this.clidproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clpreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clqtde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(91, 277);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(265, 20);
            this.txtNome.TabIndex = 7;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // dgvListaProduto
            // 
            this.dgvListaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clidproduto,
            this.clnome,
            this.clpreco,
            this.clqtde});
            this.dgvListaProduto.Location = new System.Drawing.Point(12, 12);
            this.dgvListaProduto.Name = "dgvListaProduto";
            this.dgvListaProduto.Size = new System.Drawing.Size(443, 255);
            this.dgvListaProduto.TabIndex = 6;
            this.dgvListaProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProduto_CellContentClick);
            // 
            // clidproduto
            // 
            this.clidproduto.DataPropertyName = "idproduto";
            this.clidproduto.HeaderText = "Código";
            this.clidproduto.Name = "clidproduto";
            this.clidproduto.ReadOnly = true;
            this.clidproduto.Width = 50;
            // 
            // clnome
            // 
            this.clnome.DataPropertyName = "nome";
            this.clnome.HeaderText = "Nome";
            this.clnome.Name = "clnome";
            this.clnome.ReadOnly = true;
            this.clnome.Width = 150;
            // 
            // clpreco
            // 
            this.clpreco.DataPropertyName = "preco";
            this.clpreco.HeaderText = "Preço";
            this.clpreco.Name = "clpreco";
            this.clpreco.ReadOnly = true;
            // 
            // clqtde
            // 
            this.clqtde.DataPropertyName = "qtde";
            this.clqtde.HeaderText = "Quantidade";
            this.clqtde.Name = "clqtde";
            // 
            // frmListaProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 309);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvListaProduto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Produtos";
            this.Load += new System.EventHandler(this.frmListaProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvListaProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clpreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clqtde;
    }
}