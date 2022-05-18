using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFOR
{
    internal class Exercicio13
    {
        public void Executar()
        {

            var nomeMenorCartoesAmarelos = ""; var menorCartoesAmarelos = int.MaxValue; var nomeMaiorCartoesAmarelos = ""; var maiorCartoesAmarelos = 0;
            var nomeMenorCartoesVermelhos = ""; var menorCartoesVermelhos = int.MaxValue; var nomeMaiorCartoesVermelhos = ""; var maiorCartoesVermelhos = 0;
            var quantidadeJogadoresF = 0; var quantidadeJogadoresM = 0; var maiorNome = ""; var menorNome = "";
            var nomeMaiorAltura = ""; var maiorAltura = 0.0; var nomeMenorPeso = ""; var menorPeso = double.MaxValue; var nomeMaiorPeso = ""; var maiorPeso = 0.0;




            for (var i = 0; i < 3; i++)
            {
                var nome = "";

                try
                {
                    Console.WriteLine("Digite o nome do jogador: ");
                    nome = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("O nome digitado nao é valido! Por favor digite novamente: ");
                }

                Console.WriteLine("Digite a idade do jogador: ");
                var idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o peso do jogador: ");
                var peso = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o sexo do jogador: ");
                var sexo = Console.ReadLine().Trim().ToLower();
                Console.WriteLine("Digite a altura do jogador: ");
                var altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de gols marcados pelo jogador: ");
                var quantidadeGols = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de cartões amarelos recebidos pelo jogador: ");
                var quantidadeCartoesAmarelos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a quantidade de cartões vermelhos recebidos pelo jogador: ");
                var quantidadeCartoesVermelhos = Convert.ToInt32(Console.ReadLine());


                if (peso < menorPeso)
                {
                    menorPeso = peso;
                    nomeMenorPeso = nome;
                }
                if (peso > maiorPeso)
                {
                    maiorPeso = peso;
                    nomeMaiorPeso = nome;
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
                if (nome.Length < menorNome.Length)
                {
                    menorNome = nome;
                }
                if (sexo == "f")
                {
                    quantidadeJogadoresF = quantidadeJogadoresF + 1;
                }
                if (sexo == "m")
                {
                    quantidadeJogadoresM = quantidadeJogadoresM + 1;
                }
                if (quantidadeCartoesAmarelos < menorCartoesAmarelos)
                {
                    nomeMenorCartoesAmarelos = nome;
                    menorCartoesAmarelos = quantidadeCartoesAmarelos;
                }
                if (quantidadeCartoesAmarelos > maiorCartoesAmarelos)
                {
                    nomeMaiorCartoesAmarelos = nome;
                    maiorCartoesAmarelos = quantidadeCartoesAmarelos;
                }
                if (quantidadeCartoesVermelhos < menorCartoesVermelhos)
                {
                    nomeMenorCartoesVermelhos = nome;
                    menorCartoesVermelhos = quantidadeCartoesVermelhos;
                }
                if (quantidadeCartoesVermelhos > maiorCartoesVermelhos)
                {
                    nomeMaiorCartoesVermelhos = nome;
                    maiorCartoesVermelhos = quantidadeCartoesVermelhos;
                }


            }
            Console.WriteLine("O jogador com o menor peso é o " + nomeMenorPeso + " com um peso total de " + menorPeso + @" quilos
O jogador com o maior peso é o " + nomeMaiorPeso + " com um peso total de " + maiorPeso + @" quilos
O jogador com a maior altura é o " + nomeMaiorAltura + " com uma altura total de " + maiorAltura + @" metros
O jogador com o maior nome é o " + maiorNome + " e o jogador com o menor nome é o " + menorNome + @"
A quantidade de jogadoras do sexo feminino é de " + quantidadeJogadoresF + @" atletas
A quantidade de jogadores do sexo masculino é de " + quantidadeJogadoresM + @" atletas
O jogador com a menor quantidade de cartões amarelos é o " + nomeMenorCartoesAmarelos + " com um total de " + menorCartoesAmarelos + @" cartões
O jogador com a maior quantidade de cartões amarelos é o " + nomeMaiorCartoesAmarelos + " com um total de " + maiorCartoesAmarelos + @" cartões
O jogador com a menor quantidade de cartões vermelhos é o " + nomeMenorCartoesVermelhos + " com um total de " + menorCartoesVermelhos + @" cartões
O jogador com a maior quantidade de cartões vermelhos é o " + nomeMaiorCartoesVermelhos + " com um total de " + maiorCartoesVermelhos + " cartões");



        }
    }
}
