
PrintAkker(ReadInt("Введите число M"),ReadInt("Введите число N"));

int ReadInt(string message)
{
    Console.Write(message + " -> ");
    return Convert.ToInt32(Console.ReadLine());
}
void PrintAkker(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}