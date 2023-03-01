// Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.


// int M = new Random().Next(1, 6);
// int[] array = new int[M];

// array = FillArray(M);
// Console.WriteLine(String.Join("; ", array));
// Console.WriteLine($"Вы ввели {CountMore0(array)} чисел больше 0");


// int[] FillArray(int M)
// {
//     Console.WriteLine($"Введите {M} чисел");
//     for (int i = 0; i < M; i++){
//         Console.Write("Введите целое число: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     Console.WriteLine("Достаточно");
//     return array;
// }


// int CountMore0(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count++;
//     }
//     return count;
// }



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// Console.WriteLine("Ищем точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
// Console.Write("Введите целое число k1: ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите целое число b1: ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите целое число k2: ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите целое число b2: ");
// int b2 = Convert.ToInt32(Console.ReadLine());

// double[] point = IntersectionLine(k1, b1, k2, b2);
// Console.WriteLine($"Точка пересечения ({String.Join("; ", point)})");


// double[] IntersectionLine(int k1, int b1, int k2, int b2)
// {
//     double[] intersectionLine = new double[2];
//     intersectionLine[0] = (Convert.ToDouble(b2 - b1)) / (k1 - k2);
//     intersectionLine[1] = k1 * intersectionLine[0] + b1;
//     return intersectionLine;
// }



// Перевести число в двоичное

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(TransformBinary(number));

string TransformBinary(int num)
{
    string result = "";
    while (num>=1)
    {
        int rem = num % 2;
        num = num / 2;
        result = Convert.ToString(rem) + result;
    }
    return result;
}



