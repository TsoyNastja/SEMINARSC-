// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

// int CutNumber(){
//     int num = new Random().Next(100,1000);
//     Console.WriteLine("Number is - " + num);
//     int dec = num / 100;
//     int ed = num % 10;
//     int result = dec*10 + ed;
//     return result;
// }

// int number = CutNumber();
// Console.WriteLine("Cut number is - " + number);


// void CutNumber(){
//  int num = new Random().Next(100,1000);
//     Console.WriteLine("Number is - " + num);
//     int dec = num / 100;
//     int ed = num % 10;
//     int result = dec*10 + ed;
//     Console.WriteLine("Cut number is - " + result);
// }

// CutNumber();
 
// int Factorial(int num){
//     int current = 1;
//     int fact = 1;
//     while(current<=num){
//         fact *= current;
//         current++;
//     }
    

//     return fact;
// }

// int result = Factorial(12) * Factorial(10);
// Console.WriteLine("Your result is - " + result);


// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
// int Line(){
//     int num = new Random().Next(10,100);
//     Console.WriteLine("Your number is: " + num);
//     int dec = num / 10;
//     int ed = num % 10;
//     if (dec>ed){
//         return dec;
//     }
//     else{
//         return ed;
//     }
// }


//  Console.WriteLine("Result - " + Line());
