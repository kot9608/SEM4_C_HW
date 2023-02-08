// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine());
if (num<10)
  Console.WriteLine($"Сумма цифр в числе {num} = {num}");
Console.WriteLine($"Сумма цифр в числе {num} = {CountNumbers(num)}");
int CountNumbers(int NUM)
{
int sum=0;
{
    for (int i=1; i<NUM*10;i++){
    
    sum = sum+(NUM%10);
    NUM=NUM/10;   
  }
  return sum;
  }
}

// Console.Clear();
// Console.Write("Введите целое число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"{num} -> {GetSumNumbers(num)}");

// int GetSumNumbers(int numbers)
// {
//     int result = 0;
//     int operand = -1;
//     while (numbers > 0)
//     {
//         operand = numbers % 10;
//         result += operand;
//         numbers = numbers / 10;
//     }
//     return result;
// }