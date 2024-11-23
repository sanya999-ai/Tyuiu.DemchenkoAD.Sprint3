using Tyuiu.DemchenkoAD.Sprint3.Task3.V22.Lib;
namespace Tyuiu.DemchenkoAD.Sprint3.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 8;
            var res = ds.GetMultiplySeries(value, startValue, stopValue);
            Assert.AreEqual(0, res);
        }
    }
}