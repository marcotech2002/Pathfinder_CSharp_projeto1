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
using Exercicio2_clube.View;

namespace Exercicio2_clube
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new ClienteDAO().ListarCategorias();

            if (dt.Rows.Count > 0)
            {
                FormCadastroCliente cad_c = new FormCadastroCliente();
                this.Hide();
                cad_c.ShowDialog();
                this.Visible = true;
            }
            else
                MessageBox.Show("Não há categorias!");
        }    

        private void dependentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new DependenteDAO().VerificarClientes() == 1)
            {
                FormCadastroDependente cad_d = new FormCadastroDependente();
                this.Hide();
                cad_d.ShowDialog();
                this.Visible = true;
            }
            else
                MessageBox.Show("Cadastro impossibilitado!\nNão há clientes na base de dados");
            
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormVisualClientes visual_c = new FormVisualClientes();
            this.Hide();
            visual_c.ShowDialog();
            this.Visible = true;
        }

        private void dependentesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (new DependenteDAO().VerificarClientes() == 1)
            {
                FormVisualDependentes visual_d = new FormVisualDependentes();
                this.Hide();
                visual_d.ShowDialog();
                this.Visible = true;
            }
            else
                MessageBox.Show("Visualização impossibilitada!\nNão há clientes na base de dados");
        }

        private void mensalidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (new DependenteDAO().VerificarClientes() == 1)
            {
                FormVisualMensalidade visual_m = new FormVisualMensalidade();
                this.Hide();
                visual_m.ShowDialog();
                this.Visible = true;
            }
            else
                MessageBox.Show("Visualização impossibilitada!\nNão há clientes na base de dados");
           
        }
    }
}
