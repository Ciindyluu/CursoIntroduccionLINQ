using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQClase04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uso de LINQ con clases

            // Creamos una lista
            List<CEstudiante> estudiantes = new List<CEstudiante>
            {
                new CEstudiante("Cindy", "A100", "Educación Especial", 10.0),
                new CEstudiante("Fernando", "A101", "Ingeniería en Sistemas Computacionales", 9.0),
                new CEstudiante("Irma", "A102", "Mercadotecnia", 8.0)
            };

            // Encontramos a los reprobados
            var reprobados = from e in estudiantes
                             where e.Promedio <= 5.0 // aquí trabajamos con una propiedad
                             select e;

            // Mostramos
            Console.WriteLine("Reprobados");
            foreach (CEstudiante r in reprobados)
                Console.WriteLine(r);

            // Mostramos sólo un atributo de los encontrados por medio de la propiedad
            Console.WriteLine("Sólo un atributo");
            foreach (CEstudiante r in reprobados)
                Console.WriteLine(r.Nombre);

            // Encontramos sólo los nombres de los de mercadotecnia

            var mercadotecnia = from e in estudiantes
                                where e.Curso == "Mercadotecnia"
                                select e.Nombre;

            Console.WriteLine("Nombres de Mercadotecnia");
            foreach (string n in mercadotecnia)
                Console.WriteLine(n);
                
        }
    }
}