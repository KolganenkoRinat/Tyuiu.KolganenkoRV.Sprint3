using Tyuiu.KolganenkoRV.Sprint3.Task1.V19.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #2 | Выполнила : Колганенко Р. В. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #19                                                              *");
Console.WriteLine("* Выполнил: Колганенко Ринат Витальевич | ИБКСб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение *");
Console.WriteLine("* ряда по формуле, при x = 1                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double value = 1;
int startValue = 1;
int stopValue = 9;
Console.WriteLine("Переменная x = " + value);
Console.WriteLine("Старт шага = " + startValue);
Console.WriteLine("Конец шага = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Произведение рада = " + ds.GetMultiplySeries(value, startValue, stopValue));
Console.ReadKey();
