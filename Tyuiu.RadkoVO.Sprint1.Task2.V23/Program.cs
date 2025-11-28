using Tyuiu.RadkoVO.Sprint1.Task2.V23.Lib;

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

            int x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("X минут, переведенные в секунды =" + ds.ConvertMinutesToSeconds(x));

            Console.ReadLine();
        }
    }
}
