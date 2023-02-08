// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine());
int sum = 0;
if (num<10)
  Console.WriteLine($"Сумма цифр в числе {num} = {num}");
Console.WriteLine($"Сумма цифр в числе {num} = {CountNumbers(sum)}");
int CountNumbers(int sum)
{
    for (int i=1; i<num*10;i++){
    //int sum = 0;
    sum = sum+(num%10);
    num=num/10;   
  }
  return sum;
  }
