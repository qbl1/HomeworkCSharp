//Homework 21.08.2022

/**********************************************************************
// Задача 2: Напишите программу, которая на вход принимает два числа и
// выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());        // Input first number
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());        // Input second number
if (a > b) {
    Console.WriteLine("Число " + a +" больше.");    // If first max, output first number
}
else{
    Console.WriteLine("Число " + b +" больше.");    // If second max, output second number
}
**********************************************************************/




/**********************************************************************
// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());                            // Input first number
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());                            // Input second number
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());                            // Input third number
if (a > b) {
    if (a > c){
        Console.WriteLine("Число " + a +" больше остальных чисел.");    // If a max - output number.
    }
    else {
        Console.WriteLine("Число " + c +" больше остальных чисел.");    // If c max - output number.
    }
}
else{
    if (b > c){
        Console.WriteLine("Число " + b +" больше остальных чисел.");    // If b max - output number.
    }
    else {
        Console.WriteLine("Число " + c +" больше остальных чисел.");    // If c max - output number.
    }
}
**********************************************************************/




/**********************************************************************
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());        // User input.
if (a%2 == 0){                                      // Check even or odd.
    Console.WriteLine("Число " + a + " четное.");   // Output number, if even.
}
else{
    Console.WriteLine("Число " + a + " нечетное."); // Output number, if odd.
}
**********************************************************************/




/**********************************************************************
// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i <= a){
    Console.Write(i);
    if (i+1 < a){
        Console.Write(", ");
    }
    i = i + 2;
}
Console.WriteLine();
**********************************************************************/