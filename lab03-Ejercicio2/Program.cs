namespace lab03_Search;
class Program
{
    static void Main(string[] args)
    {

        {
            //EJERICIO 1
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            int[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24, 34, 90, 87, 44, 33, 21, 47, 1, 4, 9, 7 };

            Console.WriteLine("Arreglo desordenado: ");

            // Ordenando el numero Desordanado
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine($"A[{i}]={A[i]}, ");
            }

            Console.Write("Ingrese el numero a buscar: ");
            int valorLeido = Convert.ToInt32(Console.ReadLine());

            int posicionEncontrada = BusquedaLinealID(A, A.Length, valorLeido);
            Console.WriteLine("Elemento encontrado en posicion: " + posicionEncontrada);

            if (posicionEncontrada != -1)
            {

                Console.WriteLine($"\nElemento encuentrado en A[{posicionEncontrada}]={A[posicionEncontrada]}");


            }
            else
            {
                Console.WriteLine("\nElemento no encontrado");
            }
            watch.Stop();
            Console.WriteLine("Tiempo de Ejecucion: " + watch.ElapsedMilliseconds + " milisegundos");
        }


    }
    static int BusquedaLinealID(int[] A, int n, float clave)
    {
        int i;
        for (i = 0; i < n; i++)
            if (A[i] == clave)
                return i;
        return -1;
    }


}
