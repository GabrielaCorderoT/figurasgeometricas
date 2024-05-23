using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figurasgeometricas
{
    class Prisma:Figura
    {
        //usamos el constructor de la clase padre 
        public Prisma(float lado1)
        {
            //radio se va a leer de la caja de texto con el boton guardar
            Lado1 = lado1;
        }

        //se crea la variante area lateral para obtener el area del prisma
        private float arealateral;
        //crear un constructor para prisma 
        public float Arealateral
        {
            set
            {
                //pregunta si el areala lateral <0
                if (value < 0)
                {
                    Arealateral = 0; //manda el valor a 0 
                    //NO EXISTEN NEGATIVOS
                }
                else
                {
                    arealateral = value;
                    //value es el valor del textbox 
                }
            }
            get //obtener el valor 
            {
                return arealateral; //regresa o cacha el valor 
            }
        }

        //se crea la variante largo para obtener el perimetro del prisma 
        private float largo;
        //crear un constructor para prisma
        public float Largo
        {
            set
            {
                //pregunta si largo <0
                if (value < 0)
                {
                    Largo = 0; //manda el valor a 0 
                    //NO EXISTEN NEGATIVOS
                }
                else
                {
                    largo = value;
                    //value es el valor del textbox 
                }
            }
            get //obtener el valor 
            {
                return largo; //regresa o cacha el valor de la variable 
            }
        }

        //se crea la variante ancho para obtener el perimetro del prisma 
        private float ancho;
        //crear un constructor para prisma
        public float Ancho
        {
            set
            {
                //pregunta si ancho <0
                if (value < 0)
                {
                    Ancho = 0; //manda el valor a 0 
                    //NO EXISTEN NEGATIVOS
                }
                else
                {
                    ancho = value;
                    //value es el valor del textbox 
                }
            }
            get //obtener el valor 
            {
                return ancho; //regresa o cacha el valor de la variable 
            }
        }

        //se crea la variante alto para obtener el perimetro del prisma 
        private float alto;
        //crear un constructor para prisma
        public float Alto
        {
            set
            {
                //pregunta si alto <0
                if (value < 0)
                {
                    Alto = 0; //manda el valor a 0 
                    //NO EXISTEN NEGATIVOS
                }
                else
                {
                    alto = value;
                    //value es el valor del textbox 
                }
            }
            get //obtener el valor 
            {
                return alto; //regresa o cacha el valor de la variable 
            }
        }
        private float areabase;
        //crear un constructor para prisma
        public float Areabase
        {
            set
            {
                //pregunta si la arista <0
                if (value < 0)
                {
                    Areabase = 0; //manda el valor a 0 
                    //NO EXISTEN NEGATIVOS
                }
                else
                {
                    areabase = value;
                    //value es el valor del textbox 
                }
            }
            get //obtener el valor 
            {
                return areabase; //regresa o cacha el valor de la variable arista
            }
        }
        //vamos a usar los metodos de la clase padre 
        //vamos a sobreescribir el comportamiento de estos 
        public override float area()
        {
            return Arealateral + 2 * Areabase;

        }
        public override float perimetro()
        {
            throw new NotImplementedException();
            //ESTO ES UNA EXEPCION DE USO DEFAULT
        }

        public override float volumen()
        {
            return Largo * Ancho * Alto;
        }
    }
}
