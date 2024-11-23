using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DemchenkoAD.Sprint3.Task2.V11.Lib
{
    public class DataService : ISprint3Task2V11
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double res = 0;
            do
            {
                res += Math.Pow((1.0 / (3 + Math.Pow(value, startValue))), startValue);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(res, 3);
        }
    }
}
