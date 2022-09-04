// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента

/*int[][] numbers = new int[3][];
numbers[0] = new int[3];
numbers[1] = new int[3];
numbers[2] = new int[3];
Random x = new Random();

void FillArray(int[] array)
{
    for(int i = 0; i < 3; i++)
    {
        NoRepetitions(i, array);
        // Console.Write($"{array[i]} ");
    }
}

void NoRepetitions(int i, int[] array)
{
    array[i] = x.Next(0, 50);
    for(int j = 0; j < i; j++)
    {
        if(array[i] == array[j])
        {
            NoRepetitions(i, array);
        }
    }
}

FillArray(numbers[0]);
Console.WriteLine();
FillArray(numbers[1]);
Console.WriteLine();
FillArray(numbers[2]);
Console.WriteLine();

for (int i = 0; i < numbers.Length;i++)
{
    for (int j = 0; j < numbers[i].Length; j++)
    {
        Console.Write($"{numbers[i][j]} ");
    }
    Console.WriteLine();
}*/

int[,,] matrix = new int[3, 3, 3];
Random x = new Random();

void FillArray()
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            for(int k = 0; k < matrix.GetLength(2); k++)
            {
                NoRepetitions(i, j, k, matrix);
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}

FillArray();

void NoRepetitions(int i, int j, int k, int[,,] array)
{
    array[i, j, k] = x.Next(0, 10);
    for(int i1 = 0; i1 < array.GetLength(0); i1++)
    {
        for(int j1 = 0; j1 < array.GetLength(1); j1++)
        {
            for(int k1 = 0; k1 < array.GetLength(2); k1++)
            {
                if((i1 == i) && (j1 == j) && (k1 == k)) return;
                if(array[i1, j1, k1] == array[i, j, k])
                {
                    NoRepetitions(i, j, k, array);
                }
            }
        }
    }
}
