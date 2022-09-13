/* Задача 47.
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами. */


double[,] CreateMatrix(int row, int col, double max_value) {
    double[,] matrix = new double[row, col];
    for (int i = 0; i < row; i++) {
        for (int j = 0; j < col; j++) {
            double random_num = new Random().NextDouble()*2-1;
            matrix[i, j] = Math.Round(random_num*max_value, 2); 
        }
    }
    return matrix;
}


void PrintMatrix(double[,] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            Console.Write($"{matrix[i, j]} "); 
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Creating array...");
Console.Write("Enter number of rows: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Enter number of columns: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Enter maximum value of an array element: ");
double max_value = double.Parse(Console.ReadLine());

PrintMatrix(CreateMatrix(m, n, max_value));
