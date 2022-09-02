// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] matrix1 = {
    {2, 4},
    {3, 2},
};
int[,] matrix2 = {
    {3, 4},
    {3, 3},
};
    int[,] matrixNew = new int[2, 2];

    for (int i = 0; i < 2; ++i)
    {
        for (int j = 0; j < 2; ++j)
        {
                matrixNew[0, 0] = matrix1[0, 0] * matrix2[0, 0] + matrix1[0, 1] * matrix2[1, 0];
                matrixNew[0, 1] = matrix1[0, 0] * matrix2[0, 1] + matrix1[0, 1] * matrix2[1, 1];
                matrixNew[1, 0] = matrix1[1, 0] * matrix2[0, 0] + matrix1[1, 1] * matrix2[1, 0];
                matrixNew[1, 1] = matrix1[1, 0] * matrix2[0, 1] + matrix1[1, 1] * matrix2[1, 1];
                Console.Write(matrixNew[i, j] + " ");
        }
        Console.WriteLine();
    }
