using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2_clube
{
    internal class Conexao
    {
        //Declaração de atributos
        SqlConnection con = new SqlConnection();

        //Construtor padrão
        public Conexao()
        {
            con.ConnectionString = "Data Source=DESKTOP-Q303FT3;Initial Catalog=CLUBE;Integrated Security=True";
        }

        //Método para iniciar uma conexão
        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open(); 

            return con;
        }

        //Método para finalizar uma conexão
        public void Desconectar(SqlConnection con)
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }
    }
}
