//Задача 19 
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Input your number: ");
string number = Console.ReadLine();

void CheckNumber(string number)
{
    if (number[0] == number[4] || number[1] == number[3])
    {
        Console.WriteLine($"Your number: {number} is palindrome");
    }
    else Console.WriteLine($"Your number: {number} is not a palindrome");
}

if (number.Length == 5) 
{
    CheckNumber(number);
}
else
Console.WriteLine($"Error");
*/



//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

/*
double longLineAB(int xA, int xB, int yA, int yB, int zA, int zB)
{
    double longLine = Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));
    return longLine;
}

Console.WriteLine("Input X coord of A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y coord of A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Z coord of A: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input X coord of B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y coord of B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input Z coord of B: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = longLineAB(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);
Console.WriteLine($"Distance between A ({xCoordA}, {xCoordB}), B ({yCoordA}, {yCoordB}) and ({zCoordA}, {zCoordB}) is {dist}");
*/

/*
//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void SqurePrinter(int numberN)
{
    int current = 1;
    while (current <= numberN)
    {
        double res = Math.Pow(current, 3);
        Console.Write($"{res: f0} ");
        current++;
    }
    Console.WriteLine("\b.");
}

Console.Write("Input number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > 0)
    SqurePrinter (userNumber);
    else
    SqurePrinter(userNumber);
*/