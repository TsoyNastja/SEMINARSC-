// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int [] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for(int i=0; i<size; i++){
//         array[i] = new Random().Next(100, 999);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for(int i = 0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }

// int CountPosEl(int[] array){
//     int count = 0;
//     int arrayResult = 0;

//     for(int i = 0; i<array.Length; i++){
//         arrayResult = array[i]%2;

//         if(arrayResult == 0) count++ ;
// }
// return count;
// }

// Console.WriteLine("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min: ");
// int min= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateRandomArray(size,min,max);
// ShowArray(array);

// int count = CountPosEl(array);
// Console.WriteLine();
// Console.WriteLine($"Кол-во четных чисел в массиве {count}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int [] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for(int i=0; i<size; i++){
//         array[i] = new Random().Next(min, max);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for(int i = 0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }

// int CountPosEl(int[] array){
//     int sum = 0;
//     int arrayResult = 0;

//     for(int i = 0; i<array.Length; i++){
//         arrayResult = array[i]%2;

//         if(arrayResult != 0) sum += array[i];
// }
// return sum;
// }

// Console.WriteLine("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min: ");
// int min= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateRandomArray(size,min,max);
// ShowArray(array);

// int sum = CountPosEl(array);
// Console.WriteLine();
// Console.WriteLine($"Сумма нечетных чисел в массиве {sum}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// int [] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for(int i=0; i<size; i++){
//         array[i] = new Random().Next(100, 999);
//     }
//     return array;
// }

// void ShowArray(int[] array){
//     for(int i = 0; i<array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
// }

// int PosEl(int[] array){

//     int max = array[0];
//     int min = array[0];
//     for(int i = 0; i<array.Length; i++){
//         if(array[i]> max) max = array[i];
//         if(array[i]< min) min = array[i];
// }
// return max-min;
// }

// Console.WriteLine("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min: ");
// int min= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateRandomArray(size,min,max);
// ShowArray(array);
// Console.WriteLine();
// Console.WriteLine($"Разница между максимальным и минимальным элементом {PosEl(array)}");