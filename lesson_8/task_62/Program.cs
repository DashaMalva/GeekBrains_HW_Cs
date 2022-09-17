/* Задача 62. 
Напишите программу, которая заполнит спирально массив 4 на 4. */

int ROWS = 4;
int COLS = 4;

int[,] array = new int[ROWS, COLS];

// первый ряд
for (int j = 0; j < COLS; j++) {
    array[0, j] = j + 1;
}

// крайний столбец 
for (int i = 1; i < ROWS; i++) {
    array[i, ROWS - 1] = array[i - 1, ROWS - 1] + 1;
}

// нижний ряд
for (int j = COLS - 2; j >= 0; j--) {
    array[ROWS - 1, j] = array[ROWS - 1, j + 1] + 1;
}

// первый стобец
for (int i = ROWS - 2; i > 0; i--) {
    array[i, 0] = array[i + 1, 0] + 1;
}

// первый внутренний ряд
for (int j = 1; j < COLS - 1; j++) {
    array[1, j] = array[1, j - 1] + 1;
}

// второй внутренний столбец
for (int i = 2; i < ROWS - 1; i++) {
    array[i, COLS - 2] = array[i - 1, COLS - 2] + 1;
}


// второй внутренний ряд 
for (int j = COLS - 3; j >= 0; j--) {
     array[2, j] = array[2, j + 1] + 1;
}

// вывод 
for (int i = 0; i < ROWS; i++) {
    for (int j = 0; j < COLS; j++) {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}




