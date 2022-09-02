// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов

int[,] rectangularArray = new int[3, 5];
Random array = new Random();

void FillArray()
{
    for(int i = 0; i < rectangularArray.GetLength(0); i++)
    {
        for(int j = 0; j < rectangularArray.GetLength(1); j++)
        {
            rectangularArray[i, j] = array.Next(0, 20);
        }
    }
    return;
}

void PrintArray(int[,] rectangularArray)
{
    for(int i = 0; i < rectangularArray.GetLength(0); i++)
    {
        for(int j = 0; j < rectangularArray.GetLength(1); j++)
        {
            Console.Write($"{rectangularArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void MinLineArraySum(int[,] rectangularArray)
{
    int sum = 0;
    int index = 0;
    for(int i = 0; i < rectangularArray.GetLength(0); i++)
    {
        int sumLine = 0;
        for(int j = 0; j < rectangularArray.GetLength(1); j++)
        {
            sumLine += rectangularArray[i, j];
        }
        if(i == 0)
        {
            sum = sumLine;
        }
        else if (sumLine < sum)
        {
            sum = sumLine;
            index = i++;
        }
    }
    Console.WriteLine($"Найдена строка с наименьшей суммой элементов: {sum}");
}
Console.WriteLine();
FillArray();
PrintArray(rectangularArray);
Console.WriteLine();
MinLineArraySum(rectangularArray);
Console.WriteLine();
