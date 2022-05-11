using Exerciciowhile;

Console.Write(@"------------MENU---------------
1 - Exercicio01
2 - Exercicio02
3 - Exercicio03
4 - Exercicio04
5 - Exercicio05
6 - Exercicio06
7 - Exercicio07
8 - Exercicio08
9 - Exercicio09
11 - Exercicio11
12 - Exercicio12
13 - Exercicio13
Digite o numero desejado: ");

int numeroDigitado = Convert.ToInt32(Console.ReadLine());

if(numeroDigitado == 1)
{
    Exercicio01 exercicio01 = new Exercicio01();
    exercicio01.Executar();
}
else if (numeroDigitado == 2)
{
    Exercicio02 exercicio02 = new Exercicio02();
    exercicio02.Executar();
}
else if (numeroDigitado == 3)
{
    Exercicio03 exercicio03 = new Exercicio03();
    exercicio03.Executar();
}
else if (numeroDigitado == 4)
{
    Exercicio04 exercicio04 = new Exercicio04();
    exercicio04.Executar();

}
else if (numeroDigitado == 5)
{
    Exercicio05 exercicio05 = new Exercicio05();
    exercicio05.Executar();
}
else if (numeroDigitado == 6)
{
    Exercicio06 exercicio06 = new Exercicio06();
    exercicio06.Executar();
}
else if (numeroDigitado == 7)
{
    Exercicio07 exercicio07 = new Exercicio07();
    exercicio07.Executar();
}
else if (numeroDigitado == 8)
{
    Exercicio08 exercicio08 = new Exercicio08();
    exercicio08.Executar();
}
else if (numeroDigitado == 9)
{
    Exercicio09 exercicio09 = new Exercicio09();
    exercicio09.Executar();
}
else if (numeroDigitado == 11)
{
    Exercicio11 exercicio11 = new Exercicio11();
    exercicio11.Executar();
}
else if (numeroDigitado == 12)
{
    Exercicio12 exercicio12 = new Exercicio12();
    exercicio12.Executar();
}
else if (numeroDigitado == 13)
{
    Exercicio13 exercicio13 = new Exercicio13();
    exercicio13.Executar();
}