using Tyuiu.KolganenkoRV.Sprint3.Task7.V8.Lib;

namespace Tyuiu.KolganenkoRV.Sprint3.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            // Правильные расчетные значения
            double[] valueWaitArray = new double[len];

            // Пересчитанные значения для F(x) = sin(x) + (cos(x)+1)/(2-x) + 2x
            valueWaitArray[0] = -10.46;  // x = -5: sin(-5) + (cos(-5)+1)/(2-(-5)) + 2*(-5)
            valueWaitArray[1] = -8.19;   // x = -4: sin(-4) + (cos(-4)+1)/(2-(-4)) + 2*(-4)
            valueWaitArray[2] = -6.01;   // x = -3: sin(-3) + (cos(-3)+1)/(2-(-3)) + 2*(-3)
            valueWaitArray[3] = -3.90;   // x = -2: sin(-2) + (cos(-2)+1)/(2-(-2)) + 2*(-2)
            valueWaitArray[4] = -1.86;   // x = -1: sin(-1) + (cos(-1)+1)/(2-(-1)) + 2*(-1)
            valueWaitArray[5] = 1.00;    // x = 0:  sin(0) + (cos(0)+1)/(2-0) + 2*0
            valueWaitArray[6] = 1.84;    // x = 1:  sin(1) + (cos(1)+1)/(2-1) + 2*1
            valueWaitArray[7] = 0.00;    // x = 2:  деление на ноль
            valueWaitArray[8] = 5.86;    // x = 3:  sin(3) + (cos(3)+1)/(2-3) + 2*3
            valueWaitArray[9] = 7.76;    // x = 4:  sin(4) + (cos(4)+1)/(2-4) + 2*4
            valueWaitArray[10] = 9.72;   // x = 5:  sin(5) + (cos(5)+1)/(2-5) + 2*5

            double[] res = ds.GetMassFunction(startValue, stopValue);          
            CollectionAssert.AreEqual(valueWaitArray, res);

        }
    }
}
