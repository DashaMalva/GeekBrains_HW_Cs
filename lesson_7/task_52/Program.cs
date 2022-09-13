/* Задача 52
Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.*/

int MIN_VALUE = 0;
int MAX_VALUE = 10;


int[,] CreateArray(int row, int col) {
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++) {
        for (int j = 0; j < col; j++) {
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


double[] GetAverageRowsValue(int[,] array) {
    double[] result = new double[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++) {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++) {
            sum += array[i, j]; 
        }
        result[i] = Math.Round(sum / array.GetLength(1), 2);
    }
    return result;
}


Console.WriteLine("Creating array...");
Console.Write("Enter number of rows: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Enter number of columns: ");
int n = int.Parse(Console.ReadLine());

int[,] arr = CreateArray(m, n);
PrintArray(arr);
Console.WriteLine();

Console.WriteLine(string.Join("; ", GetAverageRowsValue(arr)));
