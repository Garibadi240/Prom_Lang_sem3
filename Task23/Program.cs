
Console.Clear();

int userNumber = ReadNumber("Введите число N: ");
SquareSequence(userNumber);

static int ReadNumber(string messege)
{
    int num = 0;
    try
    {
        while (true)
        {
            Console.Write(messege);
            num = int.Parse(Console.ReadLine() ?? "");
            break;
        }
    }
    catch (Exception problem)
    {
        Console.WriteLine("Неверные данные");
    }

    return num;
}

static void SquareSequence(int N)
{
    int i =1 ;

    while (i<N)
    {
        Console.Write($"{i*i*i}, ");
        i++;
    }
    Console.Write($"{i*i*i}.");
}
