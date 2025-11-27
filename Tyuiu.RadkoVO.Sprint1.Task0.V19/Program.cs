using Tyuiu.RadkoVO.Sprint1.Task0.V19.Lib;
namespace Tyuiu.RadkoVO.Sprint1.Task0.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #0 | Выполнил: Радько В. О. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                                ");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                         ");
            Console.WriteLine("* Задание #0                                                               ");
            Console.WriteLine("* Вариант #19                                                              ");
            Console.WriteLine("* Выполнил: Радько Варвара Олеговна | СМАРТб-25-1                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 ");
            Console.WriteLine("* Написать консольную программу, которая вычисляет выражение 4/2*5/(3+2)*5 ");
            Console.WriteLine("* и печатает результат на экране.                                          ");
            Console.WriteLine("*                                                                          ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* 4/2*5/(3+2)*5                                                            ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }
    }
}
