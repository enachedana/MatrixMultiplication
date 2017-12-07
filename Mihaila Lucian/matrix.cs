using System.IO;
using System.Text;
using System;

class MatrixMultiplication
{
    static int [,] multiply(int[,] matrix1, int[,] matrix2) {
        int[,] m = null;

        if (matrix1 != null && matrix2 != null && 
            matrix1.GetLength(1) == matrix2.GetLength(0)) {

            m = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int linie = 0; linie < matrix1.GetLength(0); linie++) {
                for (int coloanaI = 0; coloanaI < matrix2.GetLength(1); coloanaI++) {
                    for (int coloana = 0; coloana < matrix2.GetLength(0); coloana++) {
                         m[linie, coloanaI] = m[linie, coloanaI] + matrix1[linie, coloana] * matrix2[coloana, coloanaI];
                    }
                }
            }
        }
        else {
           Console.WriteLine("EROARE! Urmatoarea sintaxa trebuie respectata -> MATRIX1 coloane =  MATRIX2 linii");
        }
        return m;
    }
    static void Main()
    {
        string input;
        int[,] result;
        Random x = new Random();
        Console.WriteLine("---Matricea 1 ---\n");
        Console.Write("linii:");
		input = Console.ReadLine();
        int rows =Convert.ToInt32(input);
		Console.Write("coloane:");
		input = Console.ReadLine();
        int cols = Convert.ToInt32(input);

        int[,] matrix1 = new int[rows,cols];
        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                matrix1[r, c] = x.Next(10);  
            }
        }
        for (int r = 0; r < matrix1.GetLength(0); r++)
        {
            for (int c = 0; c < matrix1.GetLength(1); c++)
            {
                Console.Write(matrix1[r, c] + " ");
            }
            Console.WriteLine(" ");
        }
        Console.WriteLine("\n---Matricea 2 ---");
        Console.Write("linii:");
        input = Console.ReadLine();
        int rows2 = Convert.ToInt32(input);
        Console.Write("coloane:");
        input = Console.ReadLine();
        int cols2= Convert.ToInt32(input);
        int[,] matrix2 = new int[rows2,cols2];
        for (int r = 0; r < rows2; r++) {
            for (int c = 0; c < cols2; c++) {
                     matrix2[r,c] = x.Next(10);
            }
        }
        for (int r = 0; r < matrix2.GetLength(0); r++)
        {
            for (int c = 0; c < matrix2.GetLength(1); c++)
            {
                Console.Write(matrix2[r, c] + " ");
            }
            Console.WriteLine(" ");
        }

        result = multiply(matrix1, matrix2);
        if (result != null) {
           Console.WriteLine("\n--- Matricea rezultat ---");
            for (int r = 0; r < result.GetLength(0); r++) {
                for (int c = 0; c < result.GetLength(1); c++) {
                   Console.Write(result[r,c] + " ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
