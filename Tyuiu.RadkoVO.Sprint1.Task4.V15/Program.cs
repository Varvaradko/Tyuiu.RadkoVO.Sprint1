using Tyuiu.RadkoVO.Sprint1.Task4.V15.Lib;

namespace Tyuiu.RadkoVO.Sprint1.Task4.V15
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            int x, y;

            Console.WriteLine("Введите знвчение X:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите знвчение Y:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("(x + y ^ 2) / (e ^ (2 - 4 * y)) = " + ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}