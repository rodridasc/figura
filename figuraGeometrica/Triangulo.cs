using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuraGeometrica
{
    class Triangulo:figura
    {
        private float altura;
        public float Altura
        {
            //modificado para poner el valor en la caja de memoria 
            set //obtener valor
            {
                //pregunta si el lado es menor a cero
                if (value < 0)
                {
                    altura = 0;
                }//no existen lado negativos
                else
                {
                    altura = value;
                }
            }
            get
            {
                return altura;//ingresa el valor en de la variable lado1
            }
        }
        public Triangulo(float lado1,float altura)
        {
            this.Lado1 = altura;
            Altura = altura;
        }
        public override float area()
        {
            return (Lado1 * altura) / 2;
        }
        public override float perimetro()
        {
            return Lado1+Lado1+Lado1;
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
    }
}
