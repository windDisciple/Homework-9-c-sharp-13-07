//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.

// void ShowNumbers(int n)
// {
//     if (n >= 1)
//     {
//         Console.Write(n + " ");
//         ShowNumbers(n - 1);
//     }
// }

// ShowNumbers(5);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int Sum(int m, int n)
// {
//     if (m != n && m > n) return Sum(m - 1, n) + m;
//     else if (m != n && n > m) return Sum(m, n - 1) + n;
//     else return m;
// }

// Console.Write(Sum(1, 15));

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    else return m;
}

Console.Write(Akkerman(3, 2));