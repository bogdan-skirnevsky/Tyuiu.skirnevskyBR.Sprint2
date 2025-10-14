using Tyuiu.skirnevskyBR.Sprint2.Task7.V7.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #2                                               *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту *");
Console.WriteLine("* Задание #7                                              *");
Console.WriteLine("* Вариант #7                                              *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович  | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Написать программу на C#, которая запрашивает исходные  *");
Console.WriteLine("* данные (вещественные значения) и вычисляет, находится   *");
Console.WriteLine("* ли точка с координатами X,Y в заштрихованной области.   *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

Console.WriteLine("Введите значение переменной X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение переменной Y: ");
double y = Convert.ToDouble(Console.ReadLine());

bool res = ds.CheckDotInShadedArea(x, y);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

if (res)
{
    Console.WriteLine("Точка находится в заштрихованной области");
}
else
{
    Console.WriteLine("Точка НЕ находится в заштрихованной области");
}

Console.ReadKey();