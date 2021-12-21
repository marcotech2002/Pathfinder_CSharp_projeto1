using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercicio2_clube.Controller;
using Exercicio2_clube.Model;

namespace Exercicio2_clube
{
    public partial class FormCadastroCliente : Form
    {
        private int id = 0;

        public FormCadastroCliente()
        {
            InitializeComponent();
            this.ConfigurarComboBox();
        }

        public FormCadastroCliente(int id)
        {
            InitializeComponent();
            this.ConfigurarComboBox();
            this.id = id;

            lblTitulo.Text = "Atualização de clientes";

            Cliente c = new ClienteDAO().PesquisarPorId(id);
            if(c != null)
            {
                txtNome.Text = c.Nome_pessoa;
                txtEmail.Text = c.Email_pessoa;
                cbxDdd.SelectedItem = c.Ddd_cliente.ToString();
                txtTelefone.Text = c.Telefone_cliente;
                cbxCategoria.SelectedIndex = c.Categoria_cliente.Id_categoria - 1;
                txtCep.Text = c.Cep_cliente;
                cbxUf.SelectedItem = c.Uf_cliente;
                cbxCidade.SelectedItem = c.Cidade_cliente;
                txtBairro.Text = c.Bairro_cliente;
                txtLog.Text = c.Logradouro_cliente;
                cbxAtivo.SelectedIndex = c.Ativo_pessoa;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteDAO dao = new ClienteDAO();
            MensalidadeDAO dao2 = new MensalidadeDAO();
            int i = 0;
            String nome = txtNome.Text;
            String email = txtEmail.Text;
            int ddd = int.Parse(cbxDdd.SelectedItem.ToString());
            String telefone = txtTelefone.Text;
            String cep = txtCep.Text;
            int categoria = cbxCategoria.SelectedIndex + 1;
            String uf = (string)cbxUf.SelectedItem;
            String cidade = (string)cbxCidade.SelectedItem;
            String bairro = txtBairro.Text;
            String logradouro = txtLog.Text;
            int ativo = cbxAtivo.SelectedIndex;

            if(id == 0)
            {
                if (nome.Equals("") || email.Equals("") || telefone.Equals("") || cep.Equals("") || bairro.Equals("") || logradouro.Equals(""))
                    MessageBox.Show("Campo(s) não preenchido(s)!");
                else
                {
                    cliente.Nome_pessoa = nome;
                    cliente.Email_pessoa = email;
                    cliente.Ddd_cliente = ddd;
                    cliente.Telefone_cliente = telefone;
                    cliente.Categoria_cliente.Id_categoria = categoria;
                    cliente.Cep_cliente = cep;
                    cliente.Uf_cliente = uf;
                    cliente.Cidade_cliente = cidade;
                    cliente.Bairro_cliente = bairro;
                    cliente.Logradouro_cliente = logradouro;
                    cliente.Ativo_pessoa = ativo;

                    if (dao.CadastrarCliente(cliente) == 1)
                    {
                        int id_pessoa = dao2.ObterId();

                        if (categoria == 1)
                        {
                            Mensalidade m = new Mensalidade();
                            m.Cliente.Id_pessoa = id_pessoa;
                            m.Dtv_mensalidade = this.DefinirVencimento(1);
                            m.Vlri_mensalidade = 155.00;
                            m.Dtp_mensalidade = m.Dtv_mensalidade;
                            m.Juros_mensalidade = 8;
                            m.Vlrf_mensalidade = 0.00;
                            m.Quitada_mensalidade = 0;

                            dao2.CadastrarMensalidade(m);
                        }
                        else if (categoria == 2)
                        {
                            for (i = 1; i <= 3; i++)
                            {
                                Mensalidade m = new Mensalidade();
                                m.Cliente.Id_pessoa = id_pessoa;
                                m.Dtv_mensalidade = this.DefinirVencimento(i);
                                m.Vlri_mensalidade = 155.00;
                                m.Dtp_mensalidade = m.Dtv_mensalidade;
                                m.Juros_mensalidade = 8;
                                m.Vlrf_mensalidade = 0.00;
                                m.Quitada_mensalidade = 0;

                                dao2.CadastrarMensalidade(m);
                            }
                        }
                        else if (categoria == 3)
                        {
                            for (i = 1; i <= 6; i++)
                            {
                                Mensalidade m = new Mensalidade();
                                m.Cliente.Id_pessoa = id_pessoa;
                                m.Dtv_mensalidade = this.DefinirVencimento(i);
                                m.Vlri_mensalidade = 155.00;
                                m.Dtp_mensalidade = m.Dtv_mensalidade;
                                m.Juros_mensalidade = 8;
                                m.Vlrf_mensalidade = 0.00;
                                m.Quitada_mensalidade = 0;

                                dao2.CadastrarMensalidade(m);
                            }
                        }
                        else
                        {
                            for (i = 1; i <= 12; i++)
                            {
                                Mensalidade m = new Mensalidade();
                                m.Cliente.Id_pessoa = id_pessoa;
                                m.Dtv_mensalidade = this.DefinirVencimento(i);
                                m.Vlri_mensalidade = 155.00;
                                m.Dtp_mensalidade = m.Dtv_mensalidade;
                                m.Juros_mensalidade = 8;
                                m.Vlrf_mensalidade = 0.00;
                                m.Quitada_mensalidade = 0;

                                dao2.CadastrarMensalidade(m);
                            }
                        }

                        txtNome.Text = "";
                        txtEmail.Text = "";
                        txtTelefone.Text = "";
                        txtCep.Text = "";
                        txtBairro.Text = "";
                        txtLog.Text = "";
                    }
                    else
                        txtNome.Text = "";
                }
            }
            else
            {
                if (nome.Equals("") || email.Equals("") || telefone.Equals("") || cep.Equals("") || bairro.Equals("") || logradouro.Equals(""))
                    MessageBox.Show("Campo(s) não preenchido(s)!");
                cliente.Nome_pessoa = txtNome.Text;
                {
                    cliente.Email_pessoa = txtEmail.Text;
                    cliente.Ddd_cliente = int.Parse(cbxDdd.SelectedItem.ToString());
                    cliente.Telefone_cliente = txtTelefone.Text;
                    cliente.Cep_cliente = txtCep.Text;
                    cliente.Categoria_cliente.Id_categoria = cbxCategoria.SelectedIndex + 1;
                    cliente.Uf_cliente = (string)cbxUf.SelectedItem;
                    cliente.Cidade_cliente = (string)cbxCidade.SelectedItem;
                    cliente.Bairro_cliente = txtBairro.Text;
                    cliente.Logradouro_cliente = txtLog.Text;
                    cliente.Ativo_pessoa = cbxAtivo.SelectedIndex;

                    if (cliente.Categoria_cliente.Id_categoria != categoria)
                    {
                        dao.AtualizarCliente(cliente, this.id);

                        if(cliente.Categoria_cliente.Id_categoria > categoria)
                        {
                            if(cliente.Categoria_cliente.Id_categoria == 2)
                            {
                                for (i = 2; i <= 3; i++)
                                {
                                    Mensalidade m = new Mensalidade();
                                    m.Cliente.Id_pessoa = this.id;
                                    m.Dtv_mensalidade = this.DefinirVencimento(i);
                                    m.Vlri_mensalidade = 155.00;
                                    m.Dtp_mensalidade = m.Dtv_mensalidade;
                                    m.Juros_mensalidade = 8;
                                    m.Vlrf_mensalidade = 0.00;
                                    m.Quitada_mensalidade = 0;

                                    dao2.CadastrarMensalidade(m);
                                }
                            }
                            else if (cliente.Categoria_cliente.Id_categoria == 3)
                            {
                                if(categoria == 1)
                                {
                                    for (i = 2; i <= 6; i++)
                                    {
                                        Mensalidade m = new Mensalidade();
                                        m.Cliente.Id_pessoa = this.id;
                                        m.Dtv_mensalidade = this.DefinirVencimento(i);
                                        m.Vlri_mensalidade = 155.00;
                                        m.Dtp_mensalidade = m.Dtv_mensalidade;
                                        m.Juros_mensalidade = 8;
                                        m.Vlrf_mensalidade = 0.00;
                                        m.Quitada_mensalidade = 0;

                                        dao2.CadastrarMensalidade(m);
                                    }
                                }
                                else
                                {
                                    for (i = 4; i <= 6; i++)
                                    {
                                        Mensalidade m = new Mensalidade();
                                        m.Cliente.Id_pessoa = this.id;
                                        m.Dtv_mensalidade = this.DefinirVencimento(i);
                                        m.Vlri_mensalidade = 155.00;
                                        m.Dtp_mensalidade = m.Dtv_mensalidade;
                                        m.Juros_mensalidade = 8;
                                        m.Vlrf_mensalidade = 0.00;
                                        m.Quitada_mensalidade = 0;

                                        dao2.CadastrarMensalidade(m);
                                    }
                                }
                            }
                            else
                            {
                                if(categoria == 1)
                                {
                                    for (i = 2; i <= 12; i++)
                                    {
                                        Mensalidade m = new Mensalidade();
                                        m.Cliente.Id_pessoa = this.id;
                                        m.Dtv_mensalidade = this.DefinirVencimento(i);
                                        m.Vlri_mensalidade = 155.00;
                                        m.Dtp_mensalidade = m.Dtv_mensalidade;
                                        m.Juros_mensalidade = 8;
                                        m.Vlrf_mensalidade = 0.00;
                                        m.Quitada_mensalidade = 0;

                                        dao2.CadastrarMensalidade(m);
                                    }
                                }
                                else if (categoria == 2)
                                {
                                    for (i = 4; i <= 12; i++)
                                    {
                                        Mensalidade m = new Mensalidade();
                                        m.Cliente.Id_pessoa = this.id;
                                        m.Dtv_mensalidade = this.DefinirVencimento(i);
                                        m.Vlri_mensalidade = 155.00;
                                        m.Dtp_mensalidade = m.Dtv_mensalidade;
                                        m.Juros_mensalidade = 8;
                                        m.Vlrf_mensalidade = 0.00;
                                        m.Quitada_mensalidade = 0;

                                        dao2.CadastrarMensalidade(m);
                                    }
                                }
                                else
                                {
                                    for (i = 7; i <= 12; i++)
                                    {
                                        Mensalidade m = new Mensalidade();
                                        m.Cliente.Id_pessoa = this.id;
                                        m.Dtv_mensalidade = this.DefinirVencimento(i);
                                        m.Vlri_mensalidade = 155.00;
                                        m.Dtp_mensalidade = m.Dtv_mensalidade;
                                        m.Juros_mensalidade = 8;
                                        m.Vlrf_mensalidade = 0.00;
                                        m.Quitada_mensalidade = 0;

                                        dao2.CadastrarMensalidade(m);
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (cliente.Categoria_cliente.Id_categoria == 1)
                            {

                            }
                            else if (cliente.Categoria_cliente.Id_categoria == 2)
                            {

                            }
                            else
                            {

                            }
                        }
                    }
                    else
                    {
                        dao.AtualizarCliente(cliente, this.id);
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxDdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDdd.SelectedIndex == 0)
                cbxCidade.SelectedIndex = 1;
            else if (cbxDdd.SelectedIndex == 1)
                cbxCidade.SelectedIndex = 0;
            else
                cbxCidade.SelectedIndex = 2;  
        }

        private void cbxCidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCidade.SelectedIndex == 0)
                cbxDdd.SelectedIndex = 1;
            else if (cbxDdd.SelectedIndex == 1)
                cbxDdd.SelectedIndex = 0;
            else
                cbxDdd.SelectedIndex = 2;
        }


        //Método para carregar as categorias
        private void ConfigurarComboBox()
        {
            DataTable dt = new ClienteDAO().ListarCategorias();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow linha in dt.Rows)
                        cbxCategoria.Items.Add(linha[0].ToString());
                    cbxCategoria.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Ocorreu um erro!");
            }
        }

        //Definir a data de vencimento 
        public DateTime DefinirVencimento(int mes)
        {
            DateTime data_atual = DateTime.Today;
            DateTime data_venc = data_atual.AddMonths(mes);
            String data_venc_s = data_venc.ToString("dd/MM/yyyy");
            data_venc = DateTime.ParseExact(data_venc_s, "d", null);
            return data_venc;
        }
    }
}
