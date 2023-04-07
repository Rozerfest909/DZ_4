//// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int number = ReadInt("Введите число"); 
if (Validate(number))
{
	Console.WriteLine($"Сумма цифр числа '{number}' равна {Sum(number)}");
}

int ReadInt(string message)
{
    Console.WriteLine ($"{message} >");
    return Convert.ToInt32(Console.ReadLine());
}
int Sum(int digit)
{
    int result = 0;

    if (number > 0)
    {
        while (number > 0) 
        {
            result += number % 10;
            number /= 10;
        }
        return result;
        }
    else
    {
        while (number < 0) 
        {
            result += number % 10;
            number /= 10;
        }
        return result;
    }
}
bool Validate(int number)
{
    if (number < 10 && number > -10)
    {
        Console.WriteLine("Одной цифры мало");
        return false;
    }
    return true;
}