/* Задача 64.
Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N. */


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


int SumElementsInBetween(int bottom, int top) {
    int result = 0;
    while (bottom <= top) {
        result += bottom;
        bottom++;
    }
    return result;
}

if (m < n) {
   Console.WriteLine(SumElementsInBetween(m, n));
}
else {
    Console.WriteLine(SumElementsInBetween(n, m));
}
