using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KolganenkoRV.Sprint3.Task2.V14.Lib
{
    public class DataService : ISprint3Task2V14
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double pro = 1;
            do
            {
                pro *= Math.Pow((double)value / startValue, 3);
                startValue++;
            }
            while (startValue <= stopValue);
            return Math.Round(pro, 3);
        }
    }
}
