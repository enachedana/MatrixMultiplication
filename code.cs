using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp13_inmultireaADouaMatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, r1, c1, r2, c2, sum = 0;

            int[,] a = new int[50, 50];
            int[,] b = new int[50, 50];
            int[,] prod = new int[50, 50];

            Console.Write("\n\nInmultirea a doua matrice\n");
            Console.Write("----------------------------------\n");

            Console.Write("\nIntroduceti numarul de linii si de coloare ale primei matrice:\n");
            Console.Write("Randuri: ");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Coloane: ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nIntroduceti numarul de lunii si de coloane ale celei de-a doua matrice:\n");
            Console.Write("Linii: ");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Coloane: ");
            c2 = Convert.ToInt32(Console.ReadLine());

            if (c1 != r2)
            {
                Console.Write("Inmultire imposibila.");
                Console.Write("\nNumarul de coloane din prima matrice si numarul de linii din cea de-a doua matrice trebuie sa fie egale.");
            }
            else
            {
                Console.Write("Introduceti elementele primei matrice:\n");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        Console.Write("elementul - [{0}],[{1}] : ", i, j);
                        a[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("Introduceti elementele celei de-a doua matrice :\n");
                for (i = 0; i < r2; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        Console.Write("elementul - [{0}],[{1}] : ", i, j);
                        b[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("\nPrima matrice este :\n");
                for (i = 0; i < r1; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < c1; j++)
                        Console.Write("{0}\t", a[i, j]);
                }

                Console.Write("\nA doua matrice este :\n");
                for (i = 0; i < r2; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < c2; j++)
                        Console.Write("{0}\t", b[i, j]);
                }
                //algoritmul pentru inmultirea a doua matrice
                for (i = 0; i < r1; i++)
                    for (j = 0; j < c2; j++)
                        prod[i, j] = 0;
                for (i = 0; i < r1; i++)    //randul primei matrice
                {
                    for (j = 0; j < c2; j++)    //coloana celei de-a doua matrice
                    {
                        sum = 0;
                        for (k = 0; k < c1; k++)
                            sum = sum + a[i, k] * b[k, j];
                        prod[i, j] = sum;
                    }
                }
                Console.Write("\nRezultatul inmultirii celor doua matrice este : \n");
                for (i = 0; i < r1; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < c2; j++)
                    {
                        Console.Write("{0}\t", prod[i, j]);
                    }
                }
            }
            Console.Write("\n\n");
        }
    }
}
