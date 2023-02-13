Console.Clear();

bool FindTriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.WriteLine("Введите сторону A: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите сторону B: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите сторону C: ");
int c = int.Parse(Console.ReadLine()!);

if (FindTriangle(a, b, c))
{
    System.Console.WriteLine("Треугольник существует");
}

else
{
    System.Console.WriteLine("Треугольник не существует");
}