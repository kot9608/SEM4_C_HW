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
int StepenB (int A, int B){//то, что принимает на вход метод
  int StepB=1;
  for (int i=1; i<=B;i++){
    StepB = StepB*A;
  }
  return StepB;//то, что возвращает метод
}
