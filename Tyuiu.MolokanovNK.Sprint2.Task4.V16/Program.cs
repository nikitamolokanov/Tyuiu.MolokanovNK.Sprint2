using Tyuiu.MolokanovNK.Sprint2.Task4.V16.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила : Молоканов Н. К. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("**************************************************************************************************");
Console.WriteLine("* Спринт #1                                                                                      *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                                               *");
Console.WriteLine("* Задание #4                                                                                     *");
Console.WriteLine("* Вариант #16                                                                                    *");
Console.WriteLine("* Выполнил: Молоканов Никита Константинович | ИБКСб-25-1                                         *");
Console.WriteLine("**************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                       *");
Console.WriteLine("* Написать программу,которая вычисляет с использованием тернарного оператора,                    *");
Console.WriteLine("* где пользователь вводит значения  переменных x,z,y                                             *");
Console.WriteLine("**************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                               *");
Console.WriteLine("**************************************************************************************************");

Console.WriteLine("Введите значение X:");
double x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение Y:");
double y = Convert.ToInt32(Console.ReadLine());

double res = ds.Calculate(x, y);

Console.WriteLine("**************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                     *");
Console.WriteLine("Значение функции = " + res);



Console.ReadLine();