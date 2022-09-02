/* Задача 38
Задайте массив вещественных чисел. 
Найдите разницу между мин и макс элементами массива */


double[] CreateArray(int size, int min_value, int max_value)
{
    double[] array = new double[size];
    for(int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min_value, max_value);
    }
    return array;
}


double DiffMaxMinElem(double[] array)
{
    if (array.Length<2) return 0;
    double max = array[0];
    double min = array[1];
    for (int i=0; i<array.Length; i++) {
        if (array[i] > max) {
            max = array[i];
        }
        else if (array[i] < min) {
            min = array[i];
        }
        }
    return max - min;
    }


Console.Write("Введите длину массива: ");
int size = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение элемента массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение элемента массива: ");
int max = int.Parse(Console.ReadLine());

double[] array = CreateArray(size, min, max);
Console.WriteLine(string.Join(", ", array));

Console.Write("Разница между min и max элементами массива: ");
Console.WriteLine(DiffMaxMinElem(array));
