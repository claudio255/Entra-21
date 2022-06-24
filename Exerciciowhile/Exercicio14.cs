namespace Exerciciowhile
{
    internal class Exercicio14
    {
        public void Executar()
        {
            Console.WriteLine("Digite a quantidade de caracteres que deseja: ");
            var quantidadeCaracter = Convert.ToInt32(Console.ReadLine());

            int indice = 0;
            var texto = string.Empty;

            while(indice < quantidadeCaracter)
            {
                Console.WriteLine("Digite o caracter que deseja: ");
                var caracter = Console.ReadLine();

                texto += caracter;

                indice++;
            }

            Console.WriteLine(texto);
        }
    }
}
