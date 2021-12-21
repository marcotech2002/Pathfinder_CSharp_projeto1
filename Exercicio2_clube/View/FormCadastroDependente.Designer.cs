namespace Exercicio2_clube
{
    partial class FormCadastroDependente
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNomeDependente = new System.Windows.Forms.TextBox();
            this.lblNomeDependente = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblParentesco = new System.Windows.Forms.Label();
            this.cbxParentesco = new System.Windows.Forms.ComboBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.cbxNomeCliente = new System.Windows.Forms.ComboBox();
            this.cbxAtivo = new System.Windows.Forms.ComboBox();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(22, 272);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(294, 34);
            this.txtEmail.TabIndex = 12;
            // 
            // txtNomeDependente
            // 
            this.txtNomeDependente.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeDependente.Location = new System.Drawing.Point(359, 152);
            this.txtNomeDependente.Name = "txtNomeDependente";
            this.txtNomeDependente.Size = new System.Drawing.Size(288, 34);
            this.txtNomeDependente.TabIndex = 9;
            // 
            // lblNomeDependente
            // 
            this.lblNomeDependente.AutoSize = true;
            this.lblNomeDependente.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeDependente.Location = new System.Drawing.Point(354, 110);
            this.lblNomeDependente.Name = "lblNomeDependente";
            this.lblNomeDependente.Size = new System.Drawing.Size(210, 26);
            this.lblNomeDependente.TabIndex = 8;
            this.lblNomeDependente.Text = "Nome do dependente";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(145, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(429, 45);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Cadastro de dependente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "E-mail";
            // 
            // lblParentesco
            // 
            this.lblParentesco.AutoSize = true;
            this.lblParentesco.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentesco.Location = new System.Drawing.Point(354, 225);
            this.lblParentesco.Name = "lblParentesco";
            this.lblParentesco.Size = new System.Drawing.Size(112, 26);
            this.lblParentesco.TabIndex = 14;
            this.lblParentesco.Text = "Parentesco";
            // 
            // cbxParentesco
            // 
            this.cbxParentesco.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxParentesco.FormattingEnabled = true;
            this.cbxParentesco.Items.AddRange(new object[] {
            "Filho(a)",
            "Neto(a)",
            "Irmão(â)"});
            this.cbxParentesco.Location = new System.Drawing.Point(359, 272);
            this.cbxParentesco.Name = "cbxParentesco";
            this.cbxParentesco.Size = new System.Drawing.Size(148, 34);
            this.cbxParentesco.TabIndex = 15;
            this.cbxParentesco.Text = "Filho(a)";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(87, 365);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(126, 39);
            this.btnVoltar.TabIndex = 24;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(505, 365);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(123, 39);
            this.btnCadastrar.TabIndex = 23;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(17, 110);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(164, 26);
            this.lblNomeCliente.TabIndex = 25;
            this.lblNomeCliente.Text = "Nome do cliente";
            // 
            // cbxNomeCliente
            // 
            this.cbxNomeCliente.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNomeCliente.FormattingEnabled = true;
            this.cbxNomeCliente.Location = new System.Drawing.Point(22, 152);
            this.cbxNomeCliente.Name = "cbxNomeCliente";
            this.cbxNomeCliente.Size = new System.Drawing.Size(287, 34);
            this.cbxNomeCliente.TabIndex = 26;
            // 
            // cbxAtivo
            // 
            this.cbxAtivo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAtivo.FormattingEnabled = true;
            this.cbxAtivo.Items.AddRange(new object[] {
            "Não",
            "Sim"});
            this.cbxAtivo.Location = new System.Drawing.Point(575, 272);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.Size = new System.Drawing.Size(72, 34);
            this.cbxAtivo.TabIndex = 30;
            this.cbxAtivo.Text = "Sim";
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtivo.Location = new System.Drawing.Point(570, 225);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(64, 26);
            this.lblAtivo.TabIndex = 29;
            this.lblAtivo.Text = "Ativo";
            // 
            // FormCadastroDependente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 439);
            this.Controls.Add(this.cbxAtivo);
            this.Controls.Add(this.lblAtivo);
            this.Controls.Add(this.cbxNomeCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cbxParentesco);
            this.Controls.Add(this.lblParentesco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNomeDependente);
            this.Controls.Add(this.lblNomeDependente);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroDependente";
            this.Text = "FormCadastroDependente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNomeDependente;
        private System.Windows.Forms.Label lblNomeDependente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblParentesco;
        private System.Windows.Forms.ComboBox cbxParentesco;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.ComboBox cbxNomeCliente;
        private System.Windows.Forms.ComboBox cbxAtivo;
        private System.Windows.Forms.Label lblAtivo;
    }
}