/* Задача 50
Напишите программу, которая на вход принимает позиции элемента 
в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет. */

int MIN_VALUE = 0;
int MAX_VALUE = 10;


int[,] CreateMatrix(int row, int col) {
    int[,] matrix = new int[row, col];
    for (int i = 0; i < row; i++) {
        for (int j = 0; j < col; j++) {
            matrix[i, j] = new Random().Next(MIN_VALUE, MAX_VALUE); 
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            Console.Write($"{matrix[i, j]} "); 
        }
        Console.WriteLine();
    }
}


bool ElementExistInArray(int[,] matrix, int row_index, int col_index) {
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    if (row_index >= 0 
        && row_index < rows
        && col_index >= 0
        && col_index < cols) {
            return true;
        }
    else return false;
}

Console.WriteLine("Creating array...");
Console.Write("Enter number of rows: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();

Console.Write("Enter element row index: ");
int row_index = int.Parse(Console.ReadLine());
Console.Write("Enter element col index: ");
int col_index = int.Parse(Console.ReadLine());
Console.WriteLine();

if (ElementExistInArray(matrix, row_index, col_index)) {
    Console.WriteLine($"element({row_index},{col_index}) = {matrix[row_index, col_index]}");
}
else Console.WriteLine("This element does not exist in current array");
