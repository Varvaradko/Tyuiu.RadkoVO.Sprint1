using Tyuiu.RadkoVO.Sprint1.Task3.V18.Lib;

namespace Tyuiu.RadkoVO.Sprint1.Task1.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            double a = 8;
            double b = 10;
            double c = 3;
            Console.WriteLine("Сторона A прямоугольника = " + a);
            Console.WriteLine("Сторона B прямоугольника = " + b);
            Console.WriteLine("Сторона C квадрата = " + c);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество квадратов, которые можно разместить внутри прямоугольника = " + ds.HowManySquares(a, b, c));

            Console.ReadLine();
        }
    }
}