/******************************************************************************************************
// Задача* Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

int[] Array(int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array[i] = new Random().Next(min, max+1);      // Filling an array with random numbers
    }
    return array;
}

void ShowArray(int[] array){                           // Function for print array
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]} ");                 // Output elememets of array
        }
}

int[] MplArray(int[] array){                           // Function for multiply numbers in array
    int length1 = array.Length;                        // Length of array
    if(array.Length % 2 == 0){                         // If array honest
        int[] arrayRes = new int[array.Length/2];      // Create result array
        int length2 = length1/2;                       // Length of half array
        for(int i = 0; i < length2; i++){
            arrayRes[i] = array[i]*array[length1 - 1]; // Filling result array
            length1--;
        }
        return arrayRes;                               // Return result array
    }
    else{                                              // If array odd
        int[] arrayRes = new int[array.Length/2 + 1];  // Create half array +1 element
        int length2 = length1/2;
        for(int i = 0; i < length2; i++){
            arrayRes[i] = array[i]*array[length1 - 1];
            length1--;
        arrayRes[length2] = array[length2];
        }
        return arrayRes;                               // Return result array
    }
}

Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите наименьшее значение массива ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите наибольшее значение массива ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = Array(size, min, max);                    // Saving a user array
int[] mplArray = MplArray(array);                           // Saving resulting array
ShowArray(array);                                       // Print user array
Console.WriteLine();
ShowArray(mplArray);                                    // Print multiply array
Console.WriteLine();

******************************************************************************************************/




// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.