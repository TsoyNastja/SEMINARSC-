//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

int CutNumber(){
    int num = new Random().Next(100,1000);
    Console.WriteLine("Number is - " + num);
    int dec = num / 100;
    int ed = num % 10;
    int result = dec*10 + ed;
    return result;
}
