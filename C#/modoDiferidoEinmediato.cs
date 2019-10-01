using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQArreglo02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Trabajo con tipos implícitos, ejecución diferida, inmediata

            //Ejemplo con números
            //Creamos un arreglo sobre el cual trabajar

            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };

            //Hacemos el query y usamos un tipo implicito por medio de var
            var valores = from n in numeros
                          where n % 2 == 0
                          orderby n
                          select n;
			
			/*var paresMayorque5 = 
				valores
					.Where(val => val>5)
					.Select(val => new {
						Valor = val,
						Por5 = val*5
					});*/
			
			var paresMayorque5 = (
				from num in valores
				where Math.Pow(num,2)>10
				select new {
					Valor = num,
					Por5 = num*5
				}
			);
			
			
			Console.WriteLine("----------");
			foreach (var num in paresMayorque5){
                Console.WriteLine("Valor original: "+num.Valor + " por 5: " + num.Por5);
			}
			
			//Funciones agregadas en LINQ y como funciona Group By en LINQ
			var promedio = valores.Sum()/valores.Count();
			Console.WriteLine("Promedio de valores originales: " + promedio);
			
			// ----------------------------------------------------------------------------------
			
			Console.WriteLine("----------");
            //Mostramos los resultados
            foreach (int num in valores)
                Console.WriteLine(num);

            Console.WriteLine("----------");
            Console.WriteLine("\n");

            // Hacemos reflexión
            InformacionResultados(valores);

            //La expresión de query no se evalua hasta que se itera sobre el arreglo
            //Se puede usar el mismo query y siempre obtenemos el resultado actualizado

            //Modificamos el arreglo
            numeros[1] = 12;

            //Mostramos resultados
            Console.WriteLine("\n");
            Console.WriteLine(" --- Ejecución diferida --- ");
            foreach (int num in valores)
                Console.WriteLine(num);


            // EJECUCIÓN INMEDIATA
            Console.WriteLine("\n");
            Console.WriteLine(" --- Ejecución inmediata --- ");

            // Se ejecuta el query en el momento exacto

            // Guardamos los resultados en un arreglo de tipo entero
            int[] arrayValores = (from n in numeros where n % 2 == 0 orderby n select n).ToArray<int>();

            // Guardamos los resultados en un list
            List<int> listValores = (from n in numeros where n % 2 == 0 orderby n select n).ToList<int>();

            //Mostramos los resultados
            Console.WriteLine("El arreglo");
            foreach (int num in arrayValores)
            Console.WriteLine(num);

            numeros[0] = 28;

            Console.WriteLine(" -------- Se actualiza después de la modificación");

            //Mostramos los resultados
            foreach (int num in arrayValores)
                Console.WriteLine(num);

            Console.WriteLine("La lista");
            Console.WriteLine(" ----- ");

            //Mostramos los resultados
            foreach (int num in listValores)
                Console.WriteLine(num);

        }

        static void InformacionResultados(object presultados)
        {
            Console.WriteLine("Tipo{0}", presultados.GetType().Name);
            Console.WriteLine("Locacion{0}", presultados.GetType().Assembly.GetName().Name);
        }
    }
}