using Tyuiu.skirnevskyBR.Sprint2.Task2.V9.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Скирневский Богдан Романович | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #2                                               *");
Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи      *");
Console.WriteLine("* Задание #2                                              *");
Console.WriteLine("* Вариант #9                                              *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1     *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Написать программу на, которая запрашивает целые        *");
Console.WriteLine("* значения с клавиатуры и вычисляет находится ли точка с  *");
Console.WriteLine("* координатами X,Y в заштрихованной области.              *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");
Console.WriteLine("Введите значение переменной X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение переменной Y: ");
int y = Convert.ToInt32(Console.ReadLine());

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
