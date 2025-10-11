using Tyuiu.KolganenkoRV.Sprint3.Task3.V3.Lib;

namespace Tyuiu.KolganenkoRV.Sprint3.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "cvbmzff orffgtrr dkfvfffdr";
            char chr = 'f';
            int res = ds.GetMinCharCount(str, chr);
            int wait = 8;
            Assert.AreEqual(wait, res);

        }
    }
}
