using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Armas
{
    public class classPistola : IArma
    {
        public void Disparo(string objetivo)
        {
            Console.WriteLine($"{objetivo} ha sido alcanzado.");
        }
    }
}
