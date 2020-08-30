using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Armas
{
    public class classAmetralladora : IArma
    {
        public void Disparo(string objetivo)
        {
            Console.WriteLine($"{objetivo} ha sido alcanzado.");
        }
    }
}
