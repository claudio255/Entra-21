namespace Entra21
{
    internal class Exercicio17
    {
        public void Executar()
        {
            //            17.Solicite o ano de nascimento e apresente o ano escrito por extenso.
            //Exemplo: 1993 deverá apresentar para o usuário “Mil novecentos e noventa e três”
            Console.WriteLine("Digite o seu ano de nascimento: ");
            var nascimento = Convert.ToInt32(Console.ReadLine());

            var milhar = 0;
            var centena = 0;
            var dezena = 0;

            if (nascimento >= 2000)
            {
                milhar = nascimento - 2000;
                Console.WriteLine("dois mil");
            }
            else if(nascimento >= 1000)
            {
                milhar = nascimento - 1000;
                Console.WriteLine("mil");
            }

        }
    }
}
