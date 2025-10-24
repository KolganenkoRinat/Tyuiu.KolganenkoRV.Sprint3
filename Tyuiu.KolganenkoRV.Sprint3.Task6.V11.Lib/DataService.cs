using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KolganenkoRV.Sprint3.Task6.V11.Lib
{
    public class DataService : ISprint3Task6V11
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int SumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                for (int j = 11; j <= 19; j++)
                {
                    if (i % j == 0)
                    {
                        SumSeries += 1;
                    }
                }
            
            }
            return SumSeries;
        }
    }
}
