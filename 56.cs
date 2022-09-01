// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой
// элементов: 1 строка.

Console.Clear();
int line = 3;
int columns = 4;
int sum = 0;
Random rand1 = new Random();
int[,] matrix1 = new int[line, columns];
Random rand2 = new Random();
int[] matrix2 = new int[line];
for (int i = 0; i < matrix1.GetLength(0); i++)  
{
    for (int j = 0; j < matrix1.GetLength(1); j++)     
    {
        matrix1[i, j] = rand1.Next(1, 9);
        sum = sum + matrix1[i,j];
        Console.Write($"{matrix1[i, j]}\t");   
    }
    matrix2[i] = sum;
    Console.WriteLine();
    sum = 0;
}

Console.WriteLine();
int minLine = matrix2[0];
int minSum = 1;
for (int k = 1; k < line; k++)
{
    if (matrix2[k]<minLine)
    {
        minLine = matrix2[k];
        minSum = k+1;
    }
}
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minSum}");