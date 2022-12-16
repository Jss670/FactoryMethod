using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class CreaObjetos
    {
        public const int TEMPERATURA_GUAYMAS = 1;
        public const int TEMPERATURA_HERMOSILLO = 2;

        public static Clima? CreadorObjet(int tipo)
            
        {
            switch (tipo)
            {
                case TEMPERATURA_GUAYMAS: return new TemperaturaGuaymas();

                case TEMPERATURA_HERMOSILLO: return new TemperaturaHermosillo();
                default: return null;
            }
             
        }

    }
}
