using ExerciciosVetor;

Console.WriteLine(@"--------------MENU-------------
1 - Exercicio 01
2 - Exercicio 02
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

