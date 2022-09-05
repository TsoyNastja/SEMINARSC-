// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// void Numbers(int num1, int num2){

//   int result=1;
  
//     for (int curr = 1; curr <= num2; curr++){
//         result = result*num1;
//     }
//     Console.WriteLine($"Число в натуральной степени {result}");
// }

// Console.WriteLine("Введите число 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());


// Numbers(num1,num2);

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


// int Number(int num){
//   int result = 0;
//   while(num>0){
//       result += num % 10;
//       num = num/10;
//   }
//   return result;
// }


// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма цифр в числе {Number(num)}");



// Задача 29: Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// void Array(int[] array){
 
//     for (int i=0; i < array.Length; i++){
//       Console.Write( array[i] + ", ");
//     }
// }

//  int[] CreateRandomArray(int size){
//     int[] array = new int[size];
//     for (int i=0; i < size; i++){
//         array[i] = new Random().Next(int.MinValue,int.MaxValue);
//     }
//     return array;
// }

// Array(CreateRandomArray(new Random().Next(1,10))); // НЕ БОЛЕЕ 10 ЧИСЕЛ, ИНАСЕ ДОЛГО ЖДАТЬ ВЫВОД НА ЭКРАН

