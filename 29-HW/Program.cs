// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



Console.Clear();
int num = 8;
Console.Write("Введите минимальное число для массива: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное число для массива: ");
int max = int.Parse(Console.ReadLine());
int[] array = GetBinArray(num);
Console.Write($"[{String.Join(", ", array)}]");
int[] GetBinArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}
