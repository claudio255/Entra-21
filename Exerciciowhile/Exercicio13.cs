using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    internal class Exercicio13
    {
        public void Executar()
        {
            int quantidadeJogadores = 0; int idade = 0; string sexo = ""; 
             
            string nomeMaiorPeso = ""; double maiorPeso = 0; string nomeMenorPeso = ""; double menorPeso = double.MaxValue; string nomeMaiorAltura = ""; double maiorAltura = 0;
            string menorNome = ""; string maiorNome = ""; int quantidadeJogadoresF = 0; int quantidadeJogadoresM = 0;
            string nomeMenorQuantidadeAmarelos = ""; int menorQuantidadeAmarelos = int.MaxValue; string nomeMaiorQuantidadeAmarelos = ""; int maiorQuantidadeAmarelos = 0;
            string nomeMenorQuantidadeVermelhos = ""; int menorQuantidadeVermelhos = int.MaxValue; string nomeMaiorQuantidadeVermelhos = ""; int maiorQuantidadeVermelhos = 0;




            while (quantidadeJogadores < 3) 
            {
                Console.WriteLine("Digite o nome do jogador: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a idade do jogador: ");
                idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o peso do jogador: ");
                double peso = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o sexo do jogador ");
                sexo = Console.ReadLine();
                Console.WriteLine("Digite a altura do jogador: ");
                double altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de gols marcados pelo jogador: ");
                int quantidadeGolsMarcados = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de cartões amarelos recebidos pelo jogador: ");
                int quantidadeCartoesAmarelos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de cartões vermelhos recebidos pelo jogador: ");
                int quantidadeCartoesVermelhos = Convert.ToInt32(Console.ReadLine());

                if (peso < menorPeso)
                {
                    menorPeso = peso;
                    nomeMenorPeso = nome;
                }
                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                    nomeMaiorAltura = nome;
                }
                if (nome.Length > maiorNome.Length)
                {
                    maiorNome = nome;
                }
                if (sexo == "f")
                {
                    quantidadeJogadoresF = quantidadeJogadoresF + 1;
                }
                if (sexo == "m")
                {
                    quantidadeJogadoresM = quantidadeJogadoresM + 1;
                }
                if (quantidadeCartoesAmarelos < menorQuantidadeAmarelos)
                {
                    menorQuantidadeAmarelos = quantidadeCartoesAmarelos;
                    nomeMenorQuantidadeAmarelos = nome;
                }
                if (nome.Length < menorNome.Length)
                {
                    menorNome = nome;
                }
                if (peso > menorPeso)
                {
                    maiorPeso = peso;
                    nomeMaiorPeso = nome;
                }
                if (quantidadeCartoesVermelhos > maiorQuantidadeVermelhos)
                {
                    maiorQuantidadeVermelhos = quantidadeCartoesVermelhos;
                    nomeMaiorQuantidadeVermelhos = nome;
                }
                if (quantidadeCartoesAmarelos > maiorQuantidadeAmarelos)
                {
                    maiorQuantidadeAmarelos = quantidadeCartoesAmarelos;
                    nomeMaiorQuantidadeAmarelos = nome;
                }
                if (quantidadeCartoesVermelhos < menorQuantidadeVermelhos)
                {
                    menorQuantidadeVermelhos =quantidadeCartoesVermelhos;
                    nomeMenorQuantidadeVermelhos = nome;
                }


                quantidadeJogadores = quantidadeJogadores + 1;
            }
            Console.WriteLine("O jogador com o menor peso é: " + nomeMenorPeso + " com um peso de: " + menorPeso);
            Console.WriteLine("O jogador com o maior peso é: " + nomeMaiorPeso + " com um peso de: " + maiorPeso);
            Console.WriteLine("O jogador com a maior altura é: " + nomeMaiorAltura + " com uma altura de: " + maiorAltura);
            Console.WriteLine("O jogador com o menor nome é: " + menorNome);
            Console.WriteLine("O jogador com o maior nome é: " + maiorNome);
            Console.WriteLine("A quantidade de jogadores do sexo feminino é de: " + quantidadeJogadoresF + " atletas");
            Console.WriteLine("A quantidade de jogadores do sexo masculino é de:" + quantidadeJogadoresM + " atletas");
            Console.WriteLine("O jogador com a menor quantidade de cartões amarelos recebidos é: " + nomeMenorQuantidadeAmarelos + " com um total de " + menorQuantidadeAmarelos + " cartões");
            Console.WriteLine("O jogador com a maior quantidade de cartões amarelos recebidos é: " + nomeMaiorQuantidadeAmarelos + " com um total de: " + maiorQuantidadeAmarelos + " cartões");
            Console.WriteLine("O jogador com a menor quantidade de cartões vermelhos recebidos é: " + nomeMenorQuantidadeVermelhos + " com um total de: " + menorQuantidadeVermelhos + " cartões");
            Console.WriteLine("O jogador com a maior quantidade de cartões vermelhos recebidos é: " + nomeMaiorQuantidadeVermelhos + " com um total de: " + maiorQuantidadeVermelhos + " cartões");

        }
    }
}