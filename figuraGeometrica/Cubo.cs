using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuraGeometrica
{
    class Cubo:figura
    {
        public Cubo(float lado) 
        {
            Lado1 = lado;
        }
        public override float area()
        {
            return 6*(Lado1*Lado1);
        }
        public override float perimetro()
        {
            return 12 * Lado1;
        }
        public override float volumen()
        {
            return Lado1 *Lado1*Lado1;
        }
    }
}
