int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetSecond(int number)
{

    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidNUmber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;

}

int number = Prompt("Введите число");
if (ValidNUmber(number))
{
    Console.WriteLine(GetSecond(number));
}
