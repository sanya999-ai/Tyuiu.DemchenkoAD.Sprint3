using Tyuiu.DemchenkoAD.Sprint3.Task5.V19.Lib;
namespace Tyuiu.DemchenkoAD.Sprint3.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 6;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double weit = 30598.002;
            Assert.AreEqual(weit, res);


        }
    }
}