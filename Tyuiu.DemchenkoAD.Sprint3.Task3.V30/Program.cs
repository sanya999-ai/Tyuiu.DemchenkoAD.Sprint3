using Tyuiu.DemchenkoAD.Sprint3.Task3.V30.Lib;
namespace Tyuiu.DemchenkoAD.Sprint3.Task3.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнила: Демченко А. Д. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:  Оператор цикла foreach                                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнила: Демченко Александра | ИСПб-24-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать максимальное количество букв y,       *");
            Console.WriteLine("*  находящихся на соседних позициях в строке: fyyklbtyn ygrc vfyyyyh      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "fyyklbtyn ygrc vfyyyyh";
            char item = 'y';
            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый символ " + item);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.GetMaxCharCount(value, item);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
