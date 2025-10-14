using Tyuiu.skirnevskyBR.Sprint2.Task4.V27.Lib;

Console.Title = "Спринт #2 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #2                                               *");
Console.WriteLine("* Тема: Тернарный оператор                                *");
Console.WriteLine("* Задание #4                                              *");
Console.WriteLine("* Вариант #27                                             *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович | ИБКСб-25-1     *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение*");
Console.WriteLine("* и использованием тернанрного оператора, где пользователь*");
Console.WriteLine("* вводит значение переменных x,y с клавиатуры.            *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

Console.WriteLine("Введите значение переменной X: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение переменной Y: ");
double y = Convert.ToDouble(Console.ReadLine());

DataService ds = new DataService();
double res = ds.Calculate(x, y);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine("Значение функции = " + res);

Console.ReadKey();