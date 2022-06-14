using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioListaObejetos
{
    internal class Triangulo
    {
        public int Lado1;
        public int Lado2;
        public int Lado3;
        public int Codigo;
        public TipoTriangulo Triangulos;


        public bool ValidarTriangulo()
        {
            if (EhEquilatero())
            {
                return true;
            }
            if ((Lado1 == Lado2 && Lado1 != Lado3) || (Lado1 == Lado3 && Lado1 != Lado2) || (Lado2 == Lado3 && Lado2 != Lado1))
            {
                return true;
            }
            if (Lado1 != Lado2 && Lado2 != Lado3 && Lado3 != Lado1)
            {
                return true;
            }
            return false;
        }

        private bool EhEquilatero()
        {
            if (Lado1 == Lado2 && Lado1 == Lado3 && Lado2 == Lado3)
                return true;

            return false;
        }
    }
}
