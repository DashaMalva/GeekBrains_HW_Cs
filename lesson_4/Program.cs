// Задача 25
// Напишите цикл, который на вход принимает два числа A и B
// и возводит число A в натуральную степень B

Console.WriteLine("Задача 25");
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
while (b <= 0)
{
    Console.Write("Введите число B: ");
    b = int.Parse(Console.ReadLine());
}

int result = 1;
for (int i=1; i<=b; i++)
{
    result *= a;
}

Console.WriteLine($"{a}, {b} -> {result}");


// Задача 27
// Напишите программу, которая на вход принимает число
// и выдает сумму цифр в числе

Console.WriteLine("Задача 27");
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int GetDigitSum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number%10;
        number = number/10;
    }
    return result;
}

Console.WriteLine($"{num} -> {GetDigitSum(num)}");


// Задача 29
// Напишите программу, которая задает массив из 8 элементов
// и выводит их на экран

Console.WriteLine("Задача 29");


int[] CreateArray(int amount)
{
    int[] array = new int[amount];
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}


string PrintArrray(int[] array)
{
    string result = string.Empty;
    for (int i=0; i<array.Length; i++)
    {
        result += $"{array[i]}, ";
    }
    return result;
}

int[] array_8 = CreateArray(8);
Console.WriteLine(PrintArrray(array_8));
 