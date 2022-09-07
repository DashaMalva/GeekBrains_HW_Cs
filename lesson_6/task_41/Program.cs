/* Задача 41.
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь. */


Console.Write("Введите количество чисел: ");
int size = int.Parse(Console.ReadLine());
while (size <=0) {
    Console.Write("Введите количество чисел: ");
    size = int.Parse(Console.ReadLine());
} 

int[] array = new int[size];

for (int i = 0; i < size; i++) {
    Console.Write($"Введите {i+1} число: ");
    array[i] = int.Parse(Console.ReadLine());
}

int count = 0; // количество чисел > 0

for (int i = 0; i < size; i++) {
    if (array[i] > 0) count++;
}

Console.Write($"Количество введенных чисел больше 0: {count}");
