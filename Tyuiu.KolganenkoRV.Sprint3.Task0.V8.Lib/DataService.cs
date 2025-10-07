using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KolganenkoRV.Sprint3.Task0.V8.Lib
{
    public class DataService : ISprint3Task0V8
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double pro = 1;
            int i;
            
            for (i = startValue; i <= stopValue; i++)
            {
                pro = pro * ((Math.Pow(value, i) + 1) * Math.Cos(4));
            }
            return Math.Round(pro, 3);
        }
    }
}
