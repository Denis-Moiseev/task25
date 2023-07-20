// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double GetExponentiation(int numA, int numB)
{
    double resalt = Math.Pow(numA, numB);
    return resalt;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numA = GetInput("Введите число А: ");
int numB = GetInput("Введите число B: ");
Console.Write($"{numA}, {numB} -> {GetExponentiation(numA, numB)}");