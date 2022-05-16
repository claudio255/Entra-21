using ExercicioFOR;


Console.WriteLine(@"----------------MENU------------
1 - Exercicio01
5 - Exercicio05
8 - Exercicio08
12 - Exercicio12
13 - Exercicio13");
Console.WriteLine("Digite a opção que deseja: ");
var opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

if(opcaoEscolhida == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if(opcaoEscolhida == 5)
{
    Exercicio05 exercicio05 = new Exercicio05();
    exercicio05.Executar();
}
else if(opcaoEscolhida == 8)
{
    Exercicio08 exercicio08 = new Exercicio08();
    exercicio08.Executar();
}
else if(opcaoEscolhida == 12)
{
    Exercicio12 exercicio12 = new Exercicio12();
    exercicio12.Executar();
}
else if (opcaoEscolhida == 13)
{
    Exercicio13 exercicio13 = new Exercicio13();
    exercicio13.Executar();
}
