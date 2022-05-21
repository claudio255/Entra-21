using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosVetor
{
    internal class ExercicioProfessor
    {
        public void Executar()
        {
            var table = new ConsoleTable("codigo", "produto", "preço");
            table.AddRow(1, "Bolo de cenoura", "30,00")
                 .AddRow(2, "Pizza calabresa", "28,99")
                 .AddRow(3, "Sanduiche", "14,90");

            

            table.Write();
        }
    }
}
