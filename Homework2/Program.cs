// Tesk 1.  Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

/*int SecontDigit(int num)
{
    int hundreds = num % 100;
    int dozens = hundreds / 10;
    int result = dozens;
    return result;
}

Console.WriteLine($"Imput a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int newNumber = SecontDigit(num);
Console.WriteLine(newNumber);
*/

//Task 2. Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

/*bool WeekNumber(int num)
{
    if (num >= 1 && num <= 5 || num > 8)
    {
        return false;
    }
    else
    {
        return true;
    }
}

Console.WriteLine("Введите цифрой день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(WeekNumber(num));
*/
//Task 3. Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*int ThirdNumber(int num)
{
   if (num < 100)
   {
    return num;
   }
   else
   {
    {
        while(num > 100)
        num = num / 10;
    }
    return num % 10;
   }
}

Console.WriteLine("Введите число  ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == ThirdNumber(num))
{
    Console.WriteLine($"Число не имеет третей цифры");
}
else
 {
    Console.WriteLine(ThirdNumber(num));
 } 
 */