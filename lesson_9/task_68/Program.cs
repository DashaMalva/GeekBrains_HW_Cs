/* Задача 68. 
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. */

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


int CalcAkkermanFunction(int m, int n) {
    if (m == 0) {
        return n + 1;
    }
    else { 
        if (n == 0 && m > 0) {
            return CalcAkkermanFunction(m - 1, 1);
        }
        else {
            return CalcAkkermanFunction(m - 1, CalcAkkermanFunction(m, n - 1));
        }
    }
}


Console.WriteLine(CalcAkkermanFunction(m, n));