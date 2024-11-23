using Tyuiu.DemchenkoAD.Sprint3.Task2.V11.Lib;
namespace Tyuiu.DemchenkoAD.Sprint3.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1;
            int stopValue = 15;

            Assert.AreEqual(0.43, ds.GetSumSeries(value, startValue, stopValue));
        }
    }
}