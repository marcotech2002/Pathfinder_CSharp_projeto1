using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2_clube
{
    internal class ClienteDAO
    {
        //Declaração de atributos globais
        private Conexao conexao = new Conexao();  //Atributos de conexão
        private SqlConnection con;
        private SqlCommand cmd = new SqlCommand();  //Atributo de comando SQL

        //Construtor padrão
        public ClienteDAO()
        {
            this.con = conexao.Conectar();
        }

        //Método para verificar cadastro repetido
        public int VerificarRepetido(Cliente cliente)
        {
            DataTable dt = new DataTable();

            string sql = String.Format("select * from tb_pessoa where nome_pessoa = '{0}'", cliente.Nome_pessoa);

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
        public void CadastrarPessoa(Cliente cliente)
        {
            String sql = String.Format("insert into tb_pessoa (nome_pessoa, email_pessoa, ativo_pessoa) values ('{0}', '{1}'," +
                    " '{2}')", cliente.Nome_pessoa, cliente.Email_pessoa, cliente.Ativo_pessoa);

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
                    cliente.Id_pessoa = int.Parse(reader.GetValue(0).ToString());
                }
                reader.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
        }

        //Método para cadastrar cliente
        public int CadastrarCliente(Cliente cliente)
        {
            if(this.VerificarRepetido(cliente) == 0)
            {
                this.CadastrarPessoa(cliente);

                String sql = String.Format("insert into tb_cliente(id_pessoa, ddd_cliente, telefone_cliente, id_categoria," +
                    " cep_cliente, uf_cliente, cidade_cliente, bairro_cliente, logradouro_cliente) values ('{0}', '{1}', '{2}', " +
                    "'{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", cliente.Id_pessoa, cliente.Ddd_cliente, cliente.Telefone_cliente, 
                    cliente.Categoria_cliente.Id_categoria, cliente.Cep_cliente, cliente.Uf_cliente, cliente.Cidade_cliente,
                    cliente.Bairro_cliente, cliente.Logradouro_cliente);

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
                MessageBox.Show("Cadastro impossibilitado!\nO cliente informado já consta na base de dados");
                conexao.Desconectar(con);
                return 0;
            }
        }

        //Método para listar clientes
        public List<Cliente> ListarClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            bool ativo;

            cmd.CommandText = "select tb_pessoa.id_pessoa, tb_pessoa.nome_pessoa, tb_categoria.nome_categoria, tb_pessoa.email_pessoa, " +
                              "tb_cliente.ddd_cliente, tb_cliente.telefone_cliente, tb_cliente.cep_cliente, tb_cliente.uf_cliente, " +
                              "tb_cliente.cidade_cliente, tb_cliente.bairro_cliente, tb_cliente.logradouro_cliente, " +
                              "tb_pessoa.ativo_pessoa\n" +
                              "from tb_cliente\n" +
                              "inner join tb_pessoa\n" +
                              "     on tb_cliente.id_pessoa = tb_pessoa.id_pessoa\n" +
                              "inner join tb_categoria\n" +
                              "     on tb_cliente.id_categoria = tb_categoria.id_categoria\n" +
                              "order by tb_cliente.id_pessoa asc";

            cmd.Connection = con;

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.Id_pessoa = reader.GetInt32(0);
                    cliente.Nome_pessoa = reader.GetString(1);
                    cliente.Categoria_cliente.Nome_categoria = reader.GetString(2);
                    cliente.Email_pessoa = reader.GetString(3);
                    cliente.Ddd_cliente = int.Parse(reader.GetValue(4).ToString());
                    cliente.Telefone_cliente = reader.GetString(5);
                    cliente.Cep_cliente = reader.GetString(6);
                    cliente.Uf_cliente = reader.GetString(7);
                    cliente.Cidade_cliente = reader.GetString(8);
                    cliente.Bairro_cliente = reader.GetString(9);
                    cliente.Logradouro_cliente = reader.GetString(10);
                    ativo = (bool)reader.GetValue(11);
                    if (ativo)
                        cliente.Ativo_pessoa = 1;
                    else
                        cliente.Ativo_pessoa = 0;
                    lista.Add(cliente);
                }
                reader.Close();
                return lista;
            }
            catch(SqlException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return null;
            }
            finally
            {
                conexao.Desconectar(con);
            }
        }

        //Método para listar categorias 
        public DataTable ListarCategorias()
        {
            DataTable dt = new DataTable();

            cmd.CommandText = "select nome_categoria from tb_categoria order by id_categoria asc";

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
        public Cliente PesquisarPorId(int id)
        {
            Cliente cliente = new Cliente();
            bool ativo;

            String sql = String.Format(cmd.CommandText = "select tb_cliente.id_pessoa, tb_pessoa.nome_pessoa, tb_cliente.id_categoria, tb_pessoa.email_pessoa, " +
                                                         "tb_cliente.ddd_cliente, tb_cliente.telefone_cliente, tb_cliente.cep_cliente, tb_cliente.uf_cliente, " +
                                                         "tb_cliente.cidade_cliente, tb_cliente.bairro_cliente, tb_cliente.logradouro_cliente, " +
                                                         "tb_pessoa.ativo_pessoa\n" +
                                                         "from tb_cliente\n" +
                                                         "inner join tb_pessoa\n" +
                                                         "   on tb_cliente.id_pessoa = tb_pessoa.id_pessoa\n" +
                                                         "where tb_cliente.id_pessoa = '{0}'", id);

            cmd.Connection = con;
            cmd.CommandText = sql;

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cliente.Id_pessoa = reader.GetInt32(0);
                    cliente.Nome_pessoa = reader.GetString(1);
                    cliente.Categoria_cliente.Id_categoria = reader.GetInt32(2);
                    cliente.Email_pessoa = reader.GetString(3);
                    cliente.Ddd_cliente = int.Parse(reader.GetValue(4).ToString());
                    cliente.Telefone_cliente = reader.GetString(5);
                    cliente.Cep_cliente = reader.GetString(6);
                    cliente.Uf_cliente = reader.GetString(7);
                    cliente.Cidade_cliente = reader.GetString(8);
                    cliente.Bairro_cliente = reader.GetString(9);
                    cliente.Logradouro_cliente = reader.GetString(10);
                    ativo = (bool)reader.GetValue(11);
                    if (ativo)
                        cliente.Ativo_pessoa = 1;
                    else
                        cliente.Ativo_pessoa = 0;
                }
                reader.Close();
                return cliente;
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

        //Método para atualizar pessoa
        public void AtualizarPessoa(Cliente cliente, int id)
        {
            String sql = String.Format("update tb_pessoa set nome_pessoa = '{0}', email_pessoa = '{1}', ativo_pessoa = '{2}', " +
                "where id_pessoa = '{3}'", cliente.Nome_pessoa, cliente.Email_pessoa, cliente.Ativo_pessoa, id);

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

        //Método para atualizar cliente
        public void AtualizarCliente(Cliente cliente, int id)
        {
            this.AtualizarPessoa(cliente, id);

            String sql = String.Format("update tb_cliente set id_categoria = '{0}', ddd_cliente = '{1}', telefone_cliente = '{2}', " +
                "cep_cliente = '{3}', uf_cliente = '{4}', cidade_cliente = '{5}', bairro_cliente = '{6}', logradouro_cliente = '{7}', " +
                "where id_pessoa = '{8}'", cliente.Categoria_cliente.Id_categoria, cliente.Ddd_cliente, cliente.Telefone_cliente, 
                cliente.Cep_cliente, cliente.Uf_cliente, cliente.Cidade_cliente, cliente.Bairro_cliente, cliente.Logradouro_cliente, id);

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
