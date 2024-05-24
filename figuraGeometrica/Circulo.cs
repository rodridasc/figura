using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuraGeometrica
{
    class Circulo : figura//es es una clase hija de figura
    {
        //usamos el constructor de la clase padre
        public Circulo(float radio)
        {
            //con el boton de guardar
            Lado1 = radio;//radio se lee de la caja de texto
        }
        //vamor a usar los metodos de la clase padre
        //vamos a sobre es cribir el comportamniento 
        public override float area()
        {
            return (3.1416F * (Lado1 * Lado1));//agregamos F para indicar que es un numero flotante
        }
        public override float perimetro()
        {
            return (3.1416F * (2 * Lado1));
        }
        public override float volumen()
        {
            throw new NotImplementedException();//esto es una exepcion de uso default del sistema
        }
    }
}
