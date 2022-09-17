// Задача 64: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.

// string RecNumbers(int m, int n){
//     if (m >= n){                                       // stop recursion
//         return Convert.ToString(m) + " ";
//    }
//     else{
//         string outline = RecNumbers(m, n-1) + n + " "; // nain recursion action
//         return outline;
//     }
// }

// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(RecNumbers(m,n));
// Console.WriteLine();

/******************************************************************************************/
/******************************************************************************************/
/******************************************************************************************/
/******************************************************************************************/

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// int RecSum(int m, int n){
//     if (m <= n){
//         int res = 0;                                       
//         return res = n + RecSum(m,n-1);                    // main action in function and return 
//     }
//     else return 0;                                         // stop recursion
// }

// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int result = RecSum(m,n);
// Console.WriteLine(result);
// Console.WriteLine();

/******************************************************************************************/
/******************************************************************************************/
/******************************************************************************************/
/******************************************************************************************/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// int RecAccerman(int m, int n){
//     if (m == 0){
//         return n + 1;                                   // check easy solution without recursion
//     }
//     else{
//         if(m != 0 && n == 0){                           
//             return RecAccerman(m-1, 1);                 // solution with 1 call recursion
//         }
//         else{
//             return RecAccerman(m-1, RecAccerman(m, n - 1)); // main solution, if m and n != 0
//         }
//     }
// }

// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int result = RecAccerman(m,n);
// Console.WriteLine(result);

/******************************************************************************************/
/******************************************************************************************/
/******************************************************************************************/
/******************************************************************************************/