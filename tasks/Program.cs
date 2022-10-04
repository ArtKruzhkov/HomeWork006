// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.WriteLine("How many numbers you want to add?");
// int count = int.Parse(Console.ReadLine()!);
// int[] array = new int[count];
// for(int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine("Enter number");
//     array[i] = int.Parse(Console.ReadLine()!);
// }
// Console.WriteLine($"Your entered these numbers - [{String.Join(" ", array)}]");
// int PositiveCount(int[] Array)
// {
//     int positivecount = 0;
//     for(int i = 0; i < Array.Length; i++)
//     {
//         if(Array[i] > 0)
//         {
//             positivecount = positivecount + 1;
//         }
//     }
//     return positivecount;
// }
// int Positive = PositiveCount(array);
// Console.WriteLine($"Amount of positive numbers in this array = {Positive}");



// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Выражаем икс
// k1x + b1 = k2x + b2 
// k1x-k2x = b2 - b1
// x(k1 - k2) = b2 - b1 
// x = (b2 - b1)/(k1 - k2);

// Console.WriteLine("Enter b1");
// double b1 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter k1");
// double k1 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter b2");
// double b2 = double.Parse(Console.ReadLine()!);
// Console.WriteLine("Enter k2");
// double k2 = double.Parse(Console.ReadLine()!);
// double x = (b2 - b1)/(k1 - k2);
// double y = k2 * x + b2;
// Console.WriteLine($"Cross point for entered lines is {x}, {y}");