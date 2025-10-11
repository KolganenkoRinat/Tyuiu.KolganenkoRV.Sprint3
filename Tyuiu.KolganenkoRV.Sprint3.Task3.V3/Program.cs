using Tyuiu.KolganenkoRV.Sprint3.Task3.V3.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #3 | Выполнила : Колганенко Р. В. | ИБКСб-25-1";
//Длина строки 75 символов
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #3                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнил: Колганенко Ринат Витальевич | ИБКСб-25-1                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Используя цикл foreach подсчитать минимальное количество букв f,        *");
Console.WriteLine("* находящихся на соседних позициях в строке: cvbmzff orffgtrr dkfvfffdr   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string value = "cvbmzff orffgtrr dkfvfffdr";
char chr = 'f';

Console.WriteLine("Исходная строка = " + value);
Console.WriteLine("Искомый символ = " + chr);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Количество символов = " + ds.GetMinCharCount(value, chr));
Console.ReadKey();
