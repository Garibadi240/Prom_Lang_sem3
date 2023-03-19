
Console.Clear();

int userNumber = ReadNumber("Введите пятизначное число: ");
CheckPalindrome(userNumber);

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

static void CheckPalindrome(int a)
{
    if (a / 10000 == a % 10)
    {
        int LeftRem1_2 = a / 1000;
        int LeftRem2 = LeftRem1_2 % 10;

        int RightRem4_5 = a % 100;
        int RightRem4 = RightRem4_5 / 10;

        if (LeftRem2 == RightRem4)
        {
            Console.WriteLine($"{a} данное число палиндром.");
        }
        else
        {
            Console.WriteLine($"{a} данное число не палиндром.");
        }
    } else
    {
         Console.WriteLine($"{a} данное число не палиндром.");
    }
}
