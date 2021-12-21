using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercicio2_clube.Model;

namespace Exercicio2_clube.Controller
{
    internal class MensalidadeDAO
    {
        //Declaração de atributos globais
        private Conexao conexao = new Conexao();  //Atributos de conexão
        private SqlCommand cmd = new SqlCommand();  //Atributo de comando SQL

        //Método para obter o último id cadastrado de cliente
        public int ObterId()
        {
            String sql = "select max(id_pessoa) from tb_cliente";
            int id = 0;

            try
            {
                cmd.CommandText = sql;
                cmd.Connection = conexao.Conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    id = reader.GetInt32(0);
                }
                reader.Close();
                return id;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return -1;
            }
            finally
            {
                conexao.Desconectar(cmd.Connection);
            }
        }

        //Método para cadastrar mensalidade
        public void CadastrarMensalidade(Mensalidade mensalidade)
        {
            String sql = String.Format("insert into tb_mensalidade (id_pessoa, dtv_mensalidade, vlri_mensalidade, dtp_mensalidade, " +
                "juros_mensalidade, vlrf_mensalidade, quitada_mensalidade) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", 
                mensalidade.Cliente.Id_pessoa, mensalidade.Dtv_mensalidade, mensalidade.Vlri_mensalidade, mensalidade.Dtp_mensalidade, 
                mensalidade.Juros_mensalidade, mensalidade.Vlrf_mensalidade, mensalidade.Quitada_mensalidade);

            cmd.CommandText = sql;

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Mensalidade(s) cadastrada(s) com sucesso!");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Desconectar(cmd.Connection);
            }
        }

        //Método para listar mensalidades
        public List<Mensalidade> ListarMensalidades(int id_pessoa)
        {

            List<Mensalidade> lista = new List<Mensalidade>();
            bool quitada;

            String sql = String.Format("select id_mensalidade, dtv_mensalidade, vlri_mensalidade, dtp_mensalidade, juros_mensalidade, " +
                              "vlrf_mensalidade, quitada_mensalidade\n" +
                              "from tb_mensalidade\n" +
                              "where id_pessoa = '{0}' order by id_mensalidade asc", id_pessoa);

            cmd.Connection = conexao.Conectar();
            cmd.CommandText = sql;

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Mensalidade mensalidade = new Mensalidade();
                    mensalidade.Id_mensalidade = reader.GetInt32(0);
                    mensalidade.Dtv_mensalidade = reader.GetDateTime(1);
                    mensalidade.Vlri_mensalidade = reader.GetDouble(2);
                    mensalidade.Dtp_mensalidade = reader.GetDateTime(3);
                    mensalidade.Juros_mensalidade = reader.GetInt32(4);
                    mensalidade.Vlrf_mensalidade = reader.GetDouble(5);
                    quitada = (bool)reader.GetValue(6);
                    if (quitada)
                        mensalidade.Quitada_mensalidade = 1;
                    else
                        mensalidade.Quitada_mensalidade = 0;
                    lista.Add(mensalidade);
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
                conexao.Desconectar(cmd.Connection);
            }
        }

        //Método para pesquisar por id
        public Mensalidade PesquisarPorId(int id)
        {
            Mensalidade m = new Mensalidade();
            bool quitada;

            String sql = String.Format("select * from tb_mensalidade where id_mensalidade = '{0}'", id);

            cmd.Connection = conexao.Conectar();
            cmd.CommandText = sql;

            try
            {
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    m.Cliente.Id_pessoa = dr.GetInt32(1);
                    m.Dtv_mensalidade = dr.GetDateTime(2);
                    m.Vlri_mensalidade = dr.GetDouble(3);
                    m.Dtp_mensalidade = dr.GetDateTime(4);
                    m.Juros_mensalidade = dr.GetInt32(5);
                    m.Vlrf_mensalidade = dr.GetDouble(6);
                    quitada = (bool)dr.GetValue(7);
                    if (quitada)
                        m.Quitada_mensalidade = 1;
                    else
                        m.Quitada_mensalidade = 0;
                }
                dr.Close();
                return m;
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

        //Método para atualizar mensalidade
        public void AtualizarMensalidade(Mensalidade mensalidade, int id)
        {
            String sql = String.Format("update tb_mensalidade set dtp_mensalidade = '{0}', vlrf_mensalidade = '{1}', " +
                "quitada_mensalidade = '{2}' where id_mensalidade = '{3}'", mensalidade.Dtv_mensalidade, 
                mensalidade.Vlrf_mensalidade, mensalidade.Quitada_mensalidade, id);

            cmd.CommandText = sql;
            cmd.Connection = conexao.Conectar();

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
                conexao.Desconectar(cmd.Connection);
            }
        }

        //Método para verificar se existem mensalidades não quitadas
        public int VerificarMensalidades(int id_pessoa)
        {
            String sql = String.Format("select * from tb_mensalidade where id_pessoa = '{0}' and quitada_mensalidade = 0", id_pessoa);

            cmd.CommandText = sql;
            cmd.Connection = conexao.Conectar();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                    return 1;
                else
                    return 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                return -1;
            }
            finally
            {
                conexao.Desconectar(cmd.Connection);
            }
        }
    }
}
