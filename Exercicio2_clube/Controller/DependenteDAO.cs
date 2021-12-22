using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2_clube.Controller
{
    internal class DependenteDAO
    {
        //Declaração de atributos globais
        private Conexao conexao = new Conexao();  //Atributos de conexão
        private SqlConnection con;
        private SqlCommand cmd = new SqlCommand();  //Atributo de comando SQL

        //Construtor padrão
        public DependenteDAO()
        {
            this.con = conexao.Conectar();
        }

        //Método para verificar se há clientes
        public int VerificarClientes()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select * from tb_cliente order by id_pessoa asc";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd.CommandText, con);
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                    return 0;
                else
                    return 1;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return -1;
            }
        }

        //Método para verificar cadastro repetido
        public int VerificarRepetido(Dependente dependente)
        {
            DataTable dt = new DataTable();

            String sql = String.Format("select * from tb_pessoa where nome_pessoa = '{0}'", dependente.Nome_pessoa);

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                    return 0;
                else
                    return 1;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return -1;
            }
        }

        //Método para cadastrar pessoa
        public void CadastrarPessoa(Dependente dependente)
        {
            String sql = String.Format("insert into tb_pessoa (nome_pessoa, email_pessoa, ativo_pessoa) values ('{0}', '{1}'," +
                    " '{2}')", dependente.Nome_pessoa, dependente.Email_pessoa, dependente.Ativo_pessoa);

            String sql2 = "select max(id_pessoa) from tb_pessoa";

            cmd.CommandText = sql;

            try
            {
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                cmd.CommandText = sql2;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dependente.Id_pessoa = int.Parse(reader.GetValue(0).ToString());
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //Método para cadastrar dependente
        public int CadastrarDependente(Dependente dependente)
        {
            if(this.VerificarRepetido(dependente) == 0)
            {
                CadastrarPessoa(dependente);

                String sql = String.Format("insert into tb_dependente (id_pessoa, id_cliente, parentesco_dependente) values " +
                    "('{0}', '{1}', '{2}')", dependente.Id_pessoa, dependente.Cliente.Id_pessoa, dependente.Parentesco_dependente);

                cmd.CommandText = sql;

                try
                {
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso!");
                    return 1;
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                    return -1;
                }
                finally
                {
                    conexao.Desconectar(con);
                }
            }
            else
            {
                MessageBox.Show("Cadastro impossibilitado!\nO dependente informado já consta na base de dados");
                conexao.Desconectar(con);
                return 0;
            }
        }

        //Método para listar dependentes
        public List<Dependente> ListarDependentes(int id_cliente)
        {
            List<Dependente> lista = new List<Dependente>();
            bool ativo;

            String sql = String.Format("select tb_pessoa.id_pessoa, tb_pessoa.nome_pessoa, tb_pessoa.email_pessoa, tb_dependente.parentesco_dependente, " +
                              "tb_pessoa.ativo_pessoa\n" +
                              "from tb_dependente\n" +
                              "inner join tb_pessoa\n" +
                              "     on tb_dependente.id_pessoa = tb_pessoa.id_pessoa\n" +
                              "where tb_dependente.id_cliente = '{0}' order by tb_dependente.is_pessoa asc", id_cliente);

            cmd.CommandText = sql;
            cmd.Connection = con;

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Dependente dependente = new Dependente();
                    dependente.Id_pessoa = reader.GetInt32(0);
                    dependente.Nome_pessoa = reader.GetString(1);
                    dependente.Email_pessoa = reader.GetString(2);
                    dependente.Parentesco_dependente = reader.GetString(3);
                    ativo = (bool)reader.GetValue(11);
                    if (ativo)
                        dependente.Ativo_pessoa = 1;
                    else
                        dependente.Ativo_pessoa = 0;
                    lista.Add(dependente);
                }
                reader.Close();
                return lista;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return null;
            }
            finally
            {
                conexao.Desconectar(con);
            }
        }

        //Método para listar os clientes
        public DataTable ListarClientes()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select tb_pessoa.nome_pessoa " +
                              "from tb_pessoa\n" +
                              "inner join tb_cliente\n" +
                              "     on tb_cliente.id_pessoa = tb_pessoa.id_pessoa\n" +
                              "where tb_pessoa.ativo_pessoa = 1 order by tb_cliente.id_pessoa asc";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd.CommandText, con);
                adapter.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return null;
            }
            finally
            {
                conexao.Desconectar(con);
            }
        }

        //Método para pesquisar por id
        public Dependente PesquisarPorId(int id)
        {
            Dependente d = new Dependente();
            bool ativo;

            String sql = String.Format("select tb_pessoa.id_pessoa, tb_pessoa.nome_pessoa, tb_pessoa.email_pessoa, " +
                              "tb_dependente.parentesco_dependente tb_pessoa.ativo_pessoa\n" +
                              "from tb_dependente\n" +
                              "inner join tb_pessoa\n" +
                              "     on tb_dependente.id_pessoa = tb_pessoa.id_pessoa\n" +
                              "where tb_pessoa.id_pessoa = '{0}'", id);

            cmd.Connection = conexao.Conectar();
            cmd.CommandText = sql;

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Dependente dependente = new Dependente();
                    dependente.Id_pessoa = reader.GetInt32(0);
                    dependente.Nome_pessoa = reader.GetString(1);
                    dependente.Email_pessoa = reader.GetString(2);
                    dependente.Parentesco_dependente = reader.GetString(3);
                    ativo = (bool)reader.GetValue(11);
                    if (ativo)
                        dependente.Ativo_pessoa = 1;
                    else
                        dependente.Ativo_pessoa = 0;
                }
                reader.Close();
                return d;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return null;
            }
            finally
            {
                conexao.Desconectar(cmd.Connection);
            }
        }

        //Método para atualizar pessoa
        public void AtualizarPessoa(Dependente dependente, int id)
        {
            String sql = String.Format("update tb_pessoa set nome_pessoa = '{0}', email_pessoa = '{1}', ativo_pessoa = '{2}', " +
                "where id_pessoa = '{3}'", dependente.Nome_pessoa, dependente.Email_pessoa, dependente.Ativo_pessoa, id);

            cmd.CommandText = sql;
            cmd.Connection = con;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //Método para atualizar dependente
        public void AtualizarDependente(Dependente dependente , int id)
        {
            AtualizarPessoa(dependente, id);

            String sql = String.Format("update tb_dependente set id_cliente = '{0}', parentesco_dependente = '{1}', " +
                "quitada_mensalidade = '{2}' where id_pessoa = '{3}'", dependente.Cliente.Id_pessoa,
                dependente.Parentesco_dependente, dependente.Ativo_pessoa, id);

            cmd.CommandText = sql;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Atualização efetuada com sucesso.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Desconectar(con);
            }
        }
    }
}
