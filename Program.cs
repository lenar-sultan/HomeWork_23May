// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void PrintNumbers(int n)
// {
//     if (n == 1) Console.WriteLine(1);
//     else
//     {
//         Console.WriteLine(n);
//         PrintNumbers(n - 1);

//     }
// }

// Console.Write("введите число N: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// PrintNumbers(numb -1);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// static int GetSum(int m, int n)
// {
//     if (m == n)
//     {
//         return m;
//     }
//     else
//     {
//         return m + GetSum(m + 1, n);
//     }
// }

// static void PrintNumbers(int m, int n)
// {
//     if (m == n)
//     {
//         Console.Write(m);
//     }
//     else
//     {
//         Console.Write(m + ", ");
//         PrintNumbers(m + 1, n);
//     }
// }


// Console.Write("введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
//  Console.Write($"Сумма натуральных чисел от {m} до {n}: {GetSum(m,n)} ");



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



// Console.Write("введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"A(m,n) = :{Ackermann(m, n)} ");
// int result = Ackermann(m, n);



// static int Ackermann(int m, int n)
// {
//     if (m == 0)
//     {
//         int result = n + 1;
//         return result;
//     }
//     else if (m > 0 && n == 0)
//     {
//         int result = Ackermann(m - 1, 1);
//         return result;
//     }
//     else if (m > 0 && n > 0)
//     {
//         int result = Ackermann(m - 1, Ackermann(m, n - 1));

//         return result;
//     }
//     else
//     {
//         Console.WriteLine("Ошибка: некорректные данные");
//         return -1;
//     }
// }
