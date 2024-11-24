using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DemchenkoAD.Sprint3.Task6.V6.Lib
{
    public class DataService : ISprint3Task6V6
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int count = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                // Проверяем каждое число от 16 до 24 на делители
                for (int d = 1; d <= x; d++)
                {
                    // Если число делится без остатка и делитель больше 10,
                    // увеличиваем счетчик на 1
                    if (x % d == 0 && d > 10)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}
