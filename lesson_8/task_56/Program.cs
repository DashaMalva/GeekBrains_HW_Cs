/* Задача 54:  Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов. */

int MIN_VALUE = 0;
int MAX_VALUE = 10; 


int[,] CreateArray(int rows, int cols) {
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < cols; j++) {
            array[i, j] = new Random().Next(MIN_VALUE, MAX_VALUE);
        }
    }
    return array;
}


void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[] GetRowSums(int[,] array) {
    int[] rowSums = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++) { 
        for (int j = 0; j < array.GetLength(1); j++) {
            rowSums[i] += array[i, j]; 
        }
    }
    return rowSums;
}


int FindMinElementIndex(int[] array) {
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++) {
        if (array[minIndex] > array[i]) {
           minIndex = i;
        }
    }
    return minIndex;
}


Console.WriteLine("Creating array...");
Console.Write("Enter number of rows: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns: ");
int n = int.Parse(Console.ReadLine());

int[,] arr = CreateArray(m, n);
PrintArray(arr);
Console.WriteLine();

int[] rowsSums = GetRowSums(arr);
Console.WriteLine(string.Join(", ", rowsSums));
Console.WriteLine();

int index = FindMinElementIndex(rowsSums);
Console.WriteLine($"Row with minimal sum: {index + 1}");
