// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


// double [,] CreateRandom2dArray(int m, int n, double min, double max){
//     double[,] array = new double[m,n];
//     for(int i = 0; i<m; i++)
//         for(int j = 0; j<n; j++)
//             array[i,j] = Math.Round(new Random().NextDouble() * (max - min) + min, 2);
//     return array;
// }

// void Show2dArray(double[,] array){
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of min: ");
// double min = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input numb of max: ");
// double max = Convert.ToDouble(Console.ReadLine());

// double[,] array = CreateRandom2dArray(m,n,min,max);
// Show2dArray(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1,7 -> такого числа в массиве нет
// 1,2 -> 2

// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int[rows,cols];
//     for(int i = 0; i<rows; i++)
//         for(int j = 0; j<cols; j++)
//             array[i,j] = new Random().Next(min, max);
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }
// void ShowElement(int row, int col, int[,] array){

//     if(row >= array.GetLength(0) && row >= array.GetLength(1)){
//       Console.Write("Такого элемента нет");
//     }
//     else{
//       Console.Write($"Элемент: {array[row,col]}");  
//     }
    
// }

// Console.Write("Input numb of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input numb of cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());

// int[,] array = CreateRandom2dArray(rows,cols,0, 100);
// Show2dArray(array);


// Console.Write("Введите row: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите col: ");
// int col = Convert.ToInt32(Console.ReadLine());

// ShowElement(row, col, array);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
    int[,] array = new int[rows,cols];
    for(int i = 0; i<rows; i++)
        for(int j = 0; j<cols; j++)
            array[i,j] = new Random().Next(min, max);
    return array;
}

void Show2dArray(int row, int col, int[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}


void ShowAvgColumn(int [,] array){
    for(int j=0; j < array.GetLength(1); j++){
        double sum = 0;
        for(int i = 0; i< array.GetLength(0); i++){
            sum += array[i,j];    
        }
        Console.WriteLine($"Среднее по колонке {j} будет {sum / array.GetLength(0)}");

    }
}

Console.Write("Input numb of row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numb of col: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(row ,col, 0, 100);
Show2dArray(row, col, array);
ShowAvgColumn(array);


