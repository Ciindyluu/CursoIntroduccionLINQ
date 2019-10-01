using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Queries sencillos con arreglos y reflexión
            //Ejemplo con números
            int[] numeros = { 1, 5, 7, 3, 5, 9, 8 };
            string[] postres = { "Pay de manzana", "tarta", "pastel", "manzana acaramelada" };

            //Hacemos el query
            IEnumerable<int> valores = from n in numeros
                                       where n > 3 && n < 8
                                       select n;

            IEnumerable<string> encontrados = from p in postres
                                              where p.Contains("manzana")
                                              orderby p
                                              select p;
            //Mostrar resultado
            foreach (int num in valores)
                Console.WriteLine(num);

            foreach (string postre in encontrados)
                Console.WriteLine(postre);
        }

        static void InformacionResultados(object presultados){
            Console.WriteLine("Tipo{0}", presultados.GetType().Name);
            Console.WriteLine("Locacion{0}", presultados.GetType().Assembly.GetName().Name);
        }

    }
}