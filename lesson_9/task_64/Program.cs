/* Задача 64.
Задайте значения M и N. Напишите программу, которая выведет 
все натуральные числа в промежутке от M до N. */


Console.Write("Enter m: ");
int m = int.Parse(Console.ReadLine());
while (m <= 0) {
    Console.Write("Enter m: ");
    m = int.Parse(Console.ReadLine());
}

Console.Write("Enter n: ");
int n = int.Parse(Console.ReadLine());
while (n <= 0) {
    Console.Write("Enter m: ");
    n = int.Parse(Console.ReadLine());
}


void PrintRow(int bottom, int top) {
    while (bottom < top) {
        Console.Write($"{bottom}, ");
        bottom++;
    }
    Console.Write($"{top}");
}


if (m < n) {
   PrintRow(m, n);
}
else {
    PrintRow(n, m);
}

