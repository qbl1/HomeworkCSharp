/**************************************************************************************************
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] InputArray(int m){                                    // Function for input and save user numbers.
    int[] array = new int[m];
    for(int i = 0; i < m; i++){
        Console.WriteLine($"Input {i+1} number of {m}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int SumPositiveNumber(int[] array){                         // Function for counting positive numbers.
    int result = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] > 0) result += 1;
    }
    return result;
}

void ShowArray(int[] array){                               // Function for print array.
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");                     // Output elements of array.
        }
}

Console.WriteLine("Input number M: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = InputArray(m);
ShowArray(array);
Console.WriteLine();
Console.WriteLine("Amoutn positive numbers = " + SumPositiveNumber(array));

**************************************************************************************************/




/**************************************************************************************************
// Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

double[] IntersectionPoint(double b1, double k1, double b2, double k2){     // function for find intersection point
    double[] array = new double[2];
    array[0] = (b2 + b1 * (-1)) / (k1 + k2 * (-1));                         // find x
    array[1] = k1 * array[0] + b1;                                          // find y
    return array;                                                           // return array with x, y
}

Console.WriteLine("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double[] array = IntersectionPoint(b1, k1, b2, k2);

Console.WriteLine($"Dot cross 2 lines is ({array[0]}, {array[1]})");        // output solution

**************************************************************************************************/