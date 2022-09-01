// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}\t");
        }
        System.Console.WriteLine();

    }
}

int Prompt(string message)
{
    System.Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] FillWithSpiral(int size)
{
    int elements = size * size;
    int countElement = 0;
    int begin = 0;
    int[,] array = new int[size, size];
    while (countElement < elements)
    {
        for (int i = begin; i < size; i++)
        {
            countElement++;
            array[begin, i] = countElement;
        }
        for (int i = begin + 1; i < size; i++)
        {
            countElement++;
            array[i, size - 1] = countElement;
        }
        for (int i = size - 2; i >= begin; i--)
        {
            countElement++;
            array[size - 1, i] = countElement;
        }
        for (int i = size - 2; i >= begin + 1; i--)
        {
            countElement++;
            array[i, begin] = countElement;
        }
        size -= 1;
        begin += 1;
    }
    return array;
}

int[,] matrix = FillWithSpiral(Prompt("Введите размер квадратной матрицы: "));
PrintMatrix(matrix);