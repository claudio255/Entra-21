using Entra21.BancoDados01.Ado.Net.BancoDados;
using Entra21.BancoDados01.Ado.Net.Models;
using System.Data;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal class UnidadesFederativasService : IUnidadesFederativas
    {
        public void Apagar(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "DELETE FROM unidades_federativas WHERE id = @ID";
            comando.Parameters.AddWithValue("@ID", id);
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        }

        public void Cadastrar(UnidadesFederativas unidadesFederativas)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "INSERT INTO unidades_federativas(nome, sigla) VALUES(@NOME, @SIGLA);";

            comando.Parameters.AddWithValue("@NOME", unidadesFederativas.Nome);
            comando.Parameters.AddWithValue("@SIGLA", unidadesFederativas.Sigla);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public void Editar(UnidadesFederativas unidadesFederativas)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "UPDATE undiades_federativas SET nome = @NOME, sigla = @SIGLA";

            comando.Parameters.AddWithValue("@NOME", unidadesFederativas.Nome);
            comando.Parameters.AddWithValue("@SILGA", unidadesFederativas.Sigla);

            comando.ExecuteNonQuery();

            comando.Connection.Close();
        }

        public UnidadesFederativas ObterPorId(int id)
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = "SELECT id, nome, sigla FROM unidades_federativas WHERE id = @ID";

            comando.Parameters.AddWithValue("@ID", id);

            var dataTable = new DataTable();

            dataTable.Load(comando.ExecuteReader());

            if (dataTable.Rows.Count == 0)
                return null;

            var registro = dataTable.Rows[0];
            var unidadesFederativas = new UnidadesFederativas();
            unidadesFederativas.Id = Convert.ToInt32(registro[0]);
            unidadesFederativas.Nome = registro["nome"].ToString();
            unidadesFederativas.Sigla = registro["sigla"].ToString();

            conexao.Close();

            return unidadesFederativas;
        }

        public List<UnidadesFederativas> ObterTodos()
        {
            var conexao = new Conexao().Conectar();
            var comando = conexao.CreateCommand();
            comando.CommandText = @"SELECT id, nome, sigla
                        FROM unidades_federativas";

            var tabelaEmMemoria = new DataTable();

            tabelaEmMemoria.Load(comando.ExecuteReader());

            var unidadesFederativas = new List<UnidadesFederativas>();

            for(int i = 0; i < tabelaEmMemoria.Rows.Count; i++)
            {
                var linha = tabelaEmMemoria.Rows[i];

                var unidadeFederativa = new UnidadesFederativas();
                unidadeFederativa.Id = Convert.ToInt32(linha["id"].ToString());
                unidadeFederativa.Nome = linha["nome"].ToString();
                unidadeFederativa.Sigla = linha["sigla"].ToString();

                unidadesFederativas.Add(unidadeFederativa);
            }

            conexao.Close();

            return unidadesFederativas;
        }
    }
}
