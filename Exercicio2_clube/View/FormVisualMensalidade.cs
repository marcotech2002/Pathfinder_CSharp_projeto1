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

namespace Exercicio2_clube.View
{
    public partial class FormVisualMensalidade : Form
    {
        public FormVisualMensalidade()
        {
            InitializeComponent();
            this.ConfigurarComboBox();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método para carregar os clientes
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

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.PreencherTabela();
        }

        private void tbMensalidades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = e.RowIndex;
            int id = int.Parse(tbMensalidades.Rows[linha].Cells[0].Value.ToString());

            FormAtualizarMensalidade atu_m = new FormAtualizarMensalidade(id);
            this.Hide();
            atu_m.ShowDialog();
            this.Visible = true;
        }

        private void PreencherTabela()
        {
            List<Mensalidade> lista = new MensalidadeDAO().ListarMensalidades(cbxCliente.SelectedIndex + 1);
            String quitada = "";

            tbMensalidades.Rows.Clear();
            if (lista != null)
            {
                if (lista.Count > 0)
                {
                    foreach (Mensalidade obj in lista)
                    {
                        if (obj.Quitada_mensalidade == 1)
                            quitada = "Sim";
                        else
                            quitada = "Não";

                        tbMensalidades.Rows.Add(new object[]
                                {
                                    obj.Id_mensalidade,
                                    obj.Dtv_mensalidade,
                                    obj.Vlri_mensalidade,
                                    obj.Dtp_mensalidade,
                                    obj.Juros_mensalidade,
                                    obj.Vlrf_mensalidade,
                                    quitada
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
    }
}
