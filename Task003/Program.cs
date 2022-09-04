// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

Console.WriteLine("Введите размерность первой матрицы: ");
int[,] matrix1 = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
for(int i = 0; i < matrix1.GetLength(0); i++)
{
    for(int j = 0; j < matrix1.GetLength(1); j++)
    {
        Console.Write("matrix1[{0},{1}] = ", i, j);
        matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Введите размерность второй матрицы: ");
int[,] matrix2 = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
for(int i = 0; i < matrix2.GetLength(0); i++)
{
    for(int j = 0; j < matrix2.GetLength(1); j++)
    {
        Console.Write("matrix2[{0},{1}] = ", i, j);
        matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

void Print(int[,] matrix1)
{
    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write("{0}", matrix1[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    if(matrix1.GetLength(1) != matrix2.GetLength(0)) throw new Exception("Невозможно перемножить матрицы. Данные матрицы не соответствуют правилу перемножения матриц!");
    int[,] matrixArr = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix2.GetLength(1); j++)
        {
            for(int m = 0; m < matrix2.GetLength(1); m++)
            {
                matrixArr[i, j] += matrix1[i, m] * matrix2[m, j];
            }
        }
    }
    return matrixArr;
}
Console.WriteLine("\nПервая матрица: ");
Print(matrix1);
Console.WriteLine("\nВторая матрица: ");
Print(matrix2);
Console.WriteLine("Произведение матриц: ");
int[,] matrix = MatrixProduct(matrix1, matrix2);
Print(matrix);