// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int Number(int num){
    
//     int dec = (num % 100)/10;
//     return dec;
// }

// int num = new Random().Next(100,1000);
// Console.WriteLine("Number is - " + num);
// Console.WriteLine(Number(num));  


// 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// void Number(){
//     long num = new Random().Next();
//     Console.WriteLine("Number is - " + num);
//     if (num<100){
//         Console.WriteLine("у числа нет третьей цифры: " + num);
//     }
//     else{
//         string curr = Convert.ToString(num);

//         Console.WriteLine("У числа есть третья цифра: " + curr.Substring(2,1));
//     } 
// };
// Number();

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// void sqer(){
//     Console.Write("Введите число, соответствующее дню недели: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     if (num==6 || num==7){
//        Console.WriteLine("Выходной - "+ num);
//     }
//      else{
//        Console.WriteLine("Будний день - "+ num);
//      }
// }
// sqer();