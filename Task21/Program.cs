Console.Clear();

int a1 = ReadNumber("Введите координаты первой точки: ");
int a2 = ReadNumber("");
int a3 = ReadNumber("");

int b1 = ReadNumber("Введите координаты второй точки: ");
int b2 = ReadNumber("");
int b3 = ReadNumber("");


Console.WriteLine($"Расстояние равно: {DistanceCalculation(a1, a2, a3, b1, b2, b3)}"); 


static int ReadNumber(string messege)
{
    int num = 0;
    try
    {
        while (true)
        {
            Console.WriteLine(messege);
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

static double DistanceCalculation(int a1, int a2, int a3, int b1, int b2, int b3)
{
    return Math.Sqrt(Math.Pow(b1-a1, 2)+Math.Pow(b2-a2, 2)+Math.Pow(b3-a3, 2));
}
