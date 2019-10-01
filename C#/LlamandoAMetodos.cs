namespace LINQMeTodoClase03
{
    class Program
    {
        static void Main(string[] args)
        {

            // Obtener resultados de query desde métodos

            // Invocamos el método
            IENumerable<int> resultados = ClaseExplicita.ObtenerNumerosPares();

            // Mostramos los resultados
            foreach (int num in resultados)
                Console.WriteLine(num);

            Console.WriteLine(" ------- ");

            IENumerable<string> postres = ClaseExplicita.ObtenerPostres();

            // Mostramos los resultados
            foreach (string p in postres)
                Console.WriteLine(p);

            Console.WriteLine(" ------- ");

            // Ejemplo de resultado de query inmediato
            int[] impares = ClaseExplicita.ObtenerNumerosImpares();

            // Mostramos los resultados
            foreach (int m in impares)
                Console.WriteLine(m);
                
        }
    }
}