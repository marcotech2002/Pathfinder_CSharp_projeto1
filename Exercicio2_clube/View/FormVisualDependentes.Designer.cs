namespace Exercicio2_clube
{
    partial class FormVisualDependentes
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbDependentes = new System.Windows.Forms.DataGridView();
            this.colNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idpessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idclienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentescodependenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbdependenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLUBEDataSet = new Exercicio2_clube.CLUBEDataSet();
            this.tb_dependenteTableAdapter = new Exercicio2_clube.CLUBEDataSetTableAdapters.tb_dependenteTableAdapter();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbDependentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdependenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLUBEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(93, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(501, 45);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Visualização de dependentes";
            // 
            // tbDependentes
            // 
            this.tbDependentes.AutoGenerateColumns = false;
            this.tbDependentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbDependentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumero,
            this.colNome,
            this.colEmail,
            this.colCliente,
            this.colAtivo,
            this.idpessoaDataGridViewTextBoxColumn,
            this.idclienteDataGridViewTextBoxColumn,
            this.parentescodependenteDataGridViewTextBoxColumn});
            this.tbDependentes.DataSource = this.tbdependenteBindingSource;
            this.tbDependentes.Location = new System.Drawing.Point(12, 156);
            this.tbDependentes.Name = "tbDependentes";
            this.tbDependentes.ReadOnly = true;
            this.tbDependentes.RowHeadersVisible = false;
            this.tbDependentes.RowHeadersWidth = 51;
            this.tbDependentes.RowTemplate.Height = 24;
            this.tbDependentes.Size = new System.Drawing.Size(659, 429);
            this.tbDependentes.TabIndex = 3;
            this.tbDependentes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbDependentes_CellDoubleClick);
            this.tbDependentes.VisibleChanged += new System.EventHandler(this.tbDependentes_VisibleChanged);
            // 
            // colNumero
            // 
            this.colNumero.HeaderText = "Número do cartão";
            this.colNumero.MinimumWidth = 6;
            this.colNumero.Name = "colNumero";
            this.colNumero.ReadOnly = true;
            this.colNumero.Width = 125;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.MinimumWidth = 6;
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 160;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "E-mail";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 160;
            // 
            // colCliente
            // 
            this.colCliente.HeaderText = "Parentesco";
            this.colCliente.MinimumWidth = 6;
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            this.colCliente.Width = 160;
            // 
            // colAtivo
            // 
            this.colAtivo.HeaderText = "Ativo";
            this.colAtivo.MinimumWidth = 6;
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
            this.colAtivo.Width = 50;
            // 
            // idpessoaDataGridViewTextBoxColumn
            // 
            this.idpessoaDataGridViewTextBoxColumn.DataPropertyName = "id_pessoa";
            this.idpessoaDataGridViewTextBoxColumn.HeaderText = "id_pessoa";
            this.idpessoaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idpessoaDataGridViewTextBoxColumn.Name = "idpessoaDataGridViewTextBoxColumn";
            this.idpessoaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpessoaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idclienteDataGridViewTextBoxColumn
            // 
            this.idclienteDataGridViewTextBoxColumn.DataPropertyName = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.HeaderText = "id_cliente";
            this.idclienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idclienteDataGridViewTextBoxColumn.Name = "idclienteDataGridViewTextBoxColumn";
            this.idclienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclienteDataGridViewTextBoxColumn.Width = 125;
            // 
            // parentescodependenteDataGridViewTextBoxColumn
            // 
            this.parentescodependenteDataGridViewTextBoxColumn.DataPropertyName = "parentesco_dependente";
            this.parentescodependenteDataGridViewTextBoxColumn.HeaderText = "parentesco_dependente";
            this.parentescodependenteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.parentescodependenteDataGridViewTextBoxColumn.Name = "parentescodependenteDataGridViewTextBoxColumn";
            this.parentescodependenteDataGridViewTextBoxColumn.ReadOnly = true;
            this.parentescodependenteDataGridViewTextBoxColumn.Width = 125;
            // 
            // tbdependenteBindingSource
            // 
            this.tbdependenteBindingSource.DataMember = "tb_dependente";
            this.tbdependenteBindingSource.DataSource = this.cLUBEDataSet;
            // 
            // cLUBEDataSet
            // 
            this.cLUBEDataSet.DataSetName = "CLUBEDataSet";
            this.cLUBEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_dependenteTableAdapter
            // 
            this.tb_dependenteTableAdapter.ClearBeforeFill = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(280, 606);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(126, 39);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(12, 82);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(77, 26);
            this.lblCliente.TabIndex = 28;
            this.lblCliente.Text = "Cliente";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(12, 111);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(201, 24);
            this.cbxCliente.TabIndex = 27;
            this.cbxCliente.SelectedIndexChanged += new System.EventHandler(this.cbxCliente_SelectedIndexChanged);
            // 
            // FormVisualDependentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 657);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.tbDependentes);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVisualDependentes";
            this.Text = "FormVisualDependentes";
            ((System.ComponentModel.ISupportInitialize)(this.tbDependentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbdependenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLUBEDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView tbDependentes;
        private CLUBEDataSet cLUBEDataSet;
        private System.Windows.Forms.BindingSource tbdependenteBindingSource;
        private CLUBEDataSetTableAdapters.tb_dependenteTableAdapter tb_dependenteTableAdapter;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentescodependenteDataGridViewTextBoxColumn;
    }
}