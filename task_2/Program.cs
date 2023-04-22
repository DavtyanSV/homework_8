// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int[] MinRow(int[,] array)
{
    int[] massive = new int[array.GetLength(1)];
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = 11;
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumArray = 0;
        int sumMassive = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArray += array[i, j];
        }
        for (int k = 0; k < massive.Length; k++)
        {
            sumMassive+=massive[k];
        }
        if (sumArray<sumMassive)
        {
            for (int l = 0; l < massive.Length; l++)
        {
            massive[l] = array[i,l];
        }

        }

    }

    return massive;

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

void PrintMassive(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int row = ReadInt("Введите кол-во строк");
int collums = ReadInt("Введите кол-во столбцов");
int[,] something = CreateArray(row, collums);
PrintArray(something);
System.Console.WriteLine();
int [] minArray = MinRow(something);
PrintMassive(minArray);


