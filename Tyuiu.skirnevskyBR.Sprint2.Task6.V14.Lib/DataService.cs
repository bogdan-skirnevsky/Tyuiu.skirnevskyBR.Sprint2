using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.skirnevskyBR.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            if (k < 1 || k > 365)
                throw new ArgumentException($"День года должен быть от 1 до 365. Значение {k}");

            if (d < 1 || d > 7)
                throw new ArgumentException($"День недели 1 января должен быть от 1 до 7. Значение {d}");
            
            int dayOfWeek = (d + k - 2) % 7 + 1;

            string result = dayOfWeek switch
            {
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье",
                _ => throw new ArgumentException($"Некорректный расчет дня недели: {dayOfWeek}")
            };

            return result;
        }
    }
}