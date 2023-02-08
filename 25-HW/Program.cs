// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число A:");
int a = int.Parse (Console.ReadLine());
Console.Write("Введите число B:");
int b = int.Parse (Console.ReadLine());
Console.WriteLine($"Число {a} в степени {b} равно {StepenB(a, b)}");
int StepenB (int A, int B){
  int StepB=1;
  for (int i=1; i<=b;i++){
    StepB = StepB*a;
  }
  return StepB;
}






// 24. Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
// Console.Clear();
// Console.Write("Введите число:");
// int n = int.Parse (Console.ReadLine());
// Console.WriteLine($"Сумма от 1 до {n} равна {GetSum(n)}");
// int GetSum (int limit){
//   int sum = 0;
//   for (int i=1; i<=limit;i++){
//     sum+=i;
//   }
//   return sum;
// }