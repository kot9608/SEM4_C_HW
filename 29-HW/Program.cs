// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



Console.Clear();
Console.Write("Введите длинну массива: ");
int s = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное число для массива: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное число для массива: ");
int max = int.Parse(Console.ReadLine());
int[] array = GetArray(s, min, max);
Console.Write($"[{String.Join(", ", array)}]");
int[] GetArray(int size, int MIN, int MAX){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}
