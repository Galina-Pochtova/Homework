
//Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(100, 1000);
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
//     Console.WriteLine();
// }
// int EvenNumbers (int[] array)
// {
//     int num = 0;
//         for (int i = 0; i < array.Length; i++)
//         if(array[i] % 2 == 0) 
//         num++;
//     return num;
// }
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRandomArray(size);
// ShowArray(newArray);

// int result = EvenNumbers(newArray);
// Console.WriteLine($"Количество четных чиссел:  {result}");

//Задача 2. Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] CreateRondomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     array[i] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }
// void ShovArray(int[]array)
// {
//     for (int i = 0; i < array.Length; i++)
//     Console.Write(array[i] + " ");
//     Console.WriteLine();
// }
// int SumElements( int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i+=2)
//         sum += array[i]; // то же самое что sum = sum + array[i]
//         return sum;
// }
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите миниимальное значение " );
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение " );
// int max = Convert.ToInt32(Console.ReadLine());
// int[] newArray = CreateRondomArray(size, min, max);
// ShovArray(newArray);
// int result = SumElements(newArray);
// Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + result) ;

//Задача 3. Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

// double[] GreateRondomArray(int size, int minValue, int maxValue)
// {
//     double[] array = new double[size];
//     for(int i = 0; i < size; i++)
//     array [i] = Math.Round((new Random().Next(minValue, maxValue +1) + new Random().NextDouble()), 2);
//     return array;
// }
// void ShowArray (double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     Console.Write(array[i] + " ");
//     Console.WriteLine();
// }
// double DifferenceBetweenElements(double[] array)
// {
//     double min = array[0], max = array[0];
//     for(int i = 0; i < array.Length; i++)
//     {
//        if (array[i] < min)
//         min = array[i];
//        if (array[i] > max)
//         max = array[i];
//     }
//     Console.WriteLine($"Мaксимальное значение = {max}, минимальное значение = {min}");
//     double difference = max - min;
//     return Math.Round(difference, 2);
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввеедите максимальное значение: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// double[] newArray = GreateRondomArray(size, minValue, maxValue);
// ShowArray(newArray);
// double result = DifferenceBetweenElements(newArray);
// Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {result} " );

