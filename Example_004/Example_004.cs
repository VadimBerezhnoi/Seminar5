Console.Clear();

int[] arrayFib(int n)
{
    int[] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }

    return array;
}

Console.Write("Введите число ");
int nFib = int.Parse(Console.ReadLine()!);
Console.Write(string.Join(", ", arrayFib(nFib)));