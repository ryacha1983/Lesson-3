
// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// int size = 10;
// int[] array = new int[size]; 
// int number = 0;
// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(1,101);
//     if (array[i] >= 20  && array[i] <= 90)
//     {
//         number++;
//     }
// }
// Console.WriteLine($"[ {string.Join("; ",array)} ]");
// Console.WriteLine($"Количество элементов, значения которых лежат в отрезке [20;90] равно: {number}");

// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

// int size = 10;
// int count = 0;
// int[] array = new int[size]; 
// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(1,1001);
//     if (array[i]%2 == 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine($"[ {string.Join("; ",array)} ]");
// Console.WriteLine($"Количство четных чисел в массиве: {count} ");

// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

// double[] array = new double[10];
// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = Math.Round(new Random().NextDouble() * new Random().Next(1001),2);
// }
// double max = array[0];
// double min = array[0]; 
// for (int i = 1; i < array.Length; i++) 
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     if (array[i] < min)
//     {
//         min = array[i];
//     }
// }
// double resultat = max - min;
// resultat = Math.Round(resultat,2);
// Console.WriteLine($"Результат: [ {string.Join("; ",array)} ]");
// Console.WriteLine($"Максимальное число: {max}");
// Console.WriteLine($"Минимальное число: {min}");
// Console.WriteLine($"Разница: {resultat}");

// // Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. 
// Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. 
// Размер массива должен быть равен количеству цифр.


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string digits = String.Empty;
// while (number > 0 )
// {
//     digits = (number % 10).ToString() + digits;
//     number /= 10;
// }
// int size = digits.Length;
// // Console.WriteLine(size); 
// char[] array = new char[size];
// for (int i = 0; i < size; i++) // array.Length = size
// {
//     array[i]= digits[i];  
// }
// Console.WriteLine($"Результат: [ {string.Join(" ",array)} ]");
