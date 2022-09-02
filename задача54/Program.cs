// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы двумерного массива
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
for (int k = 0; k < 3; k++)
{
    for (int l = 0; l < 4; l++)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (i + 1 == 3 && j + 1 == 4)
                {
                    continue;
                }
                else
                {
                    if (j + 1 == 4 && myArr[i, j] > myArr[i + 1, 0])
                    {
                        int t = myArr[i, j];
                        myArr[i, j] = myArr[i + 1, 0];
                        myArr[i + 1, 0] = t;
                    }
                    else
                    {
                        if (j + 1 != 4 && myArr[i, j] > myArr[i, j + 1])
                        {
                            int t = myArr[i, j];
                            myArr[i, j] = myArr[i, j + 1];
                            myArr[i, j + 1] = t;
                        }
                    }
                }
            }
        }
    }
}

Console.WriteLine("Отсортированный массив:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0}\t", myArr[i, j]);
    }
    Console.WriteLine();
}

Console.ReadLine();
