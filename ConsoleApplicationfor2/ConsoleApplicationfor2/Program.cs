using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationfor2
{
    class Program
    {
        static void Main(string[] args)
        {/* 2. INGRESAR PROMEDIO FINAL DE UN CURSO DE "N" ALUMNOS. CALCULAR LA CANTIDAD DE ALUMNOS 
* PÉSIMO MALO REGULAR BUENO Y EXCELENTE. ASÍ COMO PROMEDIO GENERAL DEL GRUPO SEGÚN TABLA: 
   * 1PÉSIMO=0-5
   * 2MALO=6-12
   * 3REGULAR=13-14 
   * 4BUENO=15-17
   * 5EXCELENTE=18 a más
    */
            /*ANÁLISIS
             * N será 4
             * GRUPOS: son 5 de pésimo hasta excelente 
             * MOSTRAR: Cantidad y promedio de cada grupo
             * Necesitamos: Contador y Acumulador (promedio es el resltado de acumulador/contador) 
             */


            //Resolución ejercicio 2

            //variables CONTADOR (inicialización en 0)
            int cantidadPesimo = 0, cantidadMalo = 0, cantidadRegular = 0, cantidadBueno = 0, cantidadExcelente = 0;
            //variables ACUMULADOR (Sumas de notas de cada grupo)
            int sumaPesimo = 0, sumaMalo = 0, sumaRegular = 0, sumaBueno = 0, sumaExcelente = 0;
            //Variables Promedio
            double promedioPesimo = 0, promedioMalo = 0, promedioRegular = 0, promedioBueno = 0, promedioExcelente = 0;

            //¿Cuántas veces se ejecutará? 4
            for (int i = 1; i <= 4; i++)
            { //LEER 4 veces las notas
                Console.WriteLine("_________________________");
                Console.WriteLine("Ingresar nota n° " + i);
                int nota = int.Parse(Console.ReadLine());

                //ORGANIZAR LOS DATOS A LOS GRUPOS DE NOTAS
                //if (condición) contar más uno; sumar notas
                //Pasimo
                if (nota >= 0 & nota <= 5)
                { cantidadPesimo++; sumaPesimo = sumaPesimo + nota; }
                //Malo
                if (nota >= 6 & nota <= 12)
                { cantidadMalo++; sumaMalo = sumaMalo + nota; }
                //Regular
                if (nota >= 13 & nota <= 14)
                { cantidadRegular++; sumaRegular = sumaRegular + nota; }
                //Bueno
                if (nota >= 15 & nota <= 17)
                { cantidadBueno++; sumaBueno = sumaBueno + nota; }
                //Excelente
                if (nota >= 18 )
                { cantidadExcelente++; sumaExcelente = sumaExcelente + nota; }

            }//FIN DEL for
            //PROCESAMOS LOS DATOS A MOSTRAR
            //PROMEDIOS= SUMA/CANTIDAD
            /*NOTA: Hay datos con 0, darían error al dividir entre 0, para evitarlo:
             *Pondremos un if para que se saque promedio si se ingreso un dato al grupo. 
             */
            if (cantidadPesimo >= 1) { promedioPesimo = sumaPesimo / cantidadPesimo; }
            if (cantidadMalo >= 1) { promedioMalo = sumaMalo / cantidadMalo; }
            if (cantidadRegular >= 1) { promedioRegular = sumaRegular / cantidadRegular; }
            if (cantidadBueno >= 1) { promedioBueno = sumaBueno / cantidadBueno; }
            if (cantidadExcelente >= 1) { promedioExcelente = sumaExcelente / cantidadExcelente; }

            //SALIDA DE DATOS
            Console.WriteLine("_____________________________________________");
            Console.WriteLine("1) PÉSIMO: \n Cantidad: " + cantidadPesimo + "\n Promedio: " + promedioPesimo);
            Console.WriteLine("2) MALO: \n Cantidad: " + cantidadMalo + "\n Promedio: " + promedioMalo);
            Console.WriteLine("3) REGULAR: \n Cantidad: " + cantidadRegular + "\n Promedio: " + promedioRegular);
            Console.WriteLine("4) BUENO: \n Cantidad: " + cantidadBueno + "\n Promedio: " + promedioBueno);
            Console.WriteLine("5) EXCELENTE: \n Cantidad: " + cantidadExcelente + "\n Promedio: " + promedioExcelente);
            Console.ReadKey();
        }
    }
}
