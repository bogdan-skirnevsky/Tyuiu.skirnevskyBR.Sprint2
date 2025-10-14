using Tyuiu.skirnevskyBR.Sprint2.Task3.V4.Lib;

Console.Title = "Спринт #1 | Выполнил: Скирневский Б.Р. | ИБКСб-25-1";
Console.WriteLine("***********************************************************");
Console.WriteLine("* Спринт #2                                               *");
Console.WriteLine("* Тема: Вложенные операторы if - else                     *");
Console.WriteLine("* Задание #3                                              *");
Console.WriteLine("* Вариант #4                                              *");
Console.WriteLine("* Выполнил: Скирневский Богдан Романович  | ИБКСб-25-1    *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                *");
Console.WriteLine("* Написать программу, которая вычисляет требуемое значение*");
Console.WriteLine("* функции Y с использованием вложенных оператор if-else,  *");
Console.WriteLine("* где пользователь вводит значение переменной X.          *");
Console.WriteLine("* Округлить полученное значение до трех знаков.           *");
Console.WriteLine("***********************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                        *");
Console.WriteLine("***********************************************************");

Console.WriteLine("Введите значение переменной X: ");
double x = Convert.ToDouble(Console.ReadLine());
DataService ds = new DataService();
double res = ds.Calculate(x);

Console.WriteLine("***********************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                              *");
Console.WriteLine("***********************************************************");

Console.WriteLine("Значение функции = " + res);

Console.ReadKey();