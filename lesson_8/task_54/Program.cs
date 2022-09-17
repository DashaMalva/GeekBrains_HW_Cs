/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива. */

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


int[,] SortRows(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) { 
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = j + 1; k < array.GetLength(1); k++) {
                if (array[i,j] > array[i, k]) {
                    int temp = array[i,j];
                    array[i,j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array; 
}


Console.WriteLine("Creating array...");
Console.Write("Enter number of rows: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns: ");
int n = int.Parse(Console.ReadLine());

int[,] arr = CreateArray(m, n);
PrintArray(arr);
Console.WriteLine();

PrintArray(SortRows(arr));
