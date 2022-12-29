namespace Lab03_Search0._1;
class Program
{
    static void Main(string[] args)
    {

        //Console.WriteLine("Ingrese el numero de nuymeros que desea generar");

        //int n = int.Parse(Console.ReadLine()); 

        int n = 100; //numerod de numeros que se van a generar, el conjunto universo
        int n2 = 50;  // numero de nuermos que se gneran para buscar dentro de n
        float numerosEncontrados = 0;
        float numerosNoEncontrados = 0;
        int[] A = new int[n]; // A: NUMEROS GENERADOS Universo 
        int[] B = new int[n2]; // B: NUMEROS GENERADOS para busqueda
        int[] C = new int[n2];

        // GENERA CONJUNTO UNIVERSO DE 100 NUMEROS
        Console.WriteLine("\nGENERA 100 NUMEROS ALEATORIOS\n ");
        for (int i = 0; i < A.Length; i++)
        {

            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            int seed = int.Parse(justNumbers.Substring(0, 4));

            Random random1 = new Random(seed);
            A[i] = random1.Next(0, 200);

            Console.WriteLine($"\tIteración {i} -Semilla {seed} - valor {A[i]}");

        }

        // GENERA UN CONJUNTO DE 50 NUMEROS PARA LA BUSQUEDA
        Console.WriteLine("\nGENERA 50 NUMEROS ALEATORIOS PARA BUSQUEDA\n ");

        for (int i = 0; i < B.Length; i++)
        {

            var guid = Guid.NewGuid();
            var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
            int seed = int.Parse(justNumbers.Substring(0, 4));

            Random random2 = new Random(seed);
            B[i] = random2.Next(0, 200);

            Console.WriteLine($"\tIteración {i} -Semilla {seed} - valor {B[i]}");

        }

        //ORDENAMIENTO DE LISTAS 

        Array.Sort(A); // ORDENA LA LISTA A
        Array.Sort(B); // ORDENA LA LISTA B

        //IMPRESION DE RESULTADOS DE BUSQUEDA

        Console.WriteLine("\nRESULTADOS DE BUSQUEDA\n ");

        for (int i = 0; i < B.Length; i++)
        {
            int posicionEncontrada = busquedaBinaria(A, A.Length, B[i]);

            if (posicionEncontrada != -1)
            {
                numerosEncontrados += 1;
            }
            else
            {
                numerosNoEncontrados += 1;
            }
        }


        Console.WriteLine("\tNumero de búsquedas Exitosas:" + numerosEncontrados);
        Console.WriteLine("\tNumero de búsquedas Fallidas:" + numerosNoEncontrados);


        var Porcentaje = (numerosEncontrados * 2); // obtencion de porcentaje
        var Porcentaje2 = (numerosNoEncontrados * 2);// obtencion de porcentaje


        Console.WriteLine("\tPorcentaje de busquedas con Exito:" + Porcentaje);
        Console.WriteLine("\tPorcentaje de búsquedas Fallidas:" + Porcentaje2);

        // IMPRESION DE LISTAS

        Console.WriteLine("\nLISTA GENERAL");
        Console.WriteLine("");

        for (int i = 0; i < A.Length; i++)

        {
            Console.WriteLine($"\tA[{i + 1}]={A[i]} ");
        }

        Console.WriteLine("\nLISTA DE EXITOS");
        Console.WriteLine("");


        for (int i = 0; i < B.Length; i++)
        {
            int posicionEncontrada = busquedaBinaria(A, A.Length, B[i]);

            if (posicionEncontrada != -1)
            {
                Console.WriteLine($"\tA[{posicionEncontrada + 1}]={A[posicionEncontrada]}");
            }
        }
        Console.WriteLine("");


    }


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


}