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
            throw new NotImplementedException();
        }

        public void Editar(UnidadesFederativas unidadesFederativas)
        {
            throw new NotImplementedException();
        }

        public UnidadesFederativas ObterPorId(int id)
        {
            throw new NotImplementedException();
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
