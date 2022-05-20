using ExerciciosVetor;

Console.WriteLine(@"--------------MENU-------------
1 - Exercicio 01
2 - Exercicio 02
3 - Exercicio 03
4 - Exercicio 04
Escolha a opção que deseja: ");
var opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

if(opcaoEscolhida == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
if(opcaoEscolhida == 2)
{
    Exercicio02 exercicio02 = new Exercicio02();
    exercicio02.Executar();
}
if(opcaoEscolhida == 3)
{
    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
if(opcaoEscolhida == 4)
{
    Exercicio04 exercicio04 = new Exercicio04();
    exercicio04.Executar();
}

