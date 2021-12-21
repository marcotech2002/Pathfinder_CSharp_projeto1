using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2_clube
{
    public partial class FormVisualClientes : Form
    {
        public FormVisualClientes()
        {
            InitializeComponent();
            this.PreencherTabela();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = e.RowIndex;
            int id = int.Parse(tbClientes.Rows[linha].Cells[0].Value.ToString());

            FormCadastroCliente atu_c = new FormCadastroCliente(id);
            this.Hide();
            atu_c.ShowDialog();
            this.Visible = true;
        }

        private void PreencherTabela()
        {
            List<Cliente> lista = new ClienteDAO().ListarClientes();
            String ativo = "";

            tbClientes.Rows.Clear();
            if (lista != null)
            {
                if (lista.Count > 0)
                {
                    foreach (Cliente obj in lista)
                    {
                        if (obj.Ativo_pessoa == 1)
                            ativo = "Sim";
                        else
                            ativo = "Não";

                        tbClientes.Rows.Add(new object[]
                                {
                                    obj.Id_pessoa,
                                    obj.Nome_pessoa,
                                    obj.Categoria_cliente.Nome_categoria,
                                    obj.Email_pessoa,
                                    obj.Telefone(),
                                    obj.Cep_cliente,
                                    obj.Uf_cliente,
                                    obj.Cidade_cliente,
                                    obj.Bairro_cliente,
                                    obj.Logradouro_cliente,
                                    ativo
                                }
                            );
                    }
                }
                else
                    MessageBox.Show("A tabela não contém dados.");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro!");
            }
        }

        private void FormVisualClientes_VisibleChanged(object sender, EventArgs e)
        {
            this.PreencherTabela();
        }
    }
}
