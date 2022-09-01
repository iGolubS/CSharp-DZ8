// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message);                    
    int result = Convert.ToInt32(Console.ReadLine()); 
    return result;                                    
}

int[,] FillArray(int numLine, int numColumns)         
{
    Random rand = new Random();
    int[,] matrix = new int[numLine, numColumns];
    for (int i = 0; i < matrix.GetLength(0); i++)  
    {
        for (int j = 0; j < matrix.GetLength(1); j++)     
        {
            matrix[i, j] = rand.Next(1, 9);    
        }
    }
    return matrix;
}

void PrintArray(int[,] matrix)  
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int [,] array = FillArray(Prompt("Введите число строк > "),Prompt("Введите число столбцов > "));
Console.WriteLine("Заданный массив: ");
PrintArray(array);

for (var i = 0; i < array.GetLength(0); i++)
    for (var j = 0; j < array.GetLength(1); j++)
        for (var k = 0; k < array.GetLength(1); k++)
        {
            if (array[i, j] >= array[i, k])
            {
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
Console.WriteLine("Упорядоченный массив: ");
PrintArray(array);