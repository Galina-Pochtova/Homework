// Задача 1. Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

/*bool Palindrome(int num)
{
    int num_temp = num;
    int newNum = 0;

while (num > 0)
    {
         int lastDigit = num % 10;
        newNum = newNum *10 + lastDigit;
        num = num / 10;
    }
    if (newNum == num_temp)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (Palindrome(number) == true)
{
    Console.WriteLine("Число является палиндромом.");
}
 else 
 {
    Console.WriteLine("Число не является палиндромом.");
 }
*/ 

//Задача 2. Напишите программу, которая принимает на вход
//координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*double Div(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double num_x = x2 - x1;
    double num_y = y2 - y1;
    double num_z = z2 - z1;
    double num_xyz = Math.Sqrt(num_x*num_x + num_y * num_y + num_z* num_z);
    return num_xyz;
}

Console.Write("Введите координату х1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z1: ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату х2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z2: ");
double z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round(Div(x1, y1, z1, x2, y2, z2), 2));
*/


//Задача 3. Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

//void Cube(int num)
//{
//    for (int i = 1; i <= num; i++) Console.Write($" - {i*i*i}");
//}
//
//Console.WriteLine("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
//
//Cube(num)
