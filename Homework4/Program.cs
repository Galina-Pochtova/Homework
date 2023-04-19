// Задача 1.  Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*int GetSum(int numA, int numB)
{
int new_num = numA;
for (int i = 1; i < numB; i++)
numA = numA * new_num;
return numA;
}

Console.WriteLine("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetSum(numA, numB));
*/

//Задача 2. Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*int GetSum(int num)
{
    int sum = 0;
    int result = 0;
    for(int current = 0; current < num; current++){
        sum = num - num % 10;
        result = result + (num - sum);
        num = num / 10; 
    }
        return result;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = GetSum(num);
Console.WriteLine($"Сумма цифр в числе {num} равна {result}");
*/


//Задача 3. Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/*int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
    }

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArray(size);
ShowArray(newArray);
*/
