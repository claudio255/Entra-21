namespace Entra21
{
    internal class Exercicio18
    {
        public void Executar()
        {
            Console.WriteLine("Digite a hora do seu nascimento: ");
            var hora = Convert.ToInt32(Console.ReadLine());

            var minutos = 0;
            var segundos = 0;

            if(hora >= 23)
            {
                minutos = hora - 23;
                Console.Write("Vinte e três horas ");
            }
            else if(hora >= 22)
            {
                minutos = hora - 22;
                Console.Write("Vinte e duas horas ");
            }
            else if(hora >= 21)
            {
                minutos = hora - 21;
                Console.Write("Vinte e uma hora ");
            }
            else if(hora >= 20)
            {
                minutos = hora - 20;
                Console.Write("Vinte horas ");
            }
            else if(hora >= 19)
            {
                minutos = hora - 19;
                Console.Write("dezenove");
            }
        }
    }
}
