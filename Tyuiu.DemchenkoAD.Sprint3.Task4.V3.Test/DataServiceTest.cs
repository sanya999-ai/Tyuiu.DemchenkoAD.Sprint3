using Tyuiu.DemchenkoAD.Sprint3.Task4.V3.Lib;
namespace Tyuiu.DemchenkoAD.Sprint3.Task4.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double weit = 1.067;
            Assert.AreEqual(weit, res);
        }
    }
}