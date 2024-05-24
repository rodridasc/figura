using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuraGeometrica
{
    class Prisma: figura
    {
        private float lado2;
        private float lado3;
        public float Lado2
        {
            //modificado para poner el valor en la caja de memoria 
            set //obtener valor
            {
                //pregunta si el lado es menor a cero
                if (value < 0)
                {
                    lado2 = 0;
                }//no existen lado negativos
                else
                {
                    lado2 = value;
                }
            }
            get
            {
                return lado2;//ingresa el valor en de la variable lado1
            }
        }
        public float Lado3
        {
            //modificado para poner el valor en la caja de memoria 
            set //obtener valor
            {
                //pregunta si el lado es menor a cero
                if (value < 0)
                {
                    lado3 = 0;
                }//no existen lado negativos
                else
                {
                    lado3 = value;
                }
            }
            get
            {
                return lado3;//ingresa el valor en de la variable lado1
            }
        }
        public Prisma(float lado1, float lado2, float lado3)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
            this.Lado3 = lado3;
        }
        public override float area()
        {
            return (2*Lado1*Lado2)+(2*Lado1*Lado3)+(2*Lado2*Lado3);
        }
        public override float perimetro()
        {
            return (4 * Lado1) + (4 * Lado2) + (4 * Lado3);
        }
        public override float volumen()
        {
            return Lado1*Lado2*Lado3;
        }
    }
}
