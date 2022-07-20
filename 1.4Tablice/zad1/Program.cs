﻿Console.Write("Podaj wielkość tablicy: ");
var size = int.Parse(Console.ReadLine());

var array = new int[size];
for (var i = 0; i < size; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Uporządkowanie elementów w tablicy od najmniejszego do największego i wypisanie ich - 1");
Console.WriteLine("Uporządkowanie elementów tablicy od największego do najmniejszego i wypisanie ich - 2");
Console.WriteLine("Wypisanie największego i najmniejszego elementu - 3");
Console.WriteLine("Wypisanie elementu o podanym nr indexu (po wybraniu tej opcji aplikacja wypiszę dostępne indexy elementów) - 4");
Console.WriteLine("Zastąpienie elementu o podanym indexie, nowym elementem - 5");
var taskNumber = int.Parse(Console.ReadLine());

var newArray = new int[array.Length];
int choosenIndex;
switch (taskNumber)
{
    case 1:
        newArray = array.OrderBy(x => x).ToArray();
        WriteArray(newArray);
        break;
    case 2:
        newArray = array.OrderByDescending(x => x).ToArray();
        WriteArray(newArray);
        break;
    case 3:
        var greatestElement = array.Max();
        var smallestElement = array.Min();
        Console.WriteLine($"Największy: {greatestElement}");
        Console.WriteLine($"Najmniejszy: {smallestElement}");
        break;
    case 4:
        Console.Write("Wyierz numer indeksu: ");
        choosenIndex = int.Parse(Console.ReadLine());
        Console.WriteLine($"element o podanym indeksie {array[choosenIndex]}");
        Console.Write($"Dostępne indexy: ");
        for (var i = 0; i < size; i++)
        {
            if (i != choosenIndex)
            {
                Console.Write($"{i} ");
            }   
        }
        break;
    case 5:
        Console.Write("Wyierz numer indeksu: ");
        choosenIndex = int.Parse(Console.ReadLine());
        Console.Write("Wpisz nową wartość dla indeksu: ");
        array[choosenIndex] = int.Parse(Console.ReadLine());
        Console.Write("Zaktualizowana Tablica: ");
        WriteArray(array);
        break;
    default:
        Console.WriteLine("Wrong number");
        break;
}
if (taskNumber == 1)
{


} else if (taskNumber == 2)
{


} else if (taskNumber == 3)
{


} else if (taskNumber == 4)
{


} else if (taskNumber == 5)
{

} else
{
    
}

static void WriteArray(IEnumerable<int> items)
{
    foreach (var element in items)
    {
        Console.Write($"{element} ");
    }
    Console.WriteLine();
}


