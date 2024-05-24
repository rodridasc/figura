using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuraGeometrica
{
    class PoligonoI:figura
    {
        private float lado1;
        public override float area()
        {
            throw new NotImplementedException();
        }
        public override float perimetro()
        {
            throw new NotImplementedException();
        }
        public override float volumen()
        {
            throw new NotImplementedException();
        }
        class Rombo : PoligonoI
        {
            private float diagonalMen;
            private float diagonalMay;
            public float DiagonalMen
            {
                //modificado para poner el valor en la caja de memoria 
                set //obtener valor
                {
                    //pregunta si el lado es menor a cero
                    if (value < 0)
                    {
                        diagonalMen = 0;
                    }//no existen lado negativos
                    else
                    {
                        diagonalMen = value;
                    }
                }
                get
                {
                    return diagonalMen;//ingresa el valor en de la variable lado1
                }
            }
            public float DiagonalMay
            {
                //modificado para poner el valor en la caja de memoria 
                set //obtener valor
                {
                    //pregunta si el lado es menor a cero
                    if (value < 0)
                    {
                        diagonalMay = 0;
                    }//no existen lado negativos
                    else
                    {
                        diagonalMay = value;
                    }
                }
                get
                {
                    return diagonalMay;//ingresa el valor en de la variable lado1
                }
            }
            public Rombo(float Lado1, float diagonalMen, float diagonalMay)
            {
                this.DiagonalMay = diagonalMay;
                this.DiagonalMen = diagonalMen;
                this.Lado1 = lado1;
            }
            public override float area()
            {
                return (diagonalMen * diagonalMay) / 2;
            }
            public override float perimetro()
            {
                return lado1 * 4;
            }
            public override float volumen()
            {
                return base.volumen();
            }
        }
        class trapecio : PoligonoI
        {
            private float base1;
            private float base2;
            private float altura;
            public float Base1
            {
                //modificado para poner el valor en la caja de memoria 
                set //obtener valor
                {
                    //pregunta si el lado es menor a cero
                    if (value < 0)
                    {
                        base1 = 0;
                    }//no existen lado negativos
                    else
                    {
                        base1 = value;
                    }
                }
                get
                {
                    return base1;//ingresa el valor en de la variable lado1
                }
            }
            public float Base2
            {
                //modificado para poner el valor en la caja de memoria 
                set //obtener valor
                {
                    //pregunta si el lado es menor a cero
                    if (value < 0)
                    {
                        base2 = 0;
                    }//no existen lado negativos
                    else
                    {
                        base2 = value;
                    }
                }
                get
                {
                    return base2;//ingresa el valor en de la variable lado1
                }
            }
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
            public trapecio(float Lado1, float base1, float base2,float altura)
            {
                this.Base1 = base1;
                this.Base2 = base2;
                this.Altura = altura;
                this.Lado1 = lado1;
            }
            public override float area()
            {
                return (Base1 * Base2) / 2;
            }
            public override float perimetro()
            {
                return lado1 * 4;
            }
            public override float volumen()
            {
                return base.volumen();
            }
        }
       
    }
}
