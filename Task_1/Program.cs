// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3?)
// 2, 4 -> 16


double num = ReadInt("Введите число A");
double num2 = ReadInt("Введите число B");  
Console.WriteLine($"Число {num} в стпени {num2} равняется {Pow(num, num2)}");

int ReadInt(string message)
{
    Console.WriteLine ($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}

double Pow(double digit, double digit2)
{
    double result;
    result = Math.Pow(digit,digit2);
    return result;
}
