using Entra21.BancoDados01.Ado.Net.Models;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal interface ICidadeService
    {
        List<Cidade> ObterTodas();

        Cidade ObterPorId(int id);

        void Cadastrar(Cidade cidades);

        void Editar(Cidade cidades);

        void Apagar(int id);

        void ApagarPorUnidadeFederativa(int id);
    }
}
