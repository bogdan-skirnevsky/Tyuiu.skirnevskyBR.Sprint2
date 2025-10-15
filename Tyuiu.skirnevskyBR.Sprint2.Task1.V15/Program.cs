using Tyuiu.skirnevskyBR.Sprint2.Task1.V15.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнил: СкирневсикйБ.Р. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #2                                               *");
Console.WriteLine("* Тема: Логические операции                               *");
Console.WriteLine("* Задание #1                                              *");
Console.WriteLine("* Вариант #15                                             *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Написать программу, из операций сравнений и             *");
Console.WriteLine("* логических операций, а также и арифметических выражений,*");
Console.WriteLine("* которая вернет логическую последовательность(массив):   *");
Console.WriteLine("* True, False, False, False, False, True                   *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* a = 415, b = 616, c = 134, d = 127                      *");
Console.WriteLine("***********************************************************");

int a = 415;
int b = 616;
int c = 134;
int d = 127;
bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);

Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);
Console.WriteLine("d = " + d);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}
Console.ReadLine();