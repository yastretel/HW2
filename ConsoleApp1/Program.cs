int Prompt (string message)
{
    System.Console.WriteLine (message);
    string value = Console.ReadLine ();
    int result = Convert.ToInt32 (value);
    return result;
}

int number = Prompt("Введите трёхзначное число");
if (number <100 || number >= 1000)
{
    Console.WriteLine ("Вы ввели не трёхзначное число");
    return;
}

int second = number / 10 % 10;
Console.WriteLine(second);