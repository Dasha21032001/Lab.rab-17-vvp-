using System;

namespace з5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, i2=0, j, k;
            double a, b, c, s=-100000;
            double[] x = new double[1000];
            double[] y = new double[1000];
            double[] p = new double[1000];
            int[] A = new int[1000];
            int[] B = new int[1000];
            int[] C = new int[1000];
            Console.Write("Введите количество точек: ");
            N = int.Parse(Console.ReadLine());
            for (i = 0; i < N; i++)
            {
                Console.Write("Введите координату х " + i + " точки:");
                x[i] = double.Parse(Console.ReadLine());
                Console.Write("Введите координату y " + i + " точки:");
                y[i] = double.Parse(Console.ReadLine());
                p[i] = -100000;
            }
            if (N < 3)
                Console.Write("Недостаточное кол-во точек.");
            else
            {
                for (i = 0; i < N - 2; i++)
                {
                    for (j = i; j < N - 1; j++)
                    {
                        for (k = j; k < N; k++)
                        {
                            a = Math.Sqrt((Math.Abs(x[i] - x[j])) * (Math.Abs(x[i] - x[j])) + (Math.Abs(y[i] - y[j]) * (Math.Abs(y[i] - y[j]))));
                            b = Math.Sqrt((Math.Abs(x[j] - x[k])) * (Math.Abs(x[j] - x[k])) + (Math.Abs(y[j] - y[k]) * (Math.Abs(y[j] - y[k]))));
                            c = Math.Sqrt((Math.Abs(x[k] - x[i])) * (Math.Abs(x[k] - x[i])) + (Math.Abs(y[k] - y[i])) * (Math.Abs(y[k] - y[i])));
                            p[i] = a + b + c;
                            A[i] = i;
                            B[i] = j;
                            C[i] = k;
                        }
                    }
                }
                for (i = 0; i < N; i++)
                {
                    if (p[i] > s)
                    {
                        s = p[i];
                        i2 = i;
                    }
                }
                Console.Write("Наибольший периметр у треугольника с вершинами в точках с координатами: (" + x[A[i2]]+ ", " + y[A[i2]]+ "), (" + x[B[i2]]+ ", "+ y[B[i2]]+ "), ("+ x[C[i2]]+ ", "+ y[C[i2]]+ ").");
                Console.Write(" Периметр равен:" + s);
                Console.ReadLine();
            }
        }
    }
}





