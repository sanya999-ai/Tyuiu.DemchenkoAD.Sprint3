using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.DemchenkoAD.Sprint3.Task3.V22.Lib
{
    public class DataService : ISprint3Task0V22
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double MulSeries = 1;
            for (int i = startValue; i < stopValue + 1; i++)
            {
                MulSeries *= ((Math.Pow(value, i) + 4) * Math.Cos(value));
            }
            return double.Round(MulSeries, 3); ;
        }
    }
}
