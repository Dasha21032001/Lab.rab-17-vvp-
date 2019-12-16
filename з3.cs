using System;

namespace з3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[N];
            int i, j, k = 1, m = 0, a = 0, b = 0, c = 0, d = 1;
            Console.WriteLine("Введите K");
            int K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы массива");
            for (i = 0; i < N; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < N; i++)
            {
                if (i != N - 1)
                {
                    if (A[i] == A[i + 1])
                    {
                        k++;
                    }
                    else
                    {
                        m++;
                        if (m == K)
                        {
                            b = k;
                            a = A[i];
                        }
                        k = 1;
                    }
                }
                else
                {
                    c = A[i];
                    j = N - 2;
                    while (A[i] == A[j])
                    {
                        d++;
                        j--;
                    }
                }
            }
            m = 0;
            i = 0;
            while (m != K - 1)
            {
                Console.Write(A[i] + " ");
                if (A[i] != A[i + 1]) m++;
                i++;
            }
            for (j = 0; j < d; j++)
            {
                Console.Write(c + " ");
            }
            i++;
            while (A[i] != c)
            {
                Console.Write(A[i] + " ");
                i++;
            }
            for (j = 0; j < b; j++)
            {
                Console.Write(a + " ");
            }
            Console.ReadLine();
            
        }
    }
}
