using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DemchenkoAD.Sprint3.Task1.V13.Lib
{
    public class DataService : ISprint3Task1V13
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double result = 1;
            int i = 1;
            while ((i <= stopValue) && (startValue <= i))
            {
                result *= Math.Pow(value, i);
                i++;
            }
            return Math.Round(result, 3);
        }
    }
}
