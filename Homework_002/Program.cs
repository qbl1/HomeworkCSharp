/*********************************************************************************************
// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

int secondDigit (int a){
    int result = a / 10;                                            // delete right digit
    result = result % 10;                                           // delete left digit
    return result;
}

while(true){                                                        // infinite cycle for testing
    Console.WriteLine("Введите 3-х значное число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a > 99 && a < 1000){
        Console.WriteLine("Вторая цифра числа: " + secondDigit(a)); // call function
    }
    else{
        Console.WriteLine("Число не соответствует условию!");       // call function
    }
}
*********************************************************************************************/




/*********************************************************************************************
// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

int thirdDigit (int a){
    if (a > 99){
        while (a > 999){
            a = a / 10;                                // del right digit
        }
        int result = a % 10;                           // get right number of three digit number
        return result;
    }
    else{
        return -1;                                     // return if number less than two digits
    }
}

while(true){                                           // infinite cycle for testing
    Console.WriteLine("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int Result = thirdDigit(a);
    if (Result != -1){                                 // if number consists of 2 number or more
        Console.WriteLine("Третья цифра числа: " + Result);
    }
    else{
        Console.WriteLine("Третьей цифры нет!");
    }
}
*********************************************************************************************/




/*********************************************************************************************
// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

int week (int a){
    if (a > 0 && a < 6){ return 0; }                    // if workday
    else if (a > 5 && a < 8) { return 1; }              // if weekend
    else { return -1; }                                 // if bad input
}

while(true){                                            // cycle for testing
    Console.WriteLine("Введите цифру дня недели: ");
    int day = Convert.ToInt32(Console.ReadLine());
    if(week(day) == 0) {Console.WriteLine("Это рабочий день!");}
    else if(week(day) == 1) {Console.WriteLine("Это выходной день!");}
    else if(week(day) == -1) {Console.WriteLine("Ошибка ввода!");}
}
*********************************************************************************************/