using Entra21.BancoDados01.Ado.Net.Models;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal interface IUnidadesFederativas
    {
        List<UnidadesFederativas> ObterTodos();

        UnidadesFederativas ObterPorId(int id);

        void Cadastrar(UnidadesFederativas unidadesFederativas);

        void Apagar(int id);

        void Editar(UnidadesFederativas unidadesFederativas);
    }
}
