// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Сделал сразу одинаковые размеры матриц, что бы можно было перемножать.

Console.Clear();
int line = 2;
int columns = 2;
Random rand = new Random();
Console.WriteLine("Первый массив: ");
int[,] matrix1 = new int[line, columns];
for (int i = 0; i < matrix1.GetLength(0); i++)  
{
    for (int j = 0; j < matrix1.GetLength(1); j++)     
    {
        matrix1[i, j] = rand.Next(1, 9);
        Console.Write($"{matrix1[i, j]}\t");   
    }
    Console.WriteLine();
}
Console.WriteLine("Второй массив: ");
int[,] matrix2 = new int[line, columns];
for (int i = 0; i < matrix2.GetLength(0); i++)  
{
    for (int j = 0; j < matrix2.GetLength(1); j++)     
    {
        matrix2[i, j] = rand.Next(1, 9);
        Console.Write($"{matrix2[i, j]}\t");   
    }
    Console.WriteLine();
}
Console.WriteLine("Произведение массивов: ");
int[,] matrix3 = new int[line, columns];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < matrix2.GetLength(0); k++)
        {
            matrix3[i,j] += matrix1[i,k] * matrix2[k,j];
        }
        Console.Write($"{matrix3[i, j]}\t");
    }
    Console.WriteLine();
}