// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array = new int[8];
// Console.WriteLine();
// var arr = FillArray(8);
// PrintArray(arr);

// int[] FillArray(int length)
// {
//     int[] result = new int[length];
//     for(int i =0; i < result.Length; i++)
//     {
//         result[i] = new Random().Next(111, 999 );   
//     }
//     return result;
// }

// void PrintArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     for (int z = 0; z < arr.Length; z++)
//      if (arr[z] % 2 == 0)

//     Console.WriteLine($" {z} из них чётные");
// }



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int[] array = new int[8];
// Console.WriteLine();
// var arr = FillArray(8);
// PrintArray(arr);

// int[] FillArray(int length)
// {
//     int[] result = new int[length];
//     for(int i =0; i < result.Length; i++)
//     {
//         result[i] = new Random().Next(111, 999 ); 
//     }
//     return result;
// }

// void PrintArray(int[] arr)
// {
//     for(int i = 0; i < arr.Length; i++)
//     {
//        if (i % 2 == 1)
//         {
//             Console.WriteLine($"{arr[i]},{i} ");
//             int len = NumberLen(arr[i]);
//             SumNumbers(arr[i], len);
//             int NumberLen(int a)
//             {
//                 int i = 0;
//                 while (a > 0)
//                 {
//                     a /= 10;
//                     i++;
//                 }
//                 return i;
//             }
//             void SumNumbers(int n, int len)
//             {
//                 int sum = 0;
//                 for (int i = 1; i <= len; i++)
//                 {
//                     sum += n % 10;
//                     n /= 10;
//                 }
//                 Console.WriteLine(sum);
//             }
//         }
       
//     }
  
// }


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] numbers = new double[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// double min = Int32.MaxValue;
// double max = Int32.MinValue;

// for (int z = 0; z < numbers.Length; z++)
// {
//     if (numbers[z] > max)
//         {
//             max = numbers[z];
//         }
//     if (numbers[z] < min)
//         {
//             min = numbers[z];
//         }
// }

// Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
// Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

// void FillArrayRandomNumbers(double[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
//         }
// }
// void PrintArray(double[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
//     Console.WriteLine();
// }