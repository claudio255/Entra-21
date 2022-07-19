namespace Entra21.BancoDados01.Ado.Net.Models
{
    internal class Cidades
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int QuantidadeHabitantes { get; set; }

        public DateTime DataHoraFundacao { get; set; }

        public double Pib { get; set; }

        public UnidadesFederativas UnidadesFederativas { get; set; }
    }
}
