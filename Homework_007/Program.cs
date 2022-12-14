/**********************************************************************************************/
// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// double[,] Create2dArray(int m, int n){
//     double[,] array = new double[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             array[i,j] = new Random().NextDouble() * 10; // Filling an array with double type numbers
//         }
//     }
//     return array;
// }

// void Show2dArray(double[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(Math.Round(array[i,j], 1) + "  "); // Round numbers before condition
//         }
//         Console.WriteLine();
//         Console.WriteLine();
//     }
// }

// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] array = Create2dArray(m, n);
// Console.WriteLine();
// Show2dArray(array);

/**********************************************************************************************/
/**********************************************************************************************/
/**********************************************************************************************/
/**********************************************************************************************/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// void MainArray(int i, int j, int[,] array){
//     if(i < array.GetLength(0) && j < array.GetLength(1))          // check element is in an array
//         Console.WriteLine($"Array[{i},{j}] = {array[i,j]}");      // output if element is in an array
//     else Console.WriteLine($"Array[{i},{j}] doesn't exist!");     // output if element is not in an array
// }

// int[,] array = {{2, 4, 5, 7, 6},                                  // stock array
//                 {3, 3, 9, 0, 1},
//                 {5, 0, 3, 2, 7},
//                 {9, 8, 2, 1, 0},
//                 {1, 4, 9, 6, 2}};

// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// MainArray(m,n, array);

/**********************************************************************************************/
/**********************************************************************************************/
/**********************************************************************************************/
/**********************************************************************************************/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// int[,] Array2D(int m, int n){                            // method of initial 2D array
//     int[,] array = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             array[i,j] = new Random().Next(1,10);        // random filling array with user option
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array){                          // method of show 2D array
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// double[] ArrayResult(int[,] array){                      // method of init result array
//     double sum = 0;
//     int m = array.GetLength(0);
//     int n = array.GetLength(1);
//     double[] ArrayResult = new double[n];
//     for(int j = 0; j < n; j++){
//         for(int i = 0; i < m; i++){
//             sum += array[i,j];                                       // sum columns
//         }
//         ArrayResult[j] = Math.Round((Convert.ToDouble(sum/m)), 1);   // find averge of double numbers 
//         sum = 0;
//     }
//     return ArrayResult;
// }

// void ShowArray(double[] array){                          // method of show Array
//     Console.Write("[");
//     for(int i = 0; i < array.Length - 1; i++)
//         Console.Write(array[i] + "; ");
//     Console.Write(array[array.Length - 1] + "]");
//     Console.WriteLine();
// }

// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// if (m > 0 && n > 0){                                     // validation user input (fool protect)
//     int[,] array2d = Array2D(m,n);
//     Console.WriteLine();
//     Console.WriteLine("User's 2D array:");
//     Show2dArray(array2d);
//     Console.WriteLine();
//     double[] Result = ArrayResult(array2d);
//     Console.WriteLine("Average numbers is columns:");
//     ShowArray(Result);
//     Console.WriteLine();
// }
// else Console.WriteLine("Fool protect is working. Try again.");

/**********************************************************************************************/
/**********************************************************************************************/
/**********************************************************************************************/
/**********************************************************************************************/