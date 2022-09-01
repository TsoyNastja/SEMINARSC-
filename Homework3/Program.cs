// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// void Number(){

//     Console.Write("Введите пятизначное число: ");
//    string num = Console.ReadLine();
//     Console.WriteLine("Number is - ");
//     if (num.Substring(0,1) == num.Substring(4,1) || num.Substring(1,1) == num.Substring(3,1) ){
//         Console.WriteLine("Да Палиндром "+ num);
//     }
//     else{   
//         Console.WriteLine("Не Палиндром "+ num);
//     } 
// };
// Number();

// //Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Square(int n){
//     int curr =1;
//     for (curr=1;curr<=n;curr++)
//             Console.WriteLine(curr*curr*curr);
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num<= 0) Console.Write("Некорректный ввод");
// else Square(num);


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// void average(int x1,int y1,int z1,int x2,int y2,int z2){
//     // double s = Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2);

//     double s = Math.Sqrt(
//         Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2) 
//         );
//                 Console.WriteLine($"Расстояние между двумя точками в пространстве {Math.Round(s, 2) }");
//                 Console.ReadKey();
            
            
// }

// int inputCoordinate(string name){
//     Console.Write($"Введите координаты {name} : ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// int x1 = inputCoordinate("x1");
// int y1 = inputCoordinate("y1");
// int z1 = inputCoordinate("z1");
// int x2 = inputCoordinate("x2");
// int y2 = inputCoordinate("y2");
// int z2 = inputCoordinate("z2");

                
// average( x1, y1, z1,x2,y2,z2);



