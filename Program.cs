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