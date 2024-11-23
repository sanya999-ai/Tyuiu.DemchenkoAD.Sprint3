using Tyuiu.DemchenkoAD.Sprint3.Task3.V30.Lib;
namespace Tyuiu.DemchenkoAD.Sprint3.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMaxCharCount()
        {
            DataService ds = new DataService();

            string value = "fyyklbtyn ygrc vfyyyyh";
            char item = 'y';

            int res = ds.GetMaxCharCount(value, item);

            int wait = 4;

            Assert.AreEqual(wait, res);
        }
    }
}