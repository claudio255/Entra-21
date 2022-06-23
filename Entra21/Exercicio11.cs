namespace Entra21
{
    internal class Exercicio11
    {
        public void Executar()
        {
            //            De 0 até 5.99 Reprovado
            //De 6.00 até 7.99 Recuperação
            //Acima de 7.99 Aprovado
            Console.WriteLine("Digite a primeira nota do aluno(a): ");
            var primeiraNota = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota do aluno(a): ");
            var segundaNota = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota do aluno(a): ");
            var terceiraNota = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota do aluno(a): ");
            var quartaNota = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quinta nota do aluno(a): ");
            var quintaNota = Convert.ToDouble(Console.ReadLine());

            var media = (primeiraNota + segundaNota + terceiraNota + quartaNota + quintaNota) / 5;

            if (media < 6)
                Console.WriteLine("O aluno está reprovado!");
            else if (media < 8)
                Console.WriteLine("O aluno está em exame!");
            else
                Console.WriteLine("O aluno está aprovado!");
        }
    }
}
