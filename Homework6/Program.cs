// Задача 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, 
//сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

// Console.Write("Введите количество чисел ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// for(int i = 0; i < num; i++)
// {
//     Console.Write($"Введите {i+1} число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     if(number > 0)
//     count++;
// }
// Console.WriteLine($"Вы ввели {count} чисел больше нуля");

//Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void LineCrossing(double k1, double b1, double k2, double b2)
// {
//     double x = Math.Round((b2 - b1)/(k1 - k2), 2);
//     double y = Math.Round(k1*((b2 - b1)/(k1 - k2))+b1, 2);
//     Console.Write($"Точка пересечения двух прямых [{x}, {y}]");
// }
// Console.WriteLine("Введите значение k1: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение b1: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение k2: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение b2: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// LineCrossing(b1, k1, b2, k2);

