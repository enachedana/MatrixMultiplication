using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_inmultire_matrici
{
    class Program
    {
              
       
        static void Main(string[] args)
        {        
            Console.Write("Enter p:");
            int p = int.Parse(Console.ReadLine());

            Console.Write("Enter m:");
            int m = int.Parse(Console.ReadLine());
            
            Console.Write("Enter q:");
            int q = int.Parse(Console.ReadLine());

            int[,] a = new int[p, m];
            Random r = new Random();
            for (int i = 0; i < p; i++)
                for (int j = 0; j < m; j++)
                    a[i, j] = r.Next(10);


            Console.WriteLine("Matricea A este: ");
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < m; j++)

                    Console.Write(a[i, j] + " ");
                Console.Write("\n");
            }

            int[,] b = new int[m, p];
            Random t = new Random();
            for (int i = 0; i < m; i++)
                for (int j = 0; j < p; j++)
                    b[i, j] = r.Next(10); 

            Console.WriteLine("Matricea B este: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < q; j++)

                    Console.Write(b[i, j] + " ");
                Console.Write("\n");               
            }

            int[,] c = new int[p, q];
            Console.WriteLine("Matricea inmultita este: ");
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    //c[i, j] = 0;
                    for (int k = 0; k < m; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
    }
}
