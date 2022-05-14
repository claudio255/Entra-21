using ExercicioFOR;


Console.WriteLine(@"----------------MENU------------
1 - Exercicio01
5 - Exercicio05");
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
