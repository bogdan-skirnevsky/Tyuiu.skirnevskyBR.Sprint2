using Tyuiu.skirnevskyBR.Sprint2.Task5.V6.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #2                                               *");
Console.WriteLine("* Тема: Оператор switch                                   *");
Console.WriteLine("* Задание %5                                              *");
Console.WriteLine("* Вариант #6                                              *");
Console.WriteLine("* Выполнил: Ваше ФИО | Ваша группа                        *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Написать программу, которая использует оператор switch  *");
Console.WriteLine("* вычисляет требуемое значение и возвращает результат.    *");
Console.WriteLine("* Мастям игральных карт условно присвоены номера:         *");
Console.WriteLine("* пики - 1, трефы - 2, бубны - 3, червы - 4               *");
Console.WriteLine("* Достоинству карт: валет - 11, дама - 12, король - 13,   *");
Console.WriteLine("* туз - 14. По заданным номеру масти m (1 <= m <=  4)     *");
Console.WriteLine("* и номеру достоинства карты k (6 <= k <= 14) определить  *");
Console.WriteLine("* полное название карты в виде «Дама пик» и т.п.          *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

Console.WriteLine("Введите номер масти (1-4): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер достоинства (6-14): ");
int k = Convert.ToInt32(Console.ReadLine());

string res;

if ((m < 1 || m > 4) || (k < 6 || k > 14))
{
    res = "Введены неверные значения!";
}
else
{
    res = "Название карты: " + ds.FindCardNameAndValue(m, k);
}

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine(res);
Console.ReadKey();