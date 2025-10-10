using Tyuiu.MolokanovNK.Sprint2.Task2.V14.Lib;



    DataService ds = new DataService();

    Console.Title = "Спринт #1 | Выполнила : Молоканов Н. К. | ИБКСб-25-1";
  //Длина строки 75 символов
  Console.WriteLine("*******************************************************************************");
  Console.WriteLine("* Спринт #1                                                                   *");
  Console.WriteLine("* Тема: Базовые навыки работы в C#                                            *");
  Console.WriteLine("* Задание #2                                                                  *");
  Console.WriteLine("* Вариант #14                                                                 *");
  Console.WriteLine("* Выполнил: Молоканов Никита Константинович | ИБКСб-25-1                      *");
  Console.WriteLine("*******************************************************************************");
  Console.WriteLine("* УСЛОВИЕ:                                                                    *");
  Console.WriteLine("* Написать программу которая запрашивает целые значения с клавиатуры и        *");
  Console.WriteLine("* вычисляет находится ли точка с координатами X,Y в заштрихованной области    *");
  Console.WriteLine("*                                                                             *");
  Console.WriteLine("*******************************************************************************");
  Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
  Console.WriteLine("*******************************************************************************");

  Console.WriteLine("Введите значение X:");
  int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите значение Y:");
  int y = Convert.ToInt32(Console.ReadLine());

    bool res = ds.CheckDotInShadedArea(x, y);
    Console.WriteLine("*****************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
  
  if (res)
  {
      Console.WriteLine("Точка находиться в заштрихованной области");
  }
  else
  {
     Console.WriteLine("Точка не находиться в заштрихованной области");
  }

  Console.ReadLine();

