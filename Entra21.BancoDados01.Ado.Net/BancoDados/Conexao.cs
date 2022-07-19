using System.Data.SqlClient;

namespace Entra21.BancoDados01.Ado.Net.BancoDados
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {
            //Instanciando um objeto da classe SqlConnection, que permitirá fazer selects, inserts, updates, deletes etc....
            SqlConnection conexao = new SqlConnection();

            //string que contém o caminho para o banco de dados, o que permitirá conectar ao banco de dados
            var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Claudio\source\repos\claudio255\Entra-21\Entra21.BancoDados01.Ado.Net\BancoDados\ExercicioDeCasaBanco.mdf;Integrated Security=True;Connect Timeout=30";
            //Definir o cominho da conexão para o SqlConnection
            conexao.ConnectionString = connectionString;

            //Abrir a conexão com o banco de dados
            conexao.Open();

            return conexao;
        }
    }
}
