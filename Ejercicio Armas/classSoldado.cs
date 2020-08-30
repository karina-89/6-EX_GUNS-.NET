using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Armas
{
    public class classSoldado
    {
        private IArma arma;
        public classSoldado(IArma arma)
        {
            this.arma = arma;
        }

        public void Atacar(string objetivo)
        {
            this.arma.Disparo(objetivo);
        }

        public void CambiarArma(IArma arma)
        {
            this.arma = arma;
        }
    }
}
