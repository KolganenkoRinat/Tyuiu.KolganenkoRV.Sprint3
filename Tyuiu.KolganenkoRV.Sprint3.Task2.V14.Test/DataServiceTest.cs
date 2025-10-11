using Tyuiu.KolganenkoRV.Sprint3.Task2.V14.Lib;

namespace Tyuiu.KolganenkoRV.Sprint3.Task2.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 11;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 1.83;
            Assert.AreEqual(wait, res);
        }
    }
}
