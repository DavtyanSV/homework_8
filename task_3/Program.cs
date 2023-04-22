// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int ReadInt(string message)
{
    System.Console.Write($"{message} -> ");
    return int.Parse(Console.ReadLine());

}

int[,] CreateArray(int first, int second)
{

    int[,] array = new int[first, second];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int colsA = matrixA.GetLength(1);
    int rowsB = matrixB.GetLength(0);
    int colsB = matrixB.GetLength(1);

    if (colsA != rowsB)
    {
        throw new ArgumentException("Invalid dimensions.");
    }

    int[,] result = new int[rowsA, colsB];

    for (int i = 0; i < rowsA; i++)
    {
        for (int j = 0; j < colsB; j++)
        {
            for (int k = 0; k < colsA; k++)
            {
                result[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] +" ");
        }
        System.Console.WriteLine();
    }

}

int row = ReadInt("Введите кол-во строк");
int collums = ReadInt("Введите кол-во столбцов");
int[,] massive = CreateArray(row, collums);
int row2 = ReadInt("Введите кол-во строк");
int collums2 = ReadInt("Введите кол-во столбцов");
int[,] massive2 = CreateArray(row, collums);
int[,] array = MultiplyMatrices(massive, massive2);

PrintArray(array);