namespace Entra21
{
    internal class Exercicio09
    {

        public void Executar()

        {
            Console.WriteLine("Digite o numero que deseja");
            var primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o numero que deseja");
            var segundoNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o numero que deseja");
            var terceiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o numero que deseja");
            var quartoNumero = Convert.ToInt32(Console.ReadLine());

            if (primeiroNumero == segundoNumero && segundoNumero == terceiroNumero && terceiroNumero == quartoNumero)
                Console.WriteLine("Os numeros digitados formam um quadrado!");
            else
                Console.WriteLine("Os numeros digitados não formam um quadrado!");
        }
    }
}
