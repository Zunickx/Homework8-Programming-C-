// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива

int[,] matrixArray = new int[3, 4];
Random array = new Random();


void FillArray()
{
    for(int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for(int j = 0; j < matrixArray.GetLength(1); j++)
        {
            matrixArray[i, j] = array.Next(0, 50);
        }
        Console.WriteLine();
    }
    return;
}

void PrintArray(int[,] matrixArray)
{
    for(int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for(int j = 0; j < matrixArray.GetLength(1); j++)
        {
            Console.Write($"{matrixArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortDescending() // пузырьковый метод
{
    for(int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for(int j = 0; j < matrixArray.GetLength(1); j++)
        {
            for (int k = 0; k < matrixArray.GetLength(1) - 1; k++)
            {
               
                if(matrixArray[i, k] < matrixArray[i, k + 1])
                {
                    int c = matrixArray[i, k];
                    matrixArray[i, k] = matrixArray[i, k + 1];
                    matrixArray[i, k + 1] = c;
                    
                }
                
            }
        }
    }
    PrintArray(matrixArray);
}

FillArray();
PrintArray(matrixArray);
Console.WriteLine();
Console.WriteLine();
SortDescending();

