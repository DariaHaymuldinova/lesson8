// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] array = new int[2,2,2];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
            {
               array[i, j, k] = new Random().Next(11, 100);
               Console.Write(String.Format(array[i, j, k] + " " + $"({i}, {j}, {k})" + " "));
            }
    Console.WriteLine();
    }
}  

int[,] myArr = new int[3, 4];
for (int i = 0; i < myArr.GetLength(0); i++)
{
    for (int j = 0; j < myArr.GetLength(1); j++)
    {
        myArr[i, j] = new Random().Next(0, 10);
        Console.Write(String.Format(myArr[i, j] + " "));
    }
    Console.WriteLine();
}
for (int i = 0; i < myArr.GetLength(0); i++)
{
    for (int j = 0; j < myArr.GetLength(1); j++)
        for (int k = 0; k < myArr.GetLength(0); k++)
            if (myArr[i, j] < myArr[i, k + 1])
            {
                int tmp = myArr[i, j];
                myArr[i, j] = myArr[i, k + 1];
                myArr[i, k + 1] = tmp;
            }
}
Console.WriteLine("Отсортированный массив:");
for (int i = 0; i < myArr.GetLength(0); i++)
{
        for (int j = 0; j < myArr.GetLength(1); j++)
        {
            Console.Write("{0}\t", myArr[i, j]);
        }
    Console.WriteLine();
}

Console.ReadLine();


