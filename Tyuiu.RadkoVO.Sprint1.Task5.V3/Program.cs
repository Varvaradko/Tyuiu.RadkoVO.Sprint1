using Tyuiu.RadkoVO.Sprint1.Task5.V3.Lib;

namespace Tyuiu.RadkoVO.Sprint1.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
            Console.WriteLine("***********************************************************");

            Console.WriteLine("Введите значение K ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***********************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
            Console.WriteLine("***********************************************************");

            int res = Convert.ToInt32(ds.Calculate(k));
            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}