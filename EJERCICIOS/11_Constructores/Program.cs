using System;

namespace _11_Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a= new Alumno ();
            a.Id=1;
            a.PrimerNombre="ANTONIO";
            a.SegundoNombre="VILLATORO";
            
            Alumno b= new Alumno ();
            b.Id=2;
            b.PrimerNombre= "DAVID";
            b.SegundoNombre= "BENITEZ";

            Alumno c= new Alumno (3);
            b.PrimerNombre= "PEDRO";

            Alumno d= new Alumno ("JUAN", "JIMENEZ");

            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
            Console.WriteLine(d.PrimerNombre + " " + d.SegundoNombre);
        }
    }
}
