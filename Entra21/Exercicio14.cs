namespace Entra21
{
    internal class Exercicio14
    {
        public void Executar()
        {
            //4.Ler três números e apresentar os valores em ordem crescente.
            Console.WriteLine("Digite o primeiro numero: ");
            var primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            var segundoNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o terceiro numero: ");
            var terceiroNumero = Convert.ToInt32(Console.ReadLine());

            if (primeiroNumero < segundoNumero && segundoNumero < terceiroNumero)
                Console.WriteLine($"{primeiroNumero} {segundoNumero} {terceiroNumero}");
            else if (primeiroNumero < terceiroNumero && terceiroNumero < segundoNumero)
                Console.WriteLine($"{primeiroNumero} {terceiroNumero} {segundoNumero}");
            else if (segundoNumero < terceiroNumero && terceiroNumero < primeiroNumero)
                Console.WriteLine($"{segundoNumero} {terceiroNumero} {primeiroNumero}");
            else if (segundoNumero < primeiroNumero && primeiroNumero < terceiroNumero)
                Console.WriteLine($"{segundoNumero} {primeiroNumero} {terceiroNumero}");
            else if (terceiroNumero < primeiroNumero && primeiroNumero < segundoNumero)
                Console.WriteLine($"{terceiroNumero} {primeiroNumero} {segundoNumero}");
            else if (terceiroNumero < segundoNumero && segundoNumero < primeiroNumero)
                Console.WriteLine($"{terceiroNumero} {segundoNumero} {primeiroNumero}");
            else
                Console.WriteLine("Os numeros são iguais!");
        }
    }
}
