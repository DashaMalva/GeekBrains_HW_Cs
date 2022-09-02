/* Задача 36
Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.*/


int[] CreateArray(int size, int min_value, int max_value)
{
    int[] array = new int[size];
    for(int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(min_value,max_value+1);
    }
    return array;
}


int SumElemOnOddPosition(int[] array)
{
    int sum = 0;
    for(int i=0; i<array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}


Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элемента массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элемента массива: ");
int max = int.Parse(Console.ReadLine());

int[] array = CreateArray(size, min, max);
Console.WriteLine(string.Join(", ", array));

Console.Write("Сумма элементов на нечётных позициях: ");
Console.WriteLine(SumElemOnOddPosition(array));
