namespace HopedaJa
{
    partial class frmListaReserva
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaReserva));
            this.dgvListaReserva = new System.Windows.Forms.DataGridView();
            this.clidreserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clidhospede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clidapartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clentrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsaida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cldiarias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clvalortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservaDadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReserva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaReserva
            // 
            this.dgvListaReserva.AllowUserToDeleteRows = false;
            this.dgvListaReserva.AutoGenerateColumns = false;
            this.dgvListaReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaReserva.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clidreserva,
            this.clidhospede,
            this.clidapartamento,
            this.clentrada,
            this.clsaida,
            this.clcategoria,
            this.cldiarias,
            this.clvalortotal});
            this.dgvListaReserva.DataSource = this.reservaDadosBindingSource;
            this.dgvListaReserva.Location = new System.Drawing.Point(6, 7);
            this.dgvListaReserva.Name = "dgvListaReserva";
            this.dgvListaReserva.Size = new System.Drawing.Size(763, 255);
            this.dgvListaReserva.TabIndex = 6;
            this.dgvListaReserva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaReserva_CellContentClick);
            // 
            // clidreserva
            // 
            this.clidreserva.DataPropertyName = "idreserva";
            this.clidreserva.HeaderText = "Código";
            this.clidreserva.Name = "clidreserva";
            this.clidreserva.ReadOnly = true;
            this.clidreserva.Width = 60;
            // 
            // clidhospede
            // 
            this.clidhospede.DataPropertyName = "idhospede";
            this.clidhospede.HeaderText = "Hospede";
            this.clidhospede.Name = "clidhospede";
            this.clidhospede.ReadOnly = true;
            this.clidhospede.Width = 150;
            // 
            // clidapartamento
            // 
            this.clidapartamento.DataPropertyName = "idapartamento";
            this.clidapartamento.HeaderText = "Apartamento";
            this.clidapartamento.Name = "clidapartamento";
            // 
            // clentrada
            // 
            this.clentrada.DataPropertyName = "entrada";
            this.clentrada.HeaderText = "Entrada";
            this.clentrada.Name = "clentrada";
            // 
            // clsaida
            // 
            this.clsaida.DataPropertyName = "saida";
            this.clsaida.HeaderText = "Saída";
            this.clsaida.Name = "clsaida";
            // 
            // clcategoria
            // 
            this.clcategoria.DataPropertyName = "categoria";
            this.clcategoria.HeaderText = "Categoria";
            this.clcategoria.Name = "clcategoria";
            // 
            // cldiarias
            // 
            this.cldiarias.DataPropertyName = "diarias";
            this.cldiarias.HeaderText = "Diárias";
            this.cldiarias.Name = "cldiarias";
            // 
            // clvalortotal
            // 
            this.clvalortotal.DataPropertyName = "valortotal";
            this.clvalortotal.HeaderText = "Total";
            this.clvalortotal.Name = "clvalortotal";
            // 
            // reservaDadosBindingSource
            // 
            this.reservaDadosBindingSource.DataSource = typeof(HopedaJa.reservaDados);
            // 
            // reservasBindingSource
            // 
            this.reservasBindingSource.DataSource = typeof(HopedaJa.reservas);
            // 
            // frmListaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 275);
            this.Controls.Add(this.dgvListaReserva);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListaReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Reservas";
            this.Load += new System.EventHandler(this.frmListaReserva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaReserva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservaDadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListaReserva;
        private System.Windows.Forms.BindingSource reservasBindingSource;
        private System.Windows.Forms.BindingSource reservaDadosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidreserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidhospede;
        private System.Windows.Forms.DataGridViewTextBoxColumn clidapartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clentrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsaida;
        private System.Windows.Forms.DataGridViewTextBoxColumn clcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cldiarias;
        private System.Windows.Forms.DataGridViewTextBoxColumn clvalortotal;
    }
}