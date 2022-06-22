namespace Entra21
{
    internal class Exercicio03
    {
        public void Executar()
        {
            Console.WriteLine("Digite o numero que deseja: ");
            var primeiroNumero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero desejado: ");
            var segundoNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"
1 - SOMAR
2 - SUBTRAIR
3 - MULTIPLICAR
4 - DIVIDIR
Escolha a opção que deseja: ");
            var opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

            if (opcaoEscolhida == 1)
            {
                var soma = (primeiroNumero + segundoNumero);
                Console.WriteLine($"A soma dos numeros fica: {soma}");
            }
            else if(opcaoEscolhida == 2)
            {
                var subtracao = (primeiroNumero - segundoNumero);
                Console.WriteLine($"A subtração dos numeros fica: {subtracao}");
            }    
            else if(opcaoEscolhida == 3)
            {
                var multiplicacao = primeiroNumero * segundoNumero;
                Console.WriteLine($"A multiplicação dos numero fica: {multiplicacao}");
            }
            else
            {
                var dividir = primeiroNumero / segundoNumero;
                Console.WriteLine($"A divisão dos numeros fica: {dividir}");
            }

        }
    }
}
