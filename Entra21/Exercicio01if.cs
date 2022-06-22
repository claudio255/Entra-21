namespace Entra21
{
    internal class Exercicio01if
    {
        public void Executar()
        {
            Console.WriteLine("Digite o numero que deseja: ");
            var numeroDigitado = Convert.ToInt32(Console.ReadLine());

            if (numeroDigitado == 0)
            {
                Console.WriteLine("O numero digitado é neutro!");
            }
            else if (numeroDigitado < 0)
                Console.WriteLine("O numero digitado é negativo!");
            else
                Console.WriteLine("O numero digitado é positivo!");
        }
    }
}
