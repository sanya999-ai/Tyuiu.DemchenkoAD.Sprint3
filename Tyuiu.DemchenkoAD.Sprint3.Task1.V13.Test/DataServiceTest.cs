using Tyuiu.DemchenkoAD.Sprint3.Task1.V13.Lib;
namespace Tyuiu.DemchenkoAD.Sprint3.Task1.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public  void GetMultiplySeries()
        {
            DataService ds = new DataService();

            double value = 1.2;
            int startValue = 1;
            int stopValue = 7;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 164.845;

            Assert.AreEqual(wait, res);
        }
    }
}