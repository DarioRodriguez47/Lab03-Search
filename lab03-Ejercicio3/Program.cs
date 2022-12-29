namespace lab03_;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        var watch = new System.Diagnostics.Stopwatch();
        watch.Start();

        int[] A = { -8, 4, 5, 9, 12, 18, 25, 40, 60, 50, 70, 1, 8, 9, 15, 14, 7, 3, 48, 72, 42 };

        //ALGORITMOS PARA MOSTAR DESORDANDO PERO EN POSICIONES 
        Console.WriteLine("Arreglo desordenado: ");

        for (int i = 0; i < A.Length; i++)
        {
            Console.WriteLine($"A[{i}]={A[i]}, ");
        }

        // ALGORITMOS PARA ORDENAMIENTO Y LAPOSICION 
        Array.Sort(A);
        Console.WriteLine("Arreglo ordenado: ");

        for (int i = 0; i < A.Length; i++)

        {

              Console.WriteLine($"A[{i}]={A[i]}, ");

        }

        Console.WriteLine("");



        Console.Write("Ingrese el numero a buscar: ");
        int buscar = int.Parse(Console.ReadLine());



        int posicionEncontrada = busquedaBinaria(A, A.Length, buscar);
        Console.WriteLine("Elemento encontrado en posicion: " + posicionEncontrada);
        watch.Stop();

        Console.WriteLine("\nTiempo de ejecucion: " + watch.ElapsedMilliseconds + " milisegundos");
    }

    // funciones
    static int busquedaBinaria(int[] lista, int n, int clave)
    {
        int central, bajo = 0, alto = n - 1;
        int valorCentral;
        while (bajo <= alto)
        {
            central = (bajo + alto) / 2;    /* indice de elemento central */
            valorCentral = lista[central];  /* valor del indice central */
            if (lista[central] == clave)
                return central;             /* encontrado, devuelve posicion */
            else if (clave < lista[central])
                alto = central - 1;         /* ir a sublista inferior */
            else
                bajo = central + 1;         /* ir a sublista superior */
        }
        return -1;                          /* elemento no encontrado */
    }
    static int BusquedaBinaria(int[] lista, int n, int clave)
    {
        int bajo = 0, alto = n - 1, central = 0;
        bool encontrado = false;
        while ((bajo <= alto) && (!encontrado))
        {
            central = (bajo + alto) / 2;
            if (lista[central] == clave)
                encontrado = true;               // éxito en la búsqueda
            else if (clave < lista[central])     // a lo bajo del central
                alto = central - 1;
            else                                 // a la alto del central
                bajo = central + 1;
        }
        return encontrado ? central : -1;        // central si encontrado -1 otro caso

    }
}

