using System;

namespace Ejercicio_Armas
{
    class Program
    {
        static void Main(string[] args)
        {
            classSoldado soldado = new classSoldado(new classAmetralladora());
            soldado.Atacar("Infantería");

            soldado.CambiarArma(new classBazuka());
            soldado.Atacar("Tanque");

            soldado.CambiarArma(new classPistola());
            soldado.Atacar("Francotirador");

            classTanque tanque = new classTanque(new classBazuka(), new classAmetralladora(), new classAmetralladora());
            tanque.Atacar("Soldado");
        }
    }
}
