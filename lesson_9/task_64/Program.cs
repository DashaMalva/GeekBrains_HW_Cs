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


string PrintRow(int bottom, int top) {
    if (top < bottom) {
        int temp = bottom;
        bottom = top;
        top = temp;
    }
    if (bottom == top) {
        return $"{top}";
    }
    else {    
        return $"{bottom}, " + PrintRow(bottom + 1, top);
    }
}


Console.WriteLine(PrintRow(m, n));

