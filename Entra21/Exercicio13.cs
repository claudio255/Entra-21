namespace Entra21
{
    internal class Exercicio13
    {
        public void Executar()
        {
            Console.WriteLine("Digite o primeiro numero: ");
            var primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            var segundoNumero = Convert.ToInt32(Console.ReadLine());

            if (primeiroNumero < segundoNumero)
                Console.WriteLine($"O numero {primeiroNumero} é menor que {segundoNumero}");
            else if (segundoNumero < primeiroNumero)
                Console.WriteLine($"O numero {segundoNumero} é menor que {primeiroNumero}");
            else
                Console.WriteLine("Os numeros são iguais!");
        }   
    }
}
