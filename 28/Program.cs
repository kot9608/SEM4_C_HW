// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


Console.Clear();
Console.Write("Введите число : ");
int s = int.Parse(Console.ReadLine());
int GetS(int p){
    int sum = 1;
    for (int i = 1; i <= p; i++){
        sum *=i; 
    }
    Console.WriteLine(p);
    return sum;
    
}
Console.WriteLine($"Количество цифр {GetS(s)}");