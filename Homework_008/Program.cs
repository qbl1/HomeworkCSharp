/**********************************************************************************************/
/**********************************************************************************************/
/**********************************************************************************************/
/**********************************************************************************************/

// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] SortingNumbersInRows(int[,] array){                          // sorting function
//     int tmp = 0;
//     for(int k = 0; k < 5; k++){
//         for(int m = 0; m < 5; m++){
//             for(int i = 0; i < array.GetLength(0); i++)
//                 for(int j = 0; j < array.GetLength(1) - 1; j++){
//                     if(array[i,j] < array[i, j + 1]){
//                         tmp = array[i, j + 1];
//                         array[i, j + 1] = array[i, j];
//                         array[i, j] = tmp;
//                     }
//                 }
//         }
//     }
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] Array2d = {{4, 2, 6, 9, 0},
//                   {3, 7, 1, 2, 8},
//                   {1, 5, 8, 9, 2},
//                   {6, 2, 3, 4, 1},
//                   {0, 8, 9, 3, 4}
// };

// Show2dArray(Array2d);
// int[,] ArraySort = SortingNumbersInRows(Array2d);
// Console.WriteLine();
// Show2dArray(ArraySort);

/**********************************************************************************************/
/**********************************************************************************************/
/**********************************************************************************************/
/**********************************************************************************************/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// int ArrayMinimalRows(int[,] array){
//     int result = 0;
//     int row = 0;
//     int tmp = 0;
//     for(int j = 0; j < array.GetLength(1); j++){    // sum of start
//         result += array[0,j];
//     }
//     for(int i = 1; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             tmp += array[i,j];
//         }
//         if(tmp < result){                           // if sum is minimal
//             result = tmp;
//             row = i + 1;
//             tmp = 0;
//         }
//         else tmp = 0;
//    }
//    return row;
// }

// void Show2dArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] Array2d = {{4, 2, 6, 9, 9},
//                   {3, 7, 1, 2, 8},
//                   {1, 5, 8, 9, 2},
//                   {6, 2, 3, 4, 1},
//                   {0, 8, 9, 3, 4},
//                   {0, 1, 2, 1, 3}
// };

// Show2dArray(Array2d);
// int ArraytmpRows = ArrayMinimalRows(Array2d);
// Console.WriteLine();
// Console.WriteLine($"Sum numbers in {ArraytmpRows} string is minimal.");

/**********************************************************************************************/
/**********************************************************************************************/
/**********************************************************************************************/
/**********************************************************************************************/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// int[,] ArraySnakeFilling(int[,] array){
//     int number = 1;
//     int startRows = 0;
//     int startCols = 0;
//     int endRows = array.GetLength(0);
//     int endCols = array.GetLength(1);

//     // Общий цикл
//     for(int n = 0; n <= 2; n++){
//         // Проход вправо
//         for(int j = startCols; j < endCols; j++){
//             array[startRows,j] = number;
//             number++;
//         }
//         startRows++;

//         // Проход вниз
//         for(int i = startRows; i < endRows; i++){
//             array[i,endCols-1] = number;
//             number++;
//         }
//         endCols--;// 3

//         // Проход влево
//         for(int j = endCols-1; j >= startCols; j--){
//             array[endRows-1,j] = number;
//             number++;
//         }
//         endRows--;

//         // Проход вверх
//         for(int i = endRows - 1; i > startRows; i--){
//             array[i,startCols] = number;
//             number++;
//         }
//         endCols--;
//     }
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             if(array[i,j] < 10)
//                 Console.Write("0" + array[i,j] + " ");
//             else Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] ArraySrc = {{0, 0, 0, 0},
//                    {0, 0, 0, 0},
//                    {0, 0, 0, 0},
//                    {0, 0, 0, 0}
// };

// Show2dArray(ArraySrc);
// int[,] ArrayOutput = ArraySnakeFilling(ArraySrc);
// Console.WriteLine();
// Show2dArray(ArrayOutput);