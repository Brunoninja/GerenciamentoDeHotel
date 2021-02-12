namespace HopedaJa
{
    partial class frmListaApart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaApart));
            this.dgvListaApartamentos = new System.Windows.Forms.DataGridView();
            this.clid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clleitos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaApartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaApartamentos
            // 
            this.dgvListaApartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaApartamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clid,
            this.clleitos,
            this.clsituacao,
            this.clcategoria,
            this.cldescricao});
            this.dgvListaApartamentos.Location = new System.Drawing.Point(2, 1);
            this.dgvListaApartamentos.Name = "dgvListaApartamentos";
            this.dgvListaApartamentos.Size = new System.Drawing.Size(664, 255);
            this.dgvListaApartamentos.TabIndex = 5;
            this.dgvListaApartamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaHospede_CellContentClick);
            // 
            // clid
            // 
            this.clid.DataPropertyName = "id";
            this.clid.HeaderText = "Código";
            this.clid.Name = "clid";
            this.clid.ReadOnly = true;
            this.clid.Width = 60;
            // 
            // clleitos
            // 
            this.clleitos.DataPropertyName = "leitos";
            this.clleitos.HeaderText = "Leitos";
            this.clleitos.Name = "clleitos";
            this.clleitos.ReadOnly = true;
            // 
            // clsituacao
            // 
            this.clsituacao.DataPropertyName = "situacao";
            this.clsituacao.HeaderText = "Situação";
            this.clsituacao.Name = "clsituacao";
            this.clsituacao.ReadOnly = true;
            // 
            // clcategoria
            // 
            this.clcategoria.DataPropertyName = "categoria";
            this.clcategoria.HeaderText = "Categoria";
            this.clcategoria.Name = "clcategoria";
            this.clcategoria.Width = 110;
            // 
            // cldescricao
            // 
            this.cldescricao.DataPropertyName = "descricao";
            this.cldescricao.HeaderText = "Descricao";
            this.cldescricao.Name = "cldescricao";
            this.cldescricao.Width = 250;
            // 
            // frmListaApart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 258);
            this.Controls.Add(this.dgvListaApartamentos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaApart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Quartos";
            this.Load += new System.EventHandler(this.frmListaApart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaApartamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaApartamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clleitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldescricao;
    }
}