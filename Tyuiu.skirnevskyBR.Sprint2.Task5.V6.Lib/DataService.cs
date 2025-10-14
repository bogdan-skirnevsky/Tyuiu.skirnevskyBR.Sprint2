using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.skirnevskyBR.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6
    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            if (value1 < 1 || value1 > 4)
                throw new ArgumentException($"Масть должна быть от 1 до 4. Значение {value1}");

            if (value2 < 6 || value2 > 14)
                throw new ArgumentException($"Достоинство карты должно быть от 6 до 14. Значение {value2}");

            string suit;
            string rank;

            // Определяем масть
            switch (value1)
            {
                case 1:
                    suit = "пик";
                    break;
                case 2:
                    suit = "треф";
                    break;
                case 3:
                    suit = "бубен";
                    break;
                case 4:
                    suit = "черв";
                    break;
                default:
                    throw new ArgumentException($"Неизвестная масть: {value1}");
            }

            // Определяем достоинство
            switch (value2)
            {
                case 6:
                    rank = "шестерка";
                    break;
                case 7:
                    rank = "семерка";
                    break;
                case 8:
                    rank = "восьмерка";
                    break;
                case 9:
                    rank = "девятка";
                    break;
                case 10:
                    rank = "десятка";
                    break;
                case 11:
                    rank = "валет";
                    break;
                case 12:
                    rank = "дама";
                    break;
                case 13:
                    rank = "король";
                    break;
                case 14:
                    rank = "туз";
                    break;
                default:
                    throw new ArgumentException($"Неизвестное достоинство: {value2}");
            }

            return $"{rank} {suit}";
        }
    }
}