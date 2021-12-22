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

namespace Exercicio2_clube
{
    public partial class FormCadastroDependente : Form
    {
        private int id = 0;

        public FormCadastroDependente()
        {
            InitializeComponent();
            this.ConfigurarComboBox();
        }

        public FormCadastroDependente(int id)
        {
            InitializeComponent();
            this.ConfigurarComboBox();
            lblTitulo.Text = "Atualização de dependente";
            btnCadastrar.Text = "Atualizar";

            this.id = id;
            Dependente antigo = new DependenteDAO().PesquisarPorId(id);
            if(antigo != null)
            {
                txtNomeDependente.Text = antigo.Nome_pessoa;
                txtEmail.Text = antigo.Email_pessoa;
                cbxParentesco.SelectedItem = antigo.Parentesco_dependente;
                cbxAtivo.SelectedIndex = antigo.Ativo_pessoa;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Dependente dependente = new Dependente();
            DependenteDAO dao = new DependenteDAO();
            String nome = txtNomeDependente.Text;
            String email = txtEmail.Text;
            int id = cbxNomeCliente.SelectedIndex + 1;
            String parentesco = cbxParentesco.SelectedItem.ToString();
            int ativo = cbxAtivo.SelectedIndex;

            
            if (nome.Equals("") || email.Equals("") || parentesco.Equals(""))
                MessageBox.Show("Campo(s) não preenchido(s)!");
            else
            {
                dependente.Nome_pessoa = nome;
                dependente.Email_pessoa = email;
                dependente.Cliente.Id_pessoa = id;
                dependente.Parentesco_dependente = parentesco;
                dependente.Ativo_pessoa = ativo;

                if (this.id == 0)
                {
                    if (dao.CadastrarDependente(dependente) == 1)
                    {
                        txtNomeDependente.Text = "";
                        txtEmail.Text = "";
                    }
                    else
                        txtNomeDependente.Text = "";
                }
                else
                    dao.AtualizarDependente(dependente, this.id);
            }
        }

        //Método para carregar os nomes dos clientes
        private void ConfigurarComboBox()
        {
            DataTable dt = new DependenteDAO().ListarClientes();

            if (dt != null)
            {
                foreach (DataRow linha in dt.Rows)
                    cbxNomeCliente.Items.Add(linha[0].ToString());
                cbxNomeCliente.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Ocorreu um erro!");
            }
        }
    }
}
