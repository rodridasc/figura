using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuraGeometrica
{
    abstract class figura //clase padre
    {
        /*clase permite el ingreso de un lado para crear 
         una nueva figura geometrica
        recuerda que una figura geometrica para existir requiere
        minimo un lado*/
        /*Declaracion de variables que se va a pasar a las clases hijas*/
        //sera privada
        private float lado1;//permite decimales
        //creamos atributos o propiedades
        //definamos el constructor
        public float Lado1 
        {
            //modificado para poner el valor en la caja de memoria 
            set //obtener valor
            {
                //pregunta si el lado es menor a cero
                if (value < 0)
                {
                    lado1 = 0;
                }//no existen lado negativos
                else
                {
                    lado1 = value;
                }
            }
            get 
            {
                return lado1;//ingresa el valor en de la variable lado1
            }            
        }
        //definir metodos, funciones, operaciones de la clase padre que tambien va a tener los hijos
        //metodo de tipo publico para que todos lo usen 
        //metodos abstractos ya que cada hijo definira sus operaciones
        public abstract float area();
        public abstract float perimetro();
        public abstract float volumen();
            
        
    }
}
