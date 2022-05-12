using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciowhile
{
    internal class Exercicio17
    {
        public void Executar()
        {
            int hora = 23;
            while (hora >= 0)
            {
                string horaFormatada = hora.ToString();


                if (hora < 10)
                {
                    horaFormatada = "0" + horaFormatada;
                }
                int minuto = 59;
                while (minuto >= 0)
                {
                    string minutoFormatado = minuto.ToString();

                    if (minuto < 10)
                    {
                        minutoFormatado = "0" + minuto.ToString();
                    }
                    int segundo = 59;
                    while (segundo >= 0)
                    {
                        string segundoFormatado = segundo.ToString();

                        if (segundo < 10)
                        {
                            segundoFormatado = "0" + segundo.ToString();
                        }
                        Console.WriteLine(horaFormatada + ":" + minutoFormatado + ":" + segundoFormatado);
                        segundo = segundo - 1;
                    }
                    minuto = minuto - 1;
                }
                hora = hora - 1;
            }


        }
    }
}
