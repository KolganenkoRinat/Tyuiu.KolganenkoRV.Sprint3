using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KolganenkoRV.Sprint3.Task1.V19.Lib
{
    public class DataService : ISprint3Task1V19
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double pro = 1;

            while (startValue <= stopValue)
            {
                pro = pro * (Math.Cos(value) + (startValue / 4.0));
                startValue++;
            }
            return Math.Round(pro, 3);
        }
    }
}
