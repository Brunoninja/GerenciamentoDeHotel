namespace HopedaJa
{
    partial class frmListaHospede
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaHospede));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvListaHospede = new System.Windows.Forms.DataGridView();
            this.clidhospede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clendereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaHospede)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(160, 273);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(436, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // dgvListaHospede
            // 
            this.dgvListaHospede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaHospede.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clidhospede,
            this.clnome,
            this.clcpf,
            this.clendereco,
            this.clcidade,
            this.clestado,
            this.cltelefone});
            this.dgvListaHospede.Location = new System.Drawing.Point(0, 12);
            this.dgvListaHospede.Name = "dgvListaHospede";
            this.dgvListaHospede.Size = new System.Drawing.Size(728, 255);
            this.dgvListaHospede.TabIndex = 4;
            this.dgvListaHospede.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaHospede_CellContentClick);
            // 
            // clidhospede
            // 
            this.clidhospede.DataPropertyName = "idhospede";
            this.clidhospede.HeaderText = "Código";
            this.clidhospede.Name = "clidhospede";
            this.clidhospede.ReadOnly = true;
            this.clidhospede.Width = 60;
            // 
            // clnome
            // 
            this.clnome.DataPropertyName = "nome";
            this.clnome.HeaderText = "Nome";
            this.clnome.Name = "clnome";
            this.clnome.ReadOnly = true;
            this.clnome.Width = 150;
            // 
            // clcpf
            // 
            this.clcpf.DataPropertyName = "cpf";
            this.clcpf.HeaderText = "CPF";
            this.clcpf.Name = "clcpf";
            this.clcpf.ReadOnly = true;
            // 
            // clendereco
            // 
            this.clendereco.DataPropertyName = "endereco";
            this.clendereco.HeaderText = "Endereço";
            this.clendereco.Name = "clendereco";
            this.clendereco.Width = 110;
            // 
            // clcidade
            // 
            this.clcidade.DataPropertyName = "cidade";
            this.clcidade.HeaderText = "Cidade";
            this.clcidade.Name = "clcidade";
            // 
            // clestado
            // 
            this.clestado.DataPropertyName = "estado";
            this.clestado.HeaderText = "Estado";
            this.clestado.Name = "clestado";
            this.clestado.Width = 60;
            // 
            // cltelefone
            // 
            this.cltelefone.DataPropertyName = "telefone";
            this.cltelefone.HeaderText = "Telefone";
            this.cltelefone.Name = "cltelefone";
            // 
            // frmListaHospede
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 334);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvListaHospede);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaHospede";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Hospedes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaHospede)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvListaHospede;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidhospede;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clendereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltelefone;
    }
}