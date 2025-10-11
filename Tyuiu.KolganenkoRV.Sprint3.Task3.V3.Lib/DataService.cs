using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KolganenkoRV.Sprint3.Task3.V3.Lib
{
    public class DataService : ISprint3Task3V3
    {
        public int GetMinCharCount(string value, char item)
        {
            int minSequence = int.MaxValue;
            int currentSequence = 0;

            foreach (char chr in value)
            {
                if (chr == item)
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence >= 2 && currentSequence < minSequence) // только последовательности из 2+ символов
                    {
                        minSequence = currentSequence;
                    }
                    currentSequence = 0;
                }
            }

            // Проверяем последовательность в конце строки
            if (currentSequence >= 2 && currentSequence < minSequence)
            {
                minSequence = currentSequence;
            }

            // Если не найдено ни одной последовательности из 2+ символов
            if (minSequence == int.MaxValue)
            {
                return 0;
            }

            return minSequence;
        }
    }
}
