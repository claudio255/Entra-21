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
            var quantidadeJogadoresF = 0; var quantidadeJogadoresM = 0; var maiorNome = ""; var menorNome = "                                                                ";
            var nomeMaiorAltura = ""; var maiorAltura = 0.0; var nomeMenorPeso = ""; var menorPeso = double.MaxValue; var nomeMaiorPeso = ""; var maiorPeso = 0.0;




            for (var i = 0; i < 3; i++)
            {
                var idade = 0; var peso = 0.0; var altura = 0.0; var quantidadeGols = -1; var quantidadeCartoesAmarelos = -1; var quantidadeCartoesVermelhos = -1;


                Console.WriteLine("Digite o nome do jogador: ");
                var nome = Console.ReadLine().Trim().ToLower();
                while (idade <= 18 || idade >= 40)
                {
                    try
                    {
                        Console.WriteLine("Digite a idade do jogador: ");
                        idade = Convert.ToInt32(Console.ReadLine());
                        if (idade <= 18)
                        {
                            Console.WriteLine("O jogador não possui a idade miníma!");
                        }
                        else if (idade >= 40)
                        {
                            Console.WriteLine("O jogador está com a idade superior ao maxímo permitido!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Digite uma idade valida!");
                    }
                }
                while (peso < 40 || peso > 100)
                {
                    try
                    {
                        Console.WriteLine("Digite o peso do jogador: ");
                        peso = Convert.ToDouble(Console.ReadLine());
                        if (peso < 40)
                        {
                            Console.WriteLine("O jogador está com o peso abaixo do permitido!");
                        }
                        else if (peso > 100)
                        {
                            Console.WriteLine("O jogador esta com o peso maior do que permitido pelo CBF!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Digite um peso valido!");
                    }
                }
                Console.WriteLine("Digite o sexo do jogador: ");
                var sexo = Console.ReadLine().Trim().ToLower();
                while (altura < 1.40)
                {
                    try
                    {
                        Console.WriteLine("Digite a altura do jogador: ");
                        altura = Convert.ToDouble(Console.ReadLine());
                        if (altura < 1.40)
                        {
                            Console.WriteLine("A altura do jogador esta abaixo do permitido!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Por favor digite uma altura valida!");
                    }
                }
                while (quantidadeGols < 0)
                {
                    try
                    {
                        Console.WriteLine("Digite a quantidade de gols marcados pelo jogador: ");
                        quantidadeGols = Convert.ToInt32(Console.ReadLine());
                        if (quantidadeGols < 0)
                        {
                            Console.WriteLine("A quantidade de gols digitada é menor que zero!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Digite uma quantidade valida!");
                    }
                }
                while (quantidadeCartoesAmarelos < 0)
                {
                    try
                    {
                        Console.WriteLine("Digite a quantidade de cartões amarelos recebidos pelo jogador: ");
                        quantidadeCartoesAmarelos = Convert.ToInt32(Console.ReadLine());
                        if (quantidadeCartoesAmarelos < 0)
                        {
                            Console.WriteLine("A quantidade de cartões amarelos digitada não é permitida!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Digite uma quantidade de cartões valida!");
                    }
                }
                while (quantidadeCartoesVermelhos < 0)
                {
                    try
                    {
                        Console.WriteLine("Digite a quantidade de cartões vermelhos recebidos pelo jogador: ");
                        quantidadeCartoesVermelhos = Convert.ToInt32(Console.ReadLine());
                        if (quantidadeCartoesVermelhos < 0)
                        {
                            Console.WriteLine("A quantidade de cartões digitada não é permitida!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("A quantidade digitada não é valida!");
                    }
                }



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
