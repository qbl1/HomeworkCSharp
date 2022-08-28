/*****************************************************************************************************
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

void Polindrom(int a){
    if ((a / 10000 == a % 10) && ((a / 1000) % 10 == (a % 100) / 10)){  // main check number
        Console.WriteLine("This is polindrom.");                        // if number is polindrom
        }
    else {
        Console.WriteLine("This is NOT polindrom.");                    // if number is not polindrom
    }
}
while(true){                                                            // infinite cycle for testing
    Console.WriteLine("Input 5-th numbers:");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a >9999 && a < 100000) Polindrom(a);                            // fool protection
    else Console.WriteLine("Ввод не соответствует условию!");
}
*****************************************************************************************************/




/*****************************************************************************************************
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

double Line3D (int x1, int y1, int z1, int x2, int y2, int z2){
    return Math.Sqrt((Math.Pow((x2 - x1), 2))                       // return solution
                   + (Math.Pow((y2 - y1), 2))
                   + (Math.Pow((z2 - z1), 2)));
}
Console.WriteLine("Введите координаты 1-й точки:");
Console.Write("x1 = : ");
int x1 = Convert.ToInt32(Console.ReadLine());                       // user input
Console.Write("y1 = : ");
int y1 = Convert.ToInt32(Console.ReadLine());                       // user input
Console.Write("z1 = : ");
int z1 = Convert.ToInt32(Console.ReadLine());                       // user input

Console.WriteLine("Введите координаты 2-й точки:");
Console.Write("x2 = : ");
int x2 = Convert.ToInt32(Console.ReadLine());                       // user input
Console.Write("y2 = : ");
int y2 = Convert.ToInt32(Console.ReadLine());                       // user input
Console.Write("z2 = : ");
int z2 = Convert.ToInt32(Console.ReadLine());                       // user input

Console.WriteLine("Distance between 2 dots in 3D space: "           // function call and
                  +Math.Round(Line3D(x1, y1, z1, x2, y2, z2), 2));  // output rounded number
*****************************************************************************************************/




/*****************************************************************************************************
// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N

void Cube(int n){
    int i = 1;
    while (i <= n){
        Console.Write(i*i*i);                   // solution
        if (i + 1 <= n){
            Console.Write(", ");
        }
        i++;
    }
    Console.WriteLine();
}

Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
Cube(n);                                       // call function
*****************************************************************************************************/