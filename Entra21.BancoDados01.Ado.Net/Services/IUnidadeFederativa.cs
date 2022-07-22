using Entra21.BancoDados01.Ado.Net.Models;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal interface IUnidadeFederativa
    {
        List<UnidadeFederativa> ObterTodos();

        UnidadeFederativa ObterPorId(int id);

        void Cadastrar(UnidadeFederativa unidadesFederativas);

        void Apagar(int id);

        void Editar(UnidadeFederativa unidadesFederativas);
    }
}
