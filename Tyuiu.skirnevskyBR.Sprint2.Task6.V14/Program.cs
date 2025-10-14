using Tyuiu.skirnevskyBR.Sprint2.Task6.V14.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #2                                               *");
Console.WriteLine("* Тема: Сокращенная форма оператора switch                *");
Console.WriteLine("* Задание #6                                              *");
Console.WriteLine("* Вариант #14                                             *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1     *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Написать программу, которая использует сокращенную      *");
Console.WriteLine("* форму записи оператора switch вычисляет требуемое       *");
Console.WriteLine("* значение и возвращает результат.                        *");
Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким   *");
Console.WriteLine("* днем недели является k-й день не високосного года,      *");
Console.WriteLine("* в котором 1 января d-й день недели (1 - понедельник,    *");
Console.WriteLine("* 2 - вторник, ..., 7 - воскресенье).                     *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

Console.WriteLine("Введите номер дня в году (1-365): ");
int k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите день недели 1 января (1-7): ");
int d = Convert.ToInt32(Console.ReadLine());

string res;

if ((k < 1 || k > 365) || (d < 1 || d > 7))
{
    res = "Введены неверные значения!";
}
else
{
    res = "День недели: " + ds.FindDayName(k, d);
}

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine(res);
Console.ReadKey();