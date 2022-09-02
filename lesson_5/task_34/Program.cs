/* Задача 34
Задайте массив, заполненный случайными положительными 
трехзначными числами. Программа показывает количество 
четных чисел в массиве */

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}


int CountEvenElements(int[] array)
{
    int count = 0;
    foreach(int element in array)
    {
        count += element % 2 == 00 ? 1 : 0;
    }
    return count;
}


Console.Write("Введите длину массива ");
int size = int.Parse(Console.ReadLine());

int[] array = CreateArray(size);
Console.WriteLine(string.Join(", ", array));

Console.Write("Количество четных чисел в массиве: ");
Console.WriteLine(CountEvenElements(array));
