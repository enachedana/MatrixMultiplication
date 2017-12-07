using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_saipem_12_matrixmultiplication
{
    class Program
    {
        static void GenerateMatrixData (ref int[,] mat)
        {
            int lines = mat.GetLength(0);
            int columns = mat.GetLength(1);
            Random r = new Random();

            for (int i = 0; i < lines; i++)
                for (int j = 0; j < columns; j++)
                    mat[i, j] = r.Next(5);
        }

        static int[,] MultiplyMatrices (int[,] A, int[,] B)
        {
            int p = A.GetLength(0);
            int m = A.GetLength(1);
            int q = B.GetLength(1);
            int[,] result = new int[p,q];
            for (int i = 0; i < p; i++)
                for (int j = 0; j < q; j++)
                {
                    int suma = 0;
                    for (int k = 0; k < m; k++)
                        suma += A[i, k] * B[k, j];
                    result[i, j] = suma;
                }
            return result;
        }

        static void DisplayMatrix(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write(a[i, j] + " ");
                Console.Write("\n");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Introduceti total linii matricea A (p): ");
            int p = int.Parse (Console.ReadLine());
            Console.Write("Introduceti total coloane matricea A (m): ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Introduceti total coloane matricea B (q): ");
            int q = int.Parse(Console.ReadLine());

            //generate matrices
            int[,] A = new int[p, m];
            GenerateMatrixData(ref A);
            int[,] B = new int[m, q];
            GenerateMatrixData(ref B);

            Console.WriteLine("Matricea A: ");
            DisplayMatrix(A);
            Console.WriteLine("Matricea B: ");
            DisplayMatrix(B);
            Console.WriteLine("Inmultirea celor doua matrici: ");
            DisplayMatrix(MultiplyMatrices(A, B));
        }
    }
}
