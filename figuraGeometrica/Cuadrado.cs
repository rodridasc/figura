using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuraGeometrica
{
    class Cuadrado: figura
    {
        public Cuadrado(float lado)
        {
            Lado1 = lado;
        }
        public override float area()
        {
            return Lado1 * Lado1;
        }
        public override float perimetro()
        {
            return Lado1 * 4;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
