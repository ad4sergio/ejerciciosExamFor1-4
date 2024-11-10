using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationfor1
{
    class Program
    {
        static void Main(string[] args)
        { 
 /* 1: INGRESAR EL NOMBRE Y LA EDAD PARA N PERSONAS DESDE TECLADO, EL PROGRAMA DEBE CALCULAR 
 * LA CANTIDAD Y PROMEDIO DE PERSONAS MENORES DE EDAD POR SEXO Y MAYORES DE EDAD POR SEXO. */

            /* ANÁLISIS:
             * a) LA CANTIDAD N PERSONAS SE ASIGNARÁ CON UN VALOR DE: 4
             * (PUEDE VARIAR SEGÚN EL PROGRAMDOR O SER PREGUNTADO AL USER ANTES DEL for)
             * 
             * b) NOMBRES NO SE ALMACENAN PERO SI SE LEEN (MÉTODO READLINE sin asignar variable)
             * 
             * c) SE DEBE ALMACENAR EL SEXO
             * 
             * d) DATOS A MOSTRAR
             * 
             * d.1) GRUPO MENORES (4 VARIABLES)
            *  -MENORES MASCULINO CANTIDAD 
            *  -MENORES MASCULINO PROMEDIO EDADES
            *  |MENORES MASCULINO CANTIDAD
            *  |MENORES FEMENINO PROMEDIO EDADES
            *  
             * d.2) GRUPO MAYORES (4 VARIABLES)
            *  -MAYORES MASCULINO CANTIDAD
            *  -MAYORES MASCULINO PROMEDIO EDADES
            *  |MAYORES MASCULINO CANTIDAD
            *  |MAYORES FEMENINO PROMEDIO EDADES
            *  
           */

            //Variables de salida declaradas con valor "0"
            int  menoresMasculinoCantidad = 0,
                 menoresFemeninoCantidad = 0, 
                 mayoresMasculinoCantidad = 0,
                 mayoresFemeninoCantidad = 0;
            //Variables de Salida promedios con valor "0" 
            double menoresMasculinoPromedio = 0,
                   menoresFemeninoPromedio = 0,
                   mayoresMasculinoPromedio = 0,
                   mayoresFemeninoPromedio = 0;

            //Variables de acumuladores para el for (SUMA de edades según grupo específico)
            int menoresMasculinoSuma = 0,
                menoresFemeninoSuma = 0,
                mayoresMasculinoSuma = 0,
                mayoresFemeninoSuma = 0;
  
            //¿Cúantas veces se ingresarán datos? 4 
            for(int i = 1; i <= 4; i++) 
            { //1. Leemos datos (se ejecutará 4 veces según la condición "i<=4" del for)
             Console.WriteLine("Ingrese Nombre de persona " + i +" :");
              Console.ReadLine(); //Leer nombre pero no se guarda (no es relevante guardarlo)     
             Console.WriteLine("Ingrese sexo (m/f) de persona " + i + " :");
              string sexo = Console.ReadLine(); //Leer y guardar dato del sexo  
             Console.WriteLine("Ingrese edad de persona " + i + " :");
              int edad = int.Parse(Console.ReadLine()); //Leer y guardar dato de la edad  
                            
              //2. Cantidades= contadores
              //3. Promedios: primero se suman todas las edades según grupos específicos 
              //(luego del for se dividirán según la cantidad) 
              // Usaremos if para este caso (también se puede usar switch)  
              // Podemos organizar por sexo m o f, luego por mayores y menores o viceversa
              // Primero clasificaremos por sexo

              //masculinos según mayores y menores, se CONTAR y SUMAR las edades. 
              if (sexo.Equals("m"))
              {     if (edad >= 18) 
                    {mayoresMasculinoCantidad++; mayoresMasculinoSuma=mayoresMasculinoSuma+edad;}
                    else 
                    {menoresMasculinoCantidad++; menoresMasculinoSuma=menoresMasculinoSuma+edad;}
              }
              
              //femeninos según mayores y menores, se CONTAR y SUMAR las edades. 
              if (sexo.Equals("f")) 
              {      if (edad >= 18) 
                     {mayoresFemeninoCantidad++; mayoresFemeninoSuma=mayoresFemeninoSuma+edad;}
                     else 
                     {menoresFemeninoCantidad++; menoresFemeninoSuma=menoresFemeninoSuma+edad;}
              }               

            }//FIN DEL for

        //AHORA HACEMOS EL PROCESO DE DATOS DE SALIDA CON LA INFO OBTENIDA
        //PROMEDIOS = SUMA DE EDADES / CANTIDAD DE EDADES SEGÚN GRUPO 
            //NOTA: Si en cantidad tenemos cero saldrá error al intentar dividir (0/0)
            //Usaremos un if para controlar ese error.
         if (menoresMasculinoCantidad >= 1)
            { menoresMasculinoPromedio = menoresMasculinoSuma / menoresMasculinoCantidad;}
         if (menoresFemeninoCantidad >= 1)
            menoresFemeninoPromedio = menoresFemeninoSuma/menoresFemeninoCantidad;
         if (mayoresMasculinoCantidad >= 1)
         mayoresMasculinoPromedio = mayoresMasculinoSuma / mayoresMasculinoCantidad;
         if (mayoresFemeninoCantidad >= 1)
         mayoresFemeninoPromedio = mayoresFemeninoSuma / mayoresFemeninoCantidad;

        //MOSTRAMOS LOS DATOS        
         Console.WriteLine("GRUPO MENORES");
         Console.WriteLine("a1) MENORES MASCULINO CANTIDAD: "+menoresMasculinoCantidad);
         Console.WriteLine("a2) MENORES MASCULINO PROMEDIO: "+menoresMasculinoPromedio);
         Console.WriteLine("b1) MENORES FEMENINO CANTIDAD:  "+menoresFemeninoCantidad);
         Console.WriteLine("b2) MENORES FEMENINO PROMEDIO:  "+menoresFemeninoPromedio);
         Console.WriteLine("GRUPO MAYORES");
         Console.WriteLine("c1) MAYORES MASCULINO CANTIDAD: " + mayoresMasculinoCantidad);
         Console.WriteLine("c2) MAYORES MASCULINO PROMEDIO: " + mayoresMasculinoPromedio);
         Console.WriteLine("d1) MAYORES FEMENINO CANTIDAD:  " + mayoresFemeninoCantidad);
         Console.WriteLine("d2) MAYORES FEMENINO PROMEDIO:  " + mayoresFemeninoPromedio);

         Console.ReadKey();

      }
    }
}
