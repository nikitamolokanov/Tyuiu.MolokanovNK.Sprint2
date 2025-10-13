using Tyuiu.MolokanovNK.Sprint2.Task5.V15.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила : Молоканов Н. К. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("**************************************************************************************************");
Console.WriteLine("* Спринт #1                                                                                      *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                                               *");
Console.WriteLine("* Задание #5                                                                                     *");
Console.WriteLine("* Вариант #15                                                                                    *");
Console.WriteLine("* Выполнил: Молоканов Никита Константинович | ИБКСб-25-1                                         *");
Console.WriteLine("**************************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                                       *");
Console.WriteLine("* Написать программу,                                                                            *");
Console.WriteLine("* которая использует оператор switch вычисляет требуемое значение и возвращает результат.        *");
Console.WriteLine("**************************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                               *");
Console.WriteLine("**************************************************************************************************");

Console.WriteLine("Введите день: ");
int numDay = Convert.ToInt32(Console.ReadLine());

string res;

if ((numDay < 1 ) || (numDay > 12))
{
    res = "Введенно неверное значение!";
}
else
{
    res = "Это день: " + ds.FindDayName(numDay);
}

Console.WriteLine("**************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                     *");


Console.WriteLine(res);


Console.ReadLine();