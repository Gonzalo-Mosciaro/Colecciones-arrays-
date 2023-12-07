namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 2] { { 5, 4 }, { 99, 20 }, { 15, 12 } };

            int sumaFila;
            int sumaColumna;
            int sumaGeneral;
            float promedioFila;
            float promedioGeneral;
            float promedioColumna;

            sumaGeneral = 0;
            for( int i = 0 ; i < matriz.GetLength(0); i++)
            {
                sumaFila = 0;
                for( int j = 0; j < matriz.GetLength(1); j++) 
                {
                    sumaFila += matriz[i, j];
                    sumaGeneral += matriz[i, j];
                    Console.WriteLine($"{matriz[i, j]}\t");
                }
                promedioFila = (float)sumaFila / matriz.GetLength(1);

                Console.WriteLine($"Tot fila {i+1}: {sumaFila}\t Prom: {promedioFila}\t");
                Console.WriteLine("\n");
            }

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                sumaColumna = 0;
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    sumaColumna += matriz[i, j];
                    Console.WriteLine($"{matriz[i, j]}\t");
                }
                promedioColumna = (float)sumaColumna / matriz.GetLength(0);

                Console.WriteLine($"Tot colum {j + 1}: {sumaColumna}\t Prom: {promedioColumna}\t");
                Console.WriteLine("\n");
            }


            promedioGeneral = (float)sumaGeneral / matriz.Length;

            Console.WriteLine($"\nTotal gral: {sumaGeneral}\t Promedio gral: {promedioGeneral}\n");
        }
    }
}