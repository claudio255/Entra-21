using Entra21;

Console.WriteLine(@"---------------MENU----------------
1 - Exercicio01
2 - Exercicio02
3 - Exercicio03
Digite o Exercicio que deseja: ");
var opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

if (opcaoEscolhida == 1)
{
    Exercicio01if exercicio01 = new Exercicio01if();
    exercicio01.Executar();
}
if (opcaoEscolhida == 2)
{
    Exercicio02if exercicio02 = new Exercicio02if();
    exercicio02.Executar();
}
if(opcaoEscolhida == 3)
{
    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
if (opcaoEscolhida == 4)
{
    Exercicio04 exercicio04 = new Exercicio04();
    exercicio04.Executar();
}
if (opcaoEscolhida == 5)
{
    Exercicio05 exercicio05 = new Exercicio05();
    exercicio05.Executar();
}
if (opcaoEscolhida == 6)
{
    Exercicio06 exercicio06 = new Exercicio06();
    exercicio06.Executar();
}
if (opcaoEscolhida == 7)
{
    Exercicio07 exercicio07 = new Exercicio07();
    exercicio07.Executar();
}
if (opcaoEscolhida == 8)
{
    Exercicio08 exercicio08 = new Exercicio08();
    exercicio08.Executar();
}

