namespace Exercicio2_clube.View
{
    partial class FormAtualizarMensalidade
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
            this.lblDataVenc = new System.Windows.Forms.Label();
            this.txtDataVenc = new System.Windows.Forms.MaskedTextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValorInicial = new System.Windows.Forms.TextBox();
            this.txtDataPag = new System.Windows.Forms.MaskedTextBox();
            this.lblDataPag = new System.Windows.Forms.Label();
            this.lblJuros = new System.Windows.Forms.Label();
            this.lblValorFinal = new System.Windows.Forms.Label();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.cbxQuitada = new System.Windows.Forms.ComboBox();
            this.lblQuitada = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(122, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(449, 45);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Cadastro de mensalidade";
            // 
            // lblDataVenc
            // 
            this.lblDataVenc.AutoSize = true;
            this.lblDataVenc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataVenc.Location = new System.Drawing.Point(27, 103);
            this.lblDataVenc.Name = "lblDataVenc";
            this.lblDataVenc.Size = new System.Drawing.Size(196, 26);
            this.lblDataVenc.TabIndex = 27;
            this.lblDataVenc.Text = "Data de vencimento";
            // 
            // txtDataVenc
            // 
            this.txtDataVenc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataVenc.Location = new System.Drawing.Point(32, 145);
            this.txtDataVenc.Mask = "00/00/0000";
            this.txtDataVenc.Name = "txtDataVenc";
            this.txtDataVenc.ReadOnly = true;
            this.txtDataVenc.Size = new System.Drawing.Size(131, 34);
            this.txtDataVenc.TabIndex = 28;
            this.txtDataVenc.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(265, 103);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(103, 26);
            this.lblValor.TabIndex = 29;
            this.lblValor.Text = "Valor(R$)";
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorInicial.Location = new System.Drawing.Point(270, 145);
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.ReadOnly = true;
            this.txtValorInicial.Size = new System.Drawing.Size(101, 34);
            this.txtValorInicial.TabIndex = 30;
            this.txtValorInicial.Text = "155.00";
            // 
            // txtDataPag
            // 
            this.txtDataPag.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPag.Location = new System.Drawing.Point(195, 256);
            this.txtDataPag.Mask = "00/00/0000";
            this.txtDataPag.Name = "txtDataPag";
            this.txtDataPag.Size = new System.Drawing.Size(131, 34);
            this.txtDataPag.TabIndex = 32;
            this.txtDataPag.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // lblDataPag
            // 
            this.lblDataPag.AutoSize = true;
            this.lblDataPag.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPag.Location = new System.Drawing.Point(190, 214);
            this.lblDataPag.Name = "lblDataPag";
            this.lblDataPag.Size = new System.Drawing.Size(191, 26);
            this.lblDataPag.TabIndex = 31;
            this.lblDataPag.Text = "Data do pagamento";
            // 
            // lblJuros
            // 
            this.lblJuros.AutoSize = true;
            this.lblJuros.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuros.Location = new System.Drawing.Point(448, 100);
            this.lblJuros.Name = "lblJuros";
            this.lblJuros.Size = new System.Drawing.Size(225, 26);
            this.lblJuros.TabIndex = 33;
            this.lblJuros.Text = "Percentual de juros(%)";
            // 
            // lblValorFinal
            // 
            this.lblValorFinal.AutoSize = true;
            this.lblValorFinal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorFinal.Location = new System.Drawing.Point(448, 211);
            this.lblValorFinal.Name = "lblValorFinal";
            this.lblValorFinal.Size = new System.Drawing.Size(151, 26);
            this.lblValorFinal.TabIndex = 35;
            this.lblValorFinal.Text = "Valor final(R$)";
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFinal.Location = new System.Drawing.Point(453, 256);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.ReadOnly = true;
            this.txtValorFinal.Size = new System.Drawing.Size(96, 34);
            this.txtValorFinal.TabIndex = 36;
            // 
            // cbxQuitada
            // 
            this.cbxQuitada.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxQuitada.FormattingEnabled = true;
            this.cbxQuitada.Items.AddRange(new object[] {
            "Não",
            "Sim"});
            this.cbxQuitada.Location = new System.Drawing.Point(32, 256);
            this.cbxQuitada.Name = "cbxQuitada";
            this.cbxQuitada.Size = new System.Drawing.Size(72, 34);
            this.cbxQuitada.TabIndex = 38;
            this.cbxQuitada.Text = "Não";
            this.cbxQuitada.SelectedIndexChanged += new System.EventHandler(this.cbxQuitada_SelectedIndexChanged);
            // 
            // lblQuitada
            // 
            this.lblQuitada.AutoSize = true;
            this.lblQuitada.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuitada.Location = new System.Drawing.Point(27, 212);
            this.lblQuitada.Name = "lblQuitada";
            this.lblQuitada.Size = new System.Drawing.Size(85, 26);
            this.lblQuitada.TabIndex = 37;
            this.lblQuitada.Text = "Quitada";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(81, 379);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(126, 39);
            this.btnVoltar.TabIndex = 40;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Location = new System.Drawing.Point(496, 379);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(123, 39);
            this.btnAtualizar.TabIndex = 39;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtJuros
            // 
            this.txtJuros.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJuros.Location = new System.Drawing.Point(453, 145);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.ReadOnly = true;
            this.txtJuros.Size = new System.Drawing.Size(38, 34);
            this.txtJuros.TabIndex = 41;
            this.txtJuros.Text = "8";
            // 
            // FormAtualizarMensalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.txtJuros);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.cbxQuitada);
            this.Controls.Add(this.lblQuitada);
            this.Controls.Add(this.txtValorFinal);
            this.Controls.Add(this.lblValorFinal);
            this.Controls.Add(this.lblJuros);
            this.Controls.Add(this.txtDataPag);
            this.Controls.Add(this.lblDataPag);
            this.Controls.Add(this.txtValorInicial);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtDataVenc);
            this.Controls.Add(this.lblDataVenc);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAtualizarMensalidade";
            this.Text = "FormCadastroMensalidade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDataVenc;
        private System.Windows.Forms.MaskedTextBox txtDataVenc;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValorInicial;
        private System.Windows.Forms.MaskedTextBox txtDataPag;
        private System.Windows.Forms.Label lblDataPag;
        private System.Windows.Forms.Label lblJuros;
        private System.Windows.Forms.Label lblValorFinal;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.ComboBox cbxQuitada;
        private System.Windows.Forms.Label lblQuitada;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox txtJuros;
    }
}