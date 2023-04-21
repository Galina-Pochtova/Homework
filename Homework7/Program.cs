// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
// {
//     double[,] array = new double[rows, colums]; 

//     for(int i = 0; i < rows; i++) 
//         for(int j = 0; j < colums; j++)   
//             array[i, j] = Math.Round(Convert.ToDouble(new Random().Next(minValue, maxValue + 1) + new Random().NextDouble()), 2);   
    
//     return array; 
// }

// void Show2dArray(double[,] array) 
// {                               
//      for(int i = 0; i < array.GetLength(0); i++)  
//           {
//             for(int j = 0; j < array.GetLength(1); j++) 
//                Console.Write(array[i,j] + " ");      

//                Console.WriteLine();  
//           }      
//           Console.WriteLine(); 
// }
// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцовв ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение: ");
// int maxValue = Convert.ToInt32(Console.ReadLine()); 
// double[,] muArray = CreateRandom2dArray(rows, colums, minValue, maxValue); 
// Show2dArray(muArray); 


// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

// int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, colums]; 

//     for(int i = 0; i < rows; i++) 
//         for(int j = 0; j < colums; j++)   
//             array[i,j] = new Random().Next(minValue, maxValue +1);   
    
//     return array; 
// }

// void Show2dArray(int[,] array) 
// {                               
//      for(int i = 0; i < array.GetLength(0); i++)   
//           {
//             for(int j = 0; j < array.GetLength(1); j++) 
//                Console.Write(array[i,j] + " ");      

//                Console.WriteLine();  
//           }      
//           Console.WriteLine(); 
// }

// void ElementsValue(int[,] array, int numberRows, int numberColums)
// {
//     if(numberRows>= 0 && numberRows <= array.GetLength(0)-1 && numberColums >= 0 && numberColums <= array.GetLength(1)-1)
//     Console.Write($"Значение элемента: {array[numberRows, numberColums]}. ");
//     else
//     Console.Write("Такого элемента не существует. ");
// }

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцовв ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение: ");
// int maxValue = Convert.ToInt32(Console.ReadLine()); 


// Console.Write("Введите, строку в которой находится элемент: ");
// int numberRows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите, столбец в котором находится элемент: ");
// int numberColums = Convert.ToInt32(Console.ReadLine());
// int[,] muArray = CreateRandom2dArray(rows, colums, minValue, maxValue); 
// Show2dArray(muArray); 

// ElementsValue(muArray, numberRows, numberColums);


// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее 
//арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int[,] CreateRandom2dArray()
// {
// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцовв ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальное значение: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальное значение: ");
// int maxValue = Convert.ToInt32(Console.ReadLine()); 
//     int[,] array = new int[colums, colums]; 

//     for(int i = 0; i < colums; i++) 
//         for(int j = 0; j < colums; j++)   
//             array[i,j] = new Random().Next(minValue, maxValue +1);   
    
//     return array; 
// }

// void Show2dArray(int[,] array) 
// {                               
//      for(int i = 0; i < array.GetLength(0); i++)   
//           {
//             for(int j = 0; j < array.GetLength(1); j++) 
//                Console.Write(array[i,j] + " ");      

//                Console.WriteLine();  
//           }      
//           Console.WriteLine(); 
// }

// double[] AverageColums(int[,] array)
// {
//     double[] arrayAverage = new double [array.GetLength(1)];
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             arrayAverage[j] += array[i,j];
//         }
//         arrayAverage[j] = Math.Round(arrayAverage[j] / array.GetLength(0), 1);
//         Console.Write(arrayAverage[j] + " ");
//     }
//     return arrayAverage;
// }
// int[,] muArray = CreateRandom2dArray();
// Show2dArray(muArray); 
// Console.WriteLine($"Среднее арифметическое каждого столбца: ");
// AverageColums(muArray);


