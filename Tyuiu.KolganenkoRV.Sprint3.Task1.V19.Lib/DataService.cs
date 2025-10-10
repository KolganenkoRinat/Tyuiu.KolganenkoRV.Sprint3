using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KolganenkoRV.Sprint3.Task1.V19.Lib
{
    public class DataService : ISprint3Task0V8
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double pro = 1;
            int i;

            for (i = startValue; i <= stopValue; i++)
            {
                pro = pro * (Math.Cos(value) + (i / 4));
            }
            return Math.Round(pro, 3);
        }
    }
}
