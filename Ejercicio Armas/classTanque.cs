using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Armas
{
    public class classTanque
    {
        private IArma armaFrontal;
        private IArma armaDerecha;
        private IArma armaIzquierda;

        public classTanque(IArma Frontal, IArma Derecha, IArma Izquierda)
        {
            this.armaFrontal = Frontal;
            this.armaDerecha = Derecha;
            this.armaIzquierda = Izquierda;
        }

        public void Atacar(string objetivo)
        {
            AtacarFrontal(objetivo);
            AtacarDerecha(objetivo);
            AtacarIzquierda(objetivo);
        }

        public void AtacarFrontal(string objetivo)
        {
            this.armaFrontal.Disparo(objetivo);
        }
        public void AtacarDerecha(string objetivo)
        {
            this.armaDerecha.Disparo(objetivo);
        }
        public void AtacarIzquierda(string objetivo)
        {
            this.armaIzquierda.Disparo(objetivo);
        }
    }
}
