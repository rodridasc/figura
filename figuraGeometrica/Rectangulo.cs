using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuraGeometrica
{
    class Rectangulo:figura
    {
        //necesitamos dos lados para funcionar creamos un lado 2
        private float lado2;
        //Creamos un construtor para rectangulo
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
        //usamos el constructor de la clase padre
        public Rectangulo(float lado1,float lado2)
        {
            //con el boton de guardar
            this.Lado1 = lado2;// this. hace que unicamente el valor la contidad del lado sea disponible para
            //la clase rectangulo, cuando no se use rectangulo la variable sera =0
            Lado2 = lado2;
        }
        //vamor a usar los metodos de la clase padre
        //vamos a sobre es cribir el comportamniento 
        public override float area()
        {
            return Lado1*Lado2;//agregamos F para indicar que es un numero flotante
        }
        public override float perimetro()
        {
            return (Lado1*2)+(lado2*2);
        }
        public override float volumen()
        {
            throw new NotImplementedException();//esto es una exepcion de uso default del sistema
        }
    }
}
