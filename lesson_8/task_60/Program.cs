/* Задача 60. 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента */

int ROWS = 2;
int COLS = 2;
int PAGES = 2;

int MIN_VALUE = 10;
int MAX_VALUE = 100;


int[,,] array = new int[ROWS, COLS, PAGES];
int[] uniqueArray = new int[ROWS*COLS*PAGES];
int u = 0;


for (int i = 0; i < ROWS; i++) {
    for (int j = 0; j < COLS; j++) {
        for (int p = 0; p < PAGES; p++) {
            array[i, j, p] = new Random().Next(MIN_VALUE, MAX_VALUE); 
            while (uniqueArray.Contains(array[i, j, p])) {
                array[i, j, p] = new Random().Next(MIN_VALUE, MAX_VALUE);
            }          
            uniqueArray[u] = array[i, j, p];
            u++;
        }
    }
}


for (int p = 0; p < PAGES; p++) {
    for (int i = 0; i < ROWS; i++) {
        for (int j = 0; j < COLS; j++) {
        Console.Write($"{array[i, j, p]}({i},{j},{p}) ");
        }
        Console.WriteLine();
    }
}

