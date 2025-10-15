using Tyuiu.skirnevskyBR.Sprint2.Task0.V11.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #2                                               *");
Console.WriteLine("* Тема: Операции сравнения                                *");
Console.WriteLine("* Задание #0                                              *");
Console.WriteLine("* Вариант #11                                             *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1     *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Написать программу, из операций сравнений               *");
Console.WriteLine("* ==, !=, <, >, <=, >= и арифметических выражений,        *");
Console.WriteLine("* которая вернет логическую последовательность(массив):   *");
Console.WriteLine("* True, False, True, False, True, False                   *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* x = 8105, y = 275                                       *");
Console.WriteLine("***********************************************************");

int x = 8105;
int y = 275;
bool[] res = new bool[6];
res = ds.GetCompareOperations(x, y);

Console.WriteLine("X = " + x);
Console.WriteLine("Y = " + y);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadLine();