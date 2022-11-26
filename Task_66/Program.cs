
PrintChecking(ReadInt("Введите число M"), ReadInt("Введите число N"));

 int ReadInt(string message)
{
    Console.Write(message + " -> ");
    return Convert.ToInt32(Console.ReadLine());
}
void PrintChecking(int number1, int number2)
{
    if(number1 < number2 )
    {
      Console.Write(Sum(number1 - 1, number2));
    }
    else
    {
      Console.Write(Sum(number2 - 1, number1));
    }
}
int Sum(int number1, int number2)
{
    int result = number1;
    if (number1 == number2)
        return 0;
    else
    {
        number1++;
        result = number1 + Sum(number1, number2);
        return result;
    }
}