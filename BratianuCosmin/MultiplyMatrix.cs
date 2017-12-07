using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatriceaII_Revolutia
{
    class Program
    {
        /*  a[l,c]; b[l,c]conditie a[c] = b[l] 
         *   rez [q,p]+=
         *   Suma de a[i,k] * b[k,j]
         */
        class _Matrix
        {
             public int l;
            public int c;
           // public static int linii { get { return l; } }
            //public static int coloane;
            public int[,] array;
            public static int[,] Multyply(int[,] m1, int[,] m2,int lini,int col)
            {
                int m = lini;
                int n = col;
                int[,] c = new int[m, n];
                
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        for (int k = 0; k < 2; k++)
                        {
                            c[i, j] += m1[i, k] * m2[k, j];
                        }
                    }
                   
                }
                return c;
            }
            
       
            public static _Matrix operator *(_Matrix c1, _Matrix c2)
            {
                if (c1.c == c2.l)
                {
                    int _L = c1.l;
                    int _C = c2.c;
                    int[,] res = new int[_L, _C];
                    res = Multyply(c1.array, c2.array, _L,_C);
                    //calculam linii si coloane new matrix;
                    _Matrix rezult = new _Matrix(_L,_C,res);
                    return rezult;
                }
                else
                {
                    Console.WriteLine("Imposibil de Inmultit!");
                }

                return new _Matrix();
            }
           public _Matrix(int li ,int cj,int[,] _array)
            {
                l = li;
                c = cj;
                array = new int[l, c];
                array = _array;//puteam sa generez aici numerele
            }
            public _Matrix(){ }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("a[l,c]-b[l,c] = >al,ac,bl,bc");
            string str = Console.ReadLine();
            string[] str2 = str.Split('a','b','=','[', ',', ']');
            int[,] a = new int[Convert.ToInt32(str2[0]), Convert.ToInt32(str2[1])];
            int[,] b = new int[Convert.ToInt32(str2[2]), Convert.ToInt32(str2[3])];
            Random r = new Random();
            Console.WriteLine("A\n");
           
            for (int i = 0; i < Convert.ToInt32(str2[0]); i++)
            {
                for(int j = 0;j < Convert.ToInt32(str2[1]);j++)
                {
                    a[i, j] = r.Next(9); Console.Write(" " + a[i, j]);
                }
                Console.WriteLine("");
            }
         
            Console.WriteLine("B\n");
            for (int i = 0; i < Convert.ToInt32(str2[2]); i++)
            {
                for (int j = 0; j < Convert.ToInt32(str2[3]); j++)
                {
                    b[i, j] = r.Next(9); Console.Write(" " + b[i, j]);
                }
                Console.WriteLine("");
            }
            _Matrix A = new _Matrix(Convert.ToInt32(str2[0]), Convert.ToInt32(str2[1]), a);
            _Matrix B = new _Matrix(Convert.ToInt32(str2[2]), Convert.ToInt32(str2[3]), b);
            A.array = a;
            B.array = b;
            _Matrix c = A * B;


            for (int i = 0; i < c.l; i++)
            {
                for (int j = 0; j < c.c; j++)
                {
                    Console.Write(c.array[i, j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

        }
    }
}
