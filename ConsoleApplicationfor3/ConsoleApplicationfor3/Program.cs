using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationfor3
{
    class Program
    {
        static void Main(string[] args)
        {  /*3. Un programa que permita ingresar los datos de N personas (nombre,sexo,edad y altura)
            Calcular: promedio altura hombres, mujeres en cada categoría.
            * Categoría (promedio en hombres y promedio en mujeres)
            * a)Niños 0 a 12 años
            * b)jóvenes 13 a 29 años
            * c)adultos 30 a 59 años
            * d)tercera edad 60 a más (as ancianos)
            */

            /* ANÁLISIS 
             * N= a 4 personas
             * INGRESOS: nombre, sexo (m-f), edad y altura
             * Para obtener promedio: contador y acumulador
             * MOSTRAR: 
             * Promedio altura niños m y f
             * Promedio altura jóvenes m y f
             * Promedio altura adultos m y f
             * Promedio altura ancianos m y f
             */

            //Variables a mostar en 0
            //CANTIDADES
            int cantidadNiñosM = 0, cantidadNiñosF = 0,
                cantidadJovenesM = 0, cantidadJovenesF = 0,
                cantidadAdultosM = 0, cantidadAdultosF = 0,
                cantidadAncianosM = 0, cantidadAncianosF = 0;
            //ACUMULADORES (SUMAS EDAD)
            float alturaNiñosM = 0, alturaNiñosF = 0,
                  alturaJovenesM = 0, alturaJovenesF = 0,
                  alturaAdultosM = 0, alturaAdultosF = 0,
                  alturaAncianosM = 0, alturaAncianosF = 0;
            //PROMEDIOS
            float promAlturaNiñosM = 0, promAlturaNiñosF = 0,
                 promAlturaJovenesM = 0, promAlturaJovenesF = 0,
                 promAlturaAdultosM = 0, promAlturaAdultosF = 0,
                 promAlturaAncianosM = 0, promAlturaAncianosF = 0;

            //Cuántas veces se preguntará lo mismo? 4 veces

            for (int i = 1; i <= 4; i++)
            { //LEER
                Console.WriteLine("____________________________________");
                Console.WriteLine("PERSONA " + i);

                Console.WriteLine("Ingrese nombre " + i);
                Console.ReadLine(); //no se usa, no se almacena en variable
                Console.WriteLine("Ingrese sexo (m/f) " + i);
                string sexo = Console.ReadLine();
                Console.WriteLine("Ingrese edad " + i);
                int edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese altura " + i);
                float altura = float.Parse(Console.ReadLine());

                //ORGANIZAR LA INFORMACIÓN 
                //NIÑOS
                if (edad >= 0 & edad <= 12)
                {
                    if (sexo.Equals("m")) { cantidadNiñosM++; alturaNiñosM = alturaNiñosM + altura; }
                    else { cantidadNiñosF++; alturaNiñosF = alturaNiñosF + altura; }
                }
                //JÓVENES
                if (edad >= 13 & edad <= 29)
                {
                    if (sexo.Equals("m")) { cantidadJovenesM++; alturaJovenesM = alturaJovenesM + altura; }
                    else { cantidadJovenesF++; alturaJovenesF = alturaJovenesF + altura; }
                }
                //ADULTOS
                if (edad >= 30 & edad <= 59)
                {
                    if (sexo.Equals("m")) { cantidadAdultosM++; alturaAdultosM = alturaAdultosM + altura; }
                    else { cantidadAdultosF++; alturaAdultosF = alturaAdultosF + altura; }
                }
                //ANCIANOS
                if (edad >= 60)
                {
                    if (sexo.Equals("m")) { cantidadAncianosM++; alturaAncianosM = alturaAncianosM + altura; }
                    else { cantidadAncianosF++; alturaAncianosF = alturaAncianosF + altura; }
                }

            }//Fin de for 

            //Procesamiento de datos
            //caso promedio= 0suma/0cantidad colocamos if
            //CATEGORIA NIÑOS
            if (cantidadNiñosM > 0) { promAlturaNiñosM = alturaNiñosM / cantidadNiñosM;}
            if (cantidadNiñosF > 0) { promAlturaNiñosF = alturaNiñosF / cantidadNiñosF;}
            //CATEGORIA JÓVENES
            if (cantidadJovenesM > 0) { promAlturaJovenesM = alturaJovenesM / cantidadJovenesM;}
            if (cantidadJovenesM > 0) { promAlturaJovenesF = alturaJovenesF / cantidadJovenesF;}
            //CATEGORIA ADULTOS
            if (cantidadAdultosM > 0) { promAlturaAdultosM = alturaAdultosM / cantidadAdultosM;}
            if (cantidadAdultosF > 0) { promAlturaAdultosF = alturaAdultosF / cantidadAdultosF; }
            //CATEGORIA ANCIANOS
            if (cantidadAncianosM > 0) { promAlturaAncianosM = alturaAncianosM / cantidadAncianosM;}
            if (cantidadAncianosF > 0) { promAlturaAncianosF = alturaAncianosF / cantidadAncianosF; }
            
            //SALIDA
            Console.WriteLine("______________________________________________");
            Console.WriteLine("PROMEDIO ALTURA CATEGORÍA NIÑOS");
            Console.WriteLine("Masculino: "+promAlturaNiñosM+"\n Femenino: "+promAlturaNiñosF);
            Console.WriteLine("PROMEDIO ALTURA CATEGORÍA JOVENES");
            Console.WriteLine("Masculino: " + promAlturaJovenesM + "\n Femenino: " + promAlturaJovenesF);
            Console.WriteLine("PROMEDIO ALTURA CATEGORÍA ADULTOS");
            Console.WriteLine("Masculino: " + promAlturaAdultosM + "\n Femenino: " + promAlturaAdultosF);
            Console.WriteLine("PROMEDIO ALTURA CATEGORÍA ANCIANOS");
            Console.WriteLine("Masculino: " + promAlturaAncianosM + "\n Femenino: " + promAlturaAncianosF);
            Console.ReadLine();

        }
    }
}
