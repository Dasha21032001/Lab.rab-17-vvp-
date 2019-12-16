using System;

namespace з2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во элементов в массиве:");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[1000];
            int[] B = new int[1000];
            int i;
            Console.WriteLine("Введите элементы массива: ");
            for (i = 0; i < N; i++)
            {
                int c = Convert.ToInt32(Console.ReadLine());
                A[i] = c;
            }
            Console.WriteLine("Введите число L ( L > 0 ):");
            int L = Convert.ToInt32(Console.ReadLine());
            int i2 = -1, a = 1, i3, k = N;

            for (i = 1; i < N; ++i)
            {
                if (A[i - 1] != A[i])
                {
                    if (a > L)
                    {
                        B[++i2] = 0;
                        k -= a - 1;
                    }
                    else
                    {
                        for (i3 = 0; i3 < a; ++i3) B[++i2] = A[i - 1];
                    }
                    a = 0;
                }
                ++a;
            }

            if (a > L)
            {
                B[++i2] = 0;
                k -= a - 1;
            }
            else
            {
                for (i3 = 0; i3 < a; ++i3) B[++i2] = A[i - 1];
            }
            for (i = 0; i < k; ++i) A[i] = B[i];
            for ( i = 0; i < k; i++)
            {
                Console.WriteLine(" " + A[i]);
            }
            Console.ReadLine();
        }
    }
}

