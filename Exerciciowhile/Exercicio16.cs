namespace Exerciciowhile
{
    internal class Exercicio16
    {
        public void Executar()
        {
            Console.WriteLine("Digite um texto que deseja: ");
            var texto = Console.ReadLine().Trim().ToLower();

            var codigo = 0;
            int quantidadeDeLetras = texto.Length;

            var quantidadeLetraA = 0; var quantidadeLetraB = 0; var quantidadeLetraC = 0; var quantidadeLetraD = 0; var quantidadeLetraE = 0;

            while(codigo < texto.Length)
            {
                if(texto.Contains("a"))
                {
                    quantidadeLetraA = quantidadeLetraA + 1;
                }
                else if (texto.Contains("b"))
                {
                    quantidadeLetraB++;
                }
                else if (texto.Contains("c"))
                {
                    quantidadeLetraC++;
                }
                else if (texto.Contains("d"))
                {
                    quantidadeLetraE++;
                }

                quantidadeDeLetras = quantidadeDeLetras - 1;

                codigo++;
            }

            Console.WriteLine($@"A quantidade de letras digitadas são:
A = {quantidadeLetraA}
B = {quantidadeLetraB}
C = {quantidadeLetraC}
D = {quantidadeLetraD}
E = {quantidadeLetraE}");
        }

    }
}
