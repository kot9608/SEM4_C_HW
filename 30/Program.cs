// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


Console.Clear();
Console.Write("Введите число: ");
int num = 8;
int[] array = GetBinArray(num);
Console.Write($"[{String.Join(", ", array)}]");
Console.Write($"[");
for (int i = 0; i < num - 1; i++){
    Console.Write($"{array[i]}, ");
}Console.Write($"{array[num - 1]}]");


int[] GetBinArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(2);
    }
    return result;
}






// Console.Clear();
// Console.Write("Введите число : ");
// int i =1;
// //int [] s  = int.Parse(Console.ReadLine());
// int [] Random_massiv(int p){
//     for (int num = 1; i <= 8; i++){
//         num = new Random().Next(0,2);  
//     return num;
//     }
    
    
// }
// Console.WriteLine($"Количество цифр {Random_massiv(num)}");