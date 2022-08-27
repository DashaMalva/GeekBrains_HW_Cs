// Задача 19
// На вход пятизначное число. Является ли оно палиндромом

Console.WriteLine("Задача 19");
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

int digit_1 = num / 10000;
int digit_2 = num / 1000 % 10;
int digit_4 = num / 10 % 10;
int digit_5 = num % 10;

if (digit_1 == digit_5 && digit_2 == digit_4)
{
    Console.WriteLine($"{num} -> да");
}
else Console.WriteLine($"{num} -> нет");

// Задача 21
// На вход две точки. Найти расстояние между ними в 3d пространстве

Console.WriteLine("Задача 21");
Console.Write("Введите координату X первой точки : ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y первой точки : ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z первой точки : ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату X второй точки : ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y второй точки : ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Z второй точки : ");
int z2 = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(
    Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)
);

Console.WriteLine($"A({x1},{y1},{z1});B({x2},{y2},{z2}) -> {Math.Round(distance, 2)}");


// Задача 23
// На вход число N. На выход таблицу кубов от 1 до N

Console.WriteLine("Задача 23");
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

Console.Write($"{n} -> ");

if (n > 0)
{
    for (int count = 1; count < n; count++)
    {
        Console.Write(Math.Pow(count, 3) + ", ");
    }
    Console.Write(Math.Pow(n, 3)); // чтобы не было запятой в конце
}
else if (n < 0)
{
    for (int count = -1; count > n; count--)
    {
        Console.Write(Math.Pow(count, 3) + ", ");
    }
    Console.Write(Math.Pow(n, 3));  
}
else
{
    Console.Write(0);
}

