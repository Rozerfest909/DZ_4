// Задача 3: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreateArray()
{
    int[] res = new int[8];
    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(0,100);
    }
    return res;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int [] massive = CreateArray();
PrintArray(massive);