using ExercicioLista;


Console.WriteLine($@"-------------MENU-------------
1 - Exercicio 01
2 - Exercicio 02
3 - Exercicio 03");
var opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

if (opcaoEscolhida == 1)
{
    var lista = new ExercicioLista01();
    lista.Executar();
}

if (opcaoEscolhida == 2)
{
    var lista = new ExercicioLista02();
    lista.Executar();
}

if (opcaoEscolhida == 3)
{
    var lista = new ExercicioLista03();
    lista.Executar();
}
