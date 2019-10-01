using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQMetodoClase03
{
    class ClaseExplicita
    {
        private static string[] postres = { "Pay de manzana", "Pastel de chocolate", "Manzana acaramelada", "Fresas con crema" };

        // Creamos el query
        // El query no puede usarse de forma implícita
        // Debe de ser estático

        private static IEnumerable<string> encontrados = from p in postres
                                                         where p.Contains("manzana")
                                                         orderby p
                                                         select p;

        // El método regresa y todo se trabaja internamente
        public static IEnumerable<int> ObtenerNumerosPares()
        {
            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };
            IEnumerable<int> pares = from n in numeros
                                     where n % 2 == 0
                                     select n;
            return pares;
        }
        
        // Este método regresa el resultado del query
        public static IEnumerable<string> ObtenerPostres()
        {
            return encontrados;
        }

        // Este método regresa el resultado de un query inmediato
        public static int[] ObtenerNumerosImpares()
        {
            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };
            var resultados = from n in numeros
                             where n % 2 != 0
                             select n;
            
            return resultados.ToArray();
        }

    }
}