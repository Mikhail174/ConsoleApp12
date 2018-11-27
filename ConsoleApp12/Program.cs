using System;
using System.Linq;


namespace ConsoleApp12
{
    class Program
    {
        static bool x;
        static void Main(string[] args)
        {
            string a;

            double[] arr = new double[3];
            Console.WriteLine("Введите стороны треугольника:");
            do
            {
                x = false;
                for (int i = 0; i < 3; i++)
                {
                    a = Console.ReadLine();
                    arr[i] = Convert.ToInt32(a);
                }
                if (arr[0] + arr[1] <= arr[2] || arr[1] + arr[2] <= arr[0] || arr[0] + arr[2] <= arr[1])
                {
                    Console.WriteLine("Вы ввели неверные стороны треугольника ");
                    x = true;

                }
            } while (x == true);
            double max = arr.Max();
            double min = arr.Min();
            double avg = 0;
            for (int i = 0; i < 3; i++)
            {
                if (arr[i] < arr.Max() && arr[i] > arr.Min())
                    avg = arr[i];
            }
            if (Math.Pow(max, 2) == Math.Pow(min, 2) + Math.Pow(avg, 2)) Console.WriteLine("Треугольник прямоугльный");
            double p = (min + max + avg) / 2;
            double st = Math.Sqrt(p * (p - min) * (p - avg) * (p - max));
            double r = Math.Sqrt(((p - min) * (p - avg) * (p - max)) / p);
            double so = Math.PI * Math.Pow(r, 2);
            if (!x)
            {
                Console.WriteLine("Площадь треугольника равна " + st);
                Console.WriteLine("Радиус вписанной окружности равен: " + r);
                Console.WriteLine("Площадь окружности равна " + so);
            }
            Console.ReadKey();




        }
    }
}
