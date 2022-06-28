namespace Exerciciowhile
{
    internal class Exercicio15
    {
        public void Executar()
        {
            Console.WriteLine("Digite uma frase que deseja: ");
            var frase = Console.ReadLine();

            var caracteresTotais = frase.Length;

            int indice = 0;

            while(indice < caracteresTotais)
            {
                char caracter = Convert.ToChar(frase.Substring(indice, 1));
                
                Console.WriteLine(caracter);

                indice++;
            }
        }
    }
}
