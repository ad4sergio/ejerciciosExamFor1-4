using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationfor4
{
    class Program
    {
        static void Main(string[] args)
        { /* 4.Desarrolla un programa para N estudiantes que lea sus notas de un curso.
           * Se sabe la mínima nota es 13.
           * Al final calcule:
            a) la nota mayor
           * b) la nota menor
           * c) promedio de notas del salón
           * d) cantidad de alumnos aprobados
           * e) cantidad de alumnos desaprobados
           * f) porcentaje aprobados
           * g) procentaje desaprobados
           */
            //Nota mayor menor
            int notaMayor=0 , notaMenor=20; 
            
            //cantidad aprobados y desaprobados
            int nAprobados = 0, nDesaprobados = 0;
            //Suma aprobados y desaprobados
            int sumaNotasA = 0, sumaNotasD=0;
            //Porcentaje
            float porcentajeAprobados = 0, porcentajeDesaprobados = 0;
            //total de alumnos
            int totalAlumnos = 4;
            for (int i = 1; i <=totalAlumnos; i++)
            {
                Console.WriteLine("______________________");
                Console.WriteLine("Ingrese nota "+i);
                int nota=int.Parse(Console.ReadLine());
                //Nota mayor y menor
                if (nota > notaMayor) { notaMayor = nota;}
                if (nota < notaMenor) { notaMenor = nota;}
                // Aprobados desaprobados
                if (nota >= 13) { nAprobados++; sumaNotasA = sumaNotasA + nota; }
                else { nDesaprobados++; sumaNotasD = sumaNotasD + nota; }
                                
            }
            //PROCESOS
            float promedioAll= (float)(sumaNotasA+sumaNotasD)/totalAlumnos;

            porcentajeAprobados= (nAprobados*100)/totalAlumnos ;
            porcentajeDesaprobados = (nDesaprobados * 100) / totalAlumnos;
            //SALIDA
            Console.WriteLine("____________________________________________________________________");
            Console.WriteLine("a) Nota mayor: "+ notaMayor);
            Console.WriteLine("b) Nota menor: "+ notaMenor);
            Console.WriteLine("c) promedio de notas del salón: " + promedioAll);
            Console.WriteLine("d) cantidad de alumnos aprobados: "+nAprobados);
            Console.WriteLine("e) cantidad de alumnos desaprobados: "+nDesaprobados);
            Console.WriteLine("f) porcentaje aprobados: " + porcentajeAprobados + "%");
            Console.WriteLine("g) porcentaje desaprobados: " + porcentajeDesaprobados + "%");
            Console.ReadLine();
        }
    }
}
