/* Задача 55: Задайте две матрицы. 
Напишите программу, которая будет находить 
произведение двух матриц. */


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


int[,] SumMatrix(int[,] array1, int[,] array2) {
    int[,] matrix = new int[array1.GetLength(0), array1.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            for (int k = 0; k < array2.GetLength(0); k++) {
                matrix[i, j] += array1[i,k] * array2[k, j];
            }
        }
    }
    return matrix; 
}


Console.WriteLine("Creating first matrix...");
Console.Write("Enter number of rows: ");
int m1 = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns: ");
int n1 = int.Parse(Console.ReadLine());

Console.WriteLine("Creating second array...");
Console.Write("Enter number of rows: ");
int m2 = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns: ");
int n2 = int.Parse(Console.ReadLine());

int[,] arr1 = CreateArray(m1, n1);
int[,] arr2 = CreateArray(m2, n2);
PrintArray(arr1); 
Console.WriteLine();
PrintArray(arr2);
Console.WriteLine();


if (arr1.GetLength(0) != arr2.GetLength(1) || arr1.GetLength(1) != arr2.GetLength(0)) {
       Console.WriteLine("Multiplication is impossible");
    }
else PrintArray(SumMatrix(arr1, arr2));
