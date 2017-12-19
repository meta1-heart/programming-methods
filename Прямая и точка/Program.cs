using System;


namespace Прямая_и_точка
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The space dimension is N = 3");
            String s;
            int N = 3;
            // Data input
            Console.WriteLine("Define the Line by two points (insert the coordinates)");
            Console.Write("X1 = ");
            s = Console.ReadLine();
            double x1 = Convert.ToDouble(s);
            Console.Write("Y1 = ");
            s = Console.ReadLine();
            double y1 = Convert.ToDouble(s);
            Console.Write("Z1 = ");
            s = Console.ReadLine();
            double z1 = Convert.ToDouble(s);
            Console.Write("X2 = ");
            s = Console.ReadLine();
            double x2 = Convert.ToDouble(s);
            Console.Write("Y2 = ");
            s = Console.ReadLine();
            double y2 = Convert.ToDouble(s);
            Console.Write("Z2 = ");
            s = Console.ReadLine();
            double z2 = Convert.ToDouble(s);
            Console.WriteLine("Insert coordinates of Point");
            Console.Write("X0 = ");
            s = Console.ReadLine();
            double x0 = Convert.ToDouble(s);
            Console.Write("Y0 = ");
            s = Console.ReadLine();
            double y0 = Convert.ToDouble(s);
            Console.Write("Z0 = ");
            s = Console.ReadLine();
            double z0 = Convert.ToDouble(s);
            // Evaluations
            double a = x1 - x0;
            double b = y1 - y0;
            double c = z1 - z0;
            double n = x1 - x2;
            double k = y1 - y2;
            double m = z1 - z2;
            double numerator = Math.Sqrt(Math.Pow((b*m-k* c),2) + (Math.Pow((a * m - n * c), 2)) + (Math.Pow((a * k - n * b), 2)));
            double denominator = Math.Sqrt(n*n + k*k + m*m);
            double distance = numerator / denominator;
            Console.WriteLine();
            Console.WriteLine("Distance beetwen Line and Point = " + distance);
            Console.WriteLine();
            Console.WriteLine("Parallel vectors are = (" + n + "*t, " + k + "*t, " + m + "*t), where t is Real number (not 0)");
            Console.WriteLine();
            Console.WriteLine("Perpendicular vectors are = (" + "0" + ", " + -m + "*i, " + k + "*i), where i is Real number (not 0)");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
