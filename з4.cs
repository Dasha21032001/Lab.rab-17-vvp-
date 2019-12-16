using System;

namespace з4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] x = new double[1000];
            double[] y = new double[1000];
            double[] b = new double[1000];
            double N, k;
            int i, l;
            Console.Write("Введите количество точек: ");
            N = int.Parse(Console.ReadLine());
            for (i = 0; i < N; i++)
            {
                Console.Write("Введите координату х " + i + " точки:");
                x[i] = double.Parse(Console.ReadLine());
                Console.Write("Введите координату y " + i + " точки:");
                y[i] = double.Parse(Console.ReadLine());
                b[i] = -99999999;
            }
            for (i = 0; i < N; i++)
            {
                if (x[i] < 0 && y[i] > 0)
                {
                    b[i] = Math.Sqrt(Math.Pow(x[i], 2) + Math.Pow(y[i], 2));
                }
            }
            l = 0;
            k = -9999999;
            for (i = 0; i < N; i++)
            {
                if (b[i] > k)
                {
                    k = b[i];
                    l = i;
                }
            }
            if (l != 0)
            {
                Console.Write("Наиболее удалена от начала координат точка с координатами (" + x[l]+ ", " + y[l]+ "), находящаяся во второй координатной четверти. ");
            }
            else
                Console.Write("(0, 0).");
            Console.ReadLine();
        }
    }
}
