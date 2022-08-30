/***************************************************************************
// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите основание: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i = 0; i < b; i++){                    // cycle
    result *= a;                                // main iteration
}
Console.WriteLine("---------------------");
Console.WriteLine($"{a} в степени {b} = {result}");
Console.WriteLine("---------------------");

***************************************************************************/




/***************************************************************************
// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

int Sum(int a){
    int result = 0;
    for (int i = a; i > 0; i = i/10){   // initial counter
        result += a%10;                 // fix result
        a /= 10;                        // decrease main number
    }
    return result;
}

Console.WriteLine("Введите число, сумму которого хотите узнать:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Sum(a));              // usage function

***************************************************************************/




/***************************************************************************
// Задача 29: Напишите программу, которая задаёт массив 
// из произвольных элементов и выводит их на экран.

int[] InitialArray(int a){
    int[] array = new int[a];
    if (a > 0){
        Console.WriteLine($"Введите {a} элементов массива:");
        for (int i = 0; i < a; i++){
            array[i] = Convert.ToInt32(Console.ReadLine());    // array filling
        }
    }
    return array;
}

void PrintArray(int[] Arr){
    if (Arr.Length > 0){
        Console.Write("[");
        for (int i = 0; i < Arr.Length; i++){
            Console.Write(Arr[i]);
            if (i + 1 < Arr.Length) Console.Write(", ");       // Chech to End array
            else Console.Write("]");
        }
        Console.WriteLine();
    }
    else Console.WriteLine("Массив пуст []");
}

Console.WriteLine("Введите размер массива: ");
int[]Arr = InitialArray(Convert.ToInt32(Console.ReadLine())); // usage user function & save her
PrintArray(Arr);                                              // usage user print function

***************************************************************************/



