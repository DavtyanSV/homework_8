// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

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

int[,] Order(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i,k]<array[i,k+1])
                {
                    int temp = 0;
                    temp = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = temp;
                }

            }

        }

    }
    return array;

}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j]);
        }
        System.Console.WriteLine();
    }

}


int row = ReadInt("Введите кол-во строк");
int collums = ReadInt("Введите кол-во столбцов");
int[,] massive = CreateArray(row, collums);
PrintArray(massive);
System.Console.WriteLine();
PrintArray(Order(massive));

