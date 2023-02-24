int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeek(int weekday)
{
    if (weekday > 5)
    {
        return true;
    }
    return false;
}

bool ValidWeekDay(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    return false;
}

int weekDay = Prompt("Введите день недели");
if (ValidWeekDay(weekDay))
{
    if (IsWeek(weekDay))
    {
        Console.WriteLine("WeekEND");
    }
    else
    {
        Console.WriteLine("Not weekend");
    }
}