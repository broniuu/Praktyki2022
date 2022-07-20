Console.Write("Podaj liczbę naturalną (> 0): ");
var n = int.Parse(Console.ReadLine());
var boolArray = new bool[n,n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (HasNotCommonDivisior(i+1,j+1))
        {
            boolArray[i,j] = true;
        } else
        {
            boolArray[i,j] = false;
        }
    }
}

WriteBooleanArray(boolArray);

static void WriteBooleanArray(bool[,] boolArray)
{
    var n = boolArray.GetLength(0);
    Console.Write("   ");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"  {i + 1}");
    }
    Console.WriteLine();

    for (int i = 0; i < n; i++)
    {
        for (var j = 0; j < n; j++)
        {
            if (j == 0)
                Console.Write($"  {i + 1}");
            if (boolArray[i, j] == true)
                Console.Write("  +");
            else
                Console.Write("  .");
        }
        Console.WriteLine();
    }
}

static bool HasNotCommonDivisior(int number1, int number2)
{
    int buffer;

    while (number2 != 1)
    {
        buffer = number1 % number2;
        if (buffer == 0)
            return false;
        number1 = number2;
        number2 = buffer;
    }
    return true;
}
