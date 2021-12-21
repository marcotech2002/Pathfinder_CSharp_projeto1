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
    public partial class FormVisualDependentes : Form
    {
        public FormVisualDependentes()
        {
            InitializeComponent();
            this.ConfigurarComboBox();
        }

        //Método para carregar as categorias
        private void ConfigurarComboBox()
        {
            DataTable dt = new DependenteDAO().ListarClientes();

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow linha in dt.Rows)
                        cbxCliente.Items.Add(linha[0].ToString());
                }
                else
                    MessageBox.Show("não há clientes.");
            }
            else
            {
                MessageBox.Show("Ocorreu um erro!");
            }
        }

        //Método para preencher a tabela
        public void PreencherTabela()
        {
            List<Dependente> lista = new DependenteDAO().ListarDependentes(cbxCliente.SelectedIndex + 1);
            String ativo = "";

            tbDependentes.Rows.Clear();
            if (lista != null)
            {
                if (lista.Count > 0)
                {
                    foreach (Dependente obj in lista)
                    {
                        if (obj.Ativo_pessoa == 1)
                            ativo = "Sim";
                        else
                            ativo = "Não";

                        tbDependentes.Rows.Add(new object[]
                                {
                                    obj.Id_pessoa,
                                    obj.Nome_pessoa,
                                    obj.Email_pessoa,
                                    obj.Parentesco_dependente,
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

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PreencherTabela();
        }

        private void tbDependentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = e.RowIndex;
            int id = int.Parse(tbDependentes.Rows[linha].Cells[0].Value.ToString());

            FormCadastroCliente atu_d = new FormCadastroCliente(id);
            this.Hide();
            atu_d.ShowDialog();
            this.Visible = true;
        }

        private void tbDependentes_VisibleChanged(object sender, EventArgs e)
        {
            this.PreencherTabela();
        }
    }
}
