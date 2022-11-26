

int count = 1;
NaturalToLow(ReadInt("Введите число"), count);

 int ReadInt(string message)
{
    Console.Write(message + " -> ");
    return Convert.ToInt32(Console.ReadLine());
}
void NaturalToLow(int n, int count)
{
    if (count < n + 1)
    {
        NaturalToLow(n, count + 1);
        Console.Write(count + " ");
        
    }
    else
    {
        return;
    }
}

