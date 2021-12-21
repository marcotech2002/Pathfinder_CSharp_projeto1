namespace Exercicio2_clube.View
{
    partial class FormVisualMensalidade
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbMensalidades = new System.Windows.Forms.DataGridView();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.colAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJuros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataPag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDataVenc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbMensalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(86, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(521, 45);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Visualização de mensalidades";
            // 
            // tbMensalidades
            // 
            this.tbMensalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbMensalidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.ColDataVenc,
            this.colValorInicial,
            this.colDataPag,
            this.colJuros,
            this.colValorPago,
            this.colAtivo});
            this.tbMensalidades.Location = new System.Drawing.Point(12, 163);
            this.tbMensalidades.Name = "tbMensalidades";
            this.tbMensalidades.ReadOnly = true;
            this.tbMensalidades.RowHeadersVisible = false;
            this.tbMensalidades.RowHeadersWidth = 51;
            this.tbMensalidades.RowTemplate.Height = 24;
            this.tbMensalidades.Size = new System.Drawing.Size(663, 371);
            this.tbMensalidades.TabIndex = 4;
            this.tbMensalidades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbMensalidades_CellDoubleClick);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(279, 582);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(126, 39);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(12, 111);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(201, 24);
            this.cbxCliente.TabIndex = 25;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(12, 82);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(77, 26);
            this.lblCliente.TabIndex = 26;
            this.lblCliente.Text = "Cliente";
            // 
            // colAtivo
            // 
            this.colAtivo.HeaderText = "Quitada";
            this.colAtivo.MinimumWidth = 6;
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
            this.colAtivo.Width = 60;
            // 
            // colValorPago
            // 
            this.colValorPago.HeaderText = "Valor pago";
            this.colValorPago.MinimumWidth = 6;
            this.colValorPago.Name = "colValorPago";
            this.colValorPago.ReadOnly = true;
            this.colValorPago.Width = 125;
            // 
            // colJuros
            // 
            this.colJuros.HeaderText = "Juros";
            this.colJuros.MinimumWidth = 6;
            this.colJuros.Name = "colJuros";
            this.colJuros.ReadOnly = true;
            this.colJuros.Width = 50;
            // 
            // colDataPag
            // 
            this.colDataPag.HeaderText = "Data do pagamento";
            this.colDataPag.MinimumWidth = 6;
            this.colDataPag.Name = "colDataPag";
            this.colDataPag.ReadOnly = true;
            this.colDataPag.Width = 125;
            // 
            // colValorInicial
            // 
            this.colValorInicial.HeaderText = "Valor";
            this.colValorInicial.MinimumWidth = 6;
            this.colValorInicial.Name = "colValorInicial";
            this.colValorInicial.ReadOnly = true;
            this.colValorInicial.Width = 125;
            // 
            // ColDataVenc
            // 
            this.ColDataVenc.HeaderText = "Vencimento";
            this.ColDataVenc.MinimumWidth = 6;
            this.ColDataVenc.Name = "ColDataVenc";
            this.ColDataVenc.ReadOnly = true;
            this.ColDataVenc.Width = 125;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // FormVisualMensalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 629);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.tbMensalidades);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVisualMensalidade";
            this.Text = "FormVisualMensalidade";
            ((System.ComponentModel.ISupportInitialize)(this.tbMensalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView tbMensalidades;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDataVenc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJuros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtivo;
    }
}