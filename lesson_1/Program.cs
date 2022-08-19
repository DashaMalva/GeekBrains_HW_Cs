// Задача 2
// На вход: два числа. На выход: наименьшее число, наибольшее число.

Console.WriteLine("Задача № 2");
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());


if (a > b) 
{
    Console.Write("max = ");
    Console.WriteLine(a);
    Console.Write("min = ");
    Console.WriteLine(b);
}
else 
{
    Console.Write("max = ");
    Console.WriteLine(b);
    Console.Write("min = ");
    Console.WriteLine(a);
}


// Задача 4
// На вход: три числа. На выход: наибольшее число.

Console.WriteLine("Задача № 4");
Console.Write("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int num_3 = int.Parse(Console.ReadLine());

int max = num_1;
if (max < num_2) max = num_2;
if (max < num_3) max = num_3;

Console.Write("max = ");
Console.WriteLine(max);


// Задача 6
// На вход: число. На выход: является ли число четным.

Console.WriteLine("Задача № 6");
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0) Console.Write("Число чётное.");
else Console.WriteLine("Число нечётное.");


// Задача 8
// На вход число (N). На выход: все четные числа от 1 до N

Console.WriteLine("Задача № 8");
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int count = 2;

while (count <= N)
{
    if (count % 2 == 0) Console.Write(count);
    Console.Write(" ");
    count++;
}
