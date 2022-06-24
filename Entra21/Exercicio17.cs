namespace Entra21
{
    internal class Exercicio17
    {
        public void Executar()
        {
            //            17.Solicite o ano de nascimento e apresente o ano escrito por extenso.
            //Exemplo: 1993 deverá apresentar para o usuário “Mil novecentos e noventa e três”
            Console.WriteLine("Digite o seu ano de nascimento: ");
            var nascimento = Convert.ToInt32(Console.ReadLine());

            var centena = 0;
            var dezena = 0;
            var unidade = 0;

            if (nascimento >= 2000)
            {
                centena = nascimento - 2000;
                Console.WriteLine("dois mil");
            }
            else if(nascimento >= 1000)
            {
                centena = nascimento - 1000;
                Console.WriteLine("mil");
            }

            if(centena >= 900)
            {
                dezena = centena - 900;
                Console.WriteLine("novecentos");
            }
            else if(centena >= 800)
            {
                dezena = centena - 800;
                Console.WriteLine("oitocentos");
            }
            else if (centena >= 700)
            {
                dezena = centena - 700;
                Console.WriteLine("setecentos");
            }
            else if(centena >= 600)
            {
                dezena = centena - 600;
                Console.WriteLine("seiscentos");
            }
            else if(centena >= 500)
            {
                dezena = centena - 500;
                Console.WriteLine("quinhetos");
            }
            else if(centena >= 400)
            {
                dezena = centena - 400;
                Console.WriteLine("quatrocentos");
            }
            else if(centena >= 300)
            {
                dezena = centena - 300;
                Console.WriteLine("trezentos");
            }
            else if(centena >= 200)
            {
                dezena = centena - 200;
                Console.WriteLine("duzentos");
            }
            else if(centena > 100)
            {
                dezena = centena - 100;
                Console.WriteLine("cento");
            }
            else if (centena == 100)
            {
                Console.WriteLine("cem");
            }

            if(dezena >= 90)
            {
                unidade = dezena - 90;
                Console.WriteLine("noventa");
            }
            else if(dezena >= 80)
            {
                unidade = dezena - 80;
                Console.WriteLine("oitenta");
            }
            else if (dezena >= 70)
            {
                unidade = dezena - 70;
                Console.WriteLine("setenta");
            }
            else if (dezena >= 60)
            {
                unidade = dezena - 60;
                Console.WriteLine("sessenta");
            }
            else if (dezena >= 50)
            {
                unidade = dezena - 50;
                Console.WriteLine("cinquenta");
            }
            else if(dezena >= 40)
            {
                unidade = dezena - 40;
                Console.WriteLine("quarenta");
            }
            else if(dezena >= 30)
            {
                unidade = dezena - 30;
                Console.WriteLine("trinta");
            }
            else if(dezena >= 20)
            {
                unidade = dezena - 20;
                Console.WriteLine("vinte");
            }
            else if(dezena == 19)
            {
                Console.WriteLine("dezenove");
            }
            else if (dezena == 18)
            {
                Console.WriteLine("dezeoito");
            }
            else if (dezena == 17)
            {
                Console.WriteLine("dezessente");
            }
            else if (dezena == 16)
            {
                Console.WriteLine("dezesseis");
            }
            else if (dezena == 15)
            {
                Console.WriteLine("quinze");
            }
            else if (dezena == 14)
            {
                Console.WriteLine("quatorce");
            }
            else if (dezena == 13)
            {
                Console.WriteLine("treze");
            }
            else if (dezena == 12)
            {
                Console.WriteLine("doze");
            }
            else if (dezena == 11)
            {
                Console.WriteLine("onze");
            }
            else if (dezena == 10)
            {
                Console.WriteLine("dez");
            }

            if(unidade == 9)
            {
                Console.WriteLine("nove");
            }
            else if(unidade == 8)
            {
                Console.WriteLine("oito");
            }
            else if (unidade == 7)
            {
                Console.WriteLine("sete");
            }
            else if(unidade == 6)
            {
                Console.WriteLine("seis");
            }
            else if (unidade == 5)
            {
                Console.WriteLine("cinco");
            }
            else if(unidade == 4)
            {
                Console.WriteLine("quatro");
            }
            else if(unidade == 3)
            {
                Console.WriteLine("três");
            }
            else if (unidade == 2)
            {
                Console.WriteLine("dois");
            }
            else if (unidade == 1)
            {
                Console.WriteLine("um");
            }
        }
    }
}
