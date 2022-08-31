//  Задайте прямоугольный двумерный массив.Напишите программу, которая будет находить строку с наименьшей суммой элементов
int[,] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(String.Format(array[i, j] + " "));
    }
    Console.WriteLine();
}
void sumString(int[,] array)
{
    int result0 = 0;
    int result1 = 0;
    int result2 = 0;
    int result3 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
            {
                result0 = result0 + array[i, j];
            }
            if (i == 1)
            {
                result1 = result1 + array[i, j];
            }
            if (i == 2)
            {
                result2 = result2 + array[i, j];
            }
            if (i == 3)
            {
                result3 = result3 + array[i, j];
            }
        }
    }
    Console.WriteLine($"Сумма 1 строки {result0}");
    Console.WriteLine($"Сумма 2 строки {result1}");
    Console.WriteLine($"Сумма 3 строки {result2}");
    Console.WriteLine($"Сумма 4 строки {result3}");
    if (result0 < result1 && result0 < result2 && result0 < result3)
    {
        Console.WriteLine("Строка 1");
    }
    if (result1 < result0 && result1 < result2 && result1 < result3)
    {
        Console.WriteLine("Строка 2");
    }
    if (result2 < result0 && result2 < result1 && result2 < result3)
    {
        Console.WriteLine("Строка 3");
    }
    if (result3 < result0 && result3 < result1 && result3 < result2)
    {
        Console.WriteLine("Строка 4");
    }
}
sumString(array);