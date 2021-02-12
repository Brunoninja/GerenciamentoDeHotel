namespace HopedaJa
{
    partial class frmListaFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaFunc));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvListaFunc = new System.Windows.Forms.DataGridView();
            this.clidfunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldatanasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cltelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clturno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cladmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(205, 263);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(436, 20);
            this.txtNome.TabIndex = 7;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // dgvListaFunc
            // 
            this.dgvListaFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clidfunc,
            this.clnome,
            this.clcpf,
            this.cldatanasc,
            this.cltelefone,
            this.clcargo,
            this.clturno,
            this.cladmissao});
            this.dgvListaFunc.Location = new System.Drawing.Point(2, 2);
            this.dgvListaFunc.Name = "dgvListaFunc";
            this.dgvListaFunc.Size = new System.Drawing.Size(816, 255);
            this.dgvListaFunc.TabIndex = 6;
            this.dgvListaFunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaFunc_CellContentClick);
            // 
            // clidfunc
            // 
            this.clidfunc.DataPropertyName = "idfunc";
            this.clidfunc.HeaderText = "Código";
            this.clidfunc.Name = "clidfunc";
            this.clidfunc.ReadOnly = true;
            this.clidfunc.Width = 70;
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
            // cldatanasc
            // 
            this.cldatanasc.DataPropertyName = "datanasc";
            this.cldatanasc.HeaderText = "Data Nascimento";
            this.cldatanasc.Name = "cldatanasc";
            this.cldatanasc.Width = 90;
            // 
            // cltelefone
            // 
            this.cltelefone.DataPropertyName = "telefone";
            this.cltelefone.HeaderText = "Telefone";
            this.cltelefone.Name = "cltelefone";
            // 
            // clcargo
            // 
            this.clcargo.DataPropertyName = "cargo";
            this.clcargo.HeaderText = "Cargo";
            this.clcargo.Name = "clcargo";
            // 
            // clturno
            // 
            this.clturno.DataPropertyName = "turno";
            this.clturno.HeaderText = "Turno";
            this.clturno.Name = "clturno";
            this.clturno.Width = 60;
            // 
            // cladmissao
            // 
            this.cladmissao.DataPropertyName = "admissao";
            this.cladmissao.HeaderText = "Admissao";
            this.cladmissao.Name = "cladmissao";
            // 
            // frmListaFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 412);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dgvListaFunc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvListaFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidfunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldatanasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clturno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cladmissao;
    }
}