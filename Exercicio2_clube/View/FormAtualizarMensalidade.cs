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
    public partial class FormAtualizarMensalidade : Form
    {
        private int id;
     
        public FormAtualizarMensalidade(int id)
        {
            InitializeComponent();
            this.id = id;

            lblTitulo.Text = "Atualização de clientes";

            Mensalidade m = new MensalidadeDAO().PesquisarPorId(id);
            if(m != null)
            {
                txtDataVenc.Text = m.Dtv_mensalidade.ToString();
                if(m.Quitada_mensalidade == 1)
                {
                    cbxQuitada.SelectedIndex = 1;
                    txtDataPag.Text = m.Dtp_mensalidade.ToString();
                    txtValorFinal.Text = m.Vlrf_mensalidade.ToString();
                }
                else
                {
                    lblDataPag.Visible = false;
                    lblValorFinal.Visible = false;
                    txtDataPag.Visible = false;
                    txtValorFinal.Visible = false;
                }   
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Mensalidade mensalidade = new Mensalidade();
            MensalidadeDAO dao = new MensalidadeDAO();
            String data_v = txtDataVenc.Text;
            double valor = double.Parse(txtValorInicial.Text);
            String data_p;
            int juros = int.Parse(txtJuros.Text.ToString());
            double valor_p;
            int quitada = cbxQuitada.SelectedIndex;

            if (this.Validar(txtDataPag.Text) == false || txtValorFinal.Equals("") || txtValorFinal.Equals("0.00"))
                MessageBox.Show("Campo(s) não preenchido(s)!");
            else
            {
                data_p = txtDataVenc.Text;
                valor_p = this.CalcularValorFinal(valor, juros, this.Converter(data_v), this.Converter(data_p));
                txtValorFinal.Text = valor_p.ToString();

                mensalidade.Dtv_mensalidade = this.Converter(data_v);
                mensalidade.Vlri_mensalidade = valor;
                mensalidade.Dtp_mensalidade = this.Converter(data_p);
                mensalidade.Juros_mensalidade = juros;
                mensalidade.Vlrf_mensalidade = valor_p;
                mensalidade.Quitada_mensalidade = quitada;

                dao.AtualizarMensalidade(mensalidade, this.id);
            }
        }

        private void cbxQuitada_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxQuitada.SelectedIndex == 0)
            {
                lblDataPag.Visible = false;
                lblValorFinal.Visible = false;
                txtDataPag.Visible = false;
                txtValorFinal.Visible = false;
            }
            else
            {
                lblDataPag.Visible = true;
                lblValorFinal.Visible = true;
                txtDataPag.Visible = true;
                txtValorFinal.Visible = true;
            }
        }

        //Converter string para date
        public DateTime Converter(String data_s)
        {
            DateTime data = DateTime.ParseExact(data_s, "dd/MM/yyyy", null);
            return data;
        }

        //Método para calcular o valor final da mensalidade
        public double CalcularValorFinal(double valor_i, int juros, DateTime dt_venc, DateTime dt_pag)
        {
            TimeSpan dias = TimeSpan.FromDays(dt_pag.Subtract(dt_venc).Days);
            int dias_r = dias.Days;

            return valor_i + valor_i * juros * dias_r;
        }

        //Méto para validar data
        public bool Validar(String data)
        {
            return DateTime.TryParse(data, out DateTime data_r);
        }
    }
}
