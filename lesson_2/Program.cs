// Задача 10
// На вход трехзначное число, на выход вторую цифру числа

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int second_digit = num / 10 % 10;

Console.WriteLine("Вторая цифра числа:  " + second_digit);


// Задача 13
// Вывести третью цифру числа, либо сообщить, что её нет

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a < 0) a = a * (-1);

if (a < 100) Console.WriteLine("Третья цифра не существует");

if (a >= 100 && a < 1000) Console.WriteLine($"Третья цифра числа: {a % 10}");

if (a >= 1000)
{
    while (a >= 1000)
        a = a / 10;
        if (a < 1000)
        {
            Console.WriteLine($"Третья цифра числа: {a % 10}");
        }
}


// Задача 15
// На вход цифру, обозначающую день недели.
// На выход сообщение, выходной ли это

Console.Write("Введите цифру дня недели: ");
int day = int.Parse(Console.ReadLine());

if (day == 6 || day == 7) Console.WriteLine("Это выходной");
else if (day > 0 && day < 6) Console.WriteLine("Это будний день");
else Console.WriteLine("Такого дня недели не существует");
