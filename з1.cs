using System;

namespace з1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов в массиве:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[1000];
            int[] B = new int[1000];
            int[] C = new int[1000];
            int i;
            Console.WriteLine("Введите элементы массива: ");
            for (i = 0; i < N; i++)
            {
                int c = Convert.ToInt32(Console.ReadLine());
                A[i] = c;
            }
           int a =0, l=0, k = 0;
            for ( i = 0; i < N; i++)
            {
                if (A[i + 1] == A[i])
                {
                    a++;
                }
                else
                {
                    l = a;
                   int num = A[i];
                    l++;
                    B[k] = l;
                    C[k] = num;
                    k++;
                    a = 0;
                }
            }
            Console.WriteLine("Массив из длин серий:");
            for (i = 0; i < k; i++)
            {
                Console.WriteLine(" " + B[i]);
            }
            Console.WriteLine("Массив из элементов:");
            for (i = 0; i < k; i++)
            {
                Console.WriteLine(" " + C[i]);
            }
            Console.ReadLine();
        }
    }
}
