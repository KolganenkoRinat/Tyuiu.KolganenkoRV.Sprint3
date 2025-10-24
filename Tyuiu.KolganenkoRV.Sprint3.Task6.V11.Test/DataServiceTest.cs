using Tyuiu.KolganenkoRV.Sprint3.Task6.V11.Lib;

namespace Tyuiu.KolganenkoRV.Sprint3.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 10;
            int stopValue = 19;
            double res = ds.GetSumTheDivisors(startValue, stopValue);
            double wait = 135;
            Assert.AreEqual(wait, res);
        }
    }
}
