Console.Write("Podaj wielkość tablicy: ");
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

int choosenIndex;
switch (taskNumber)
{
    case 1:
        Console.WriteLine(string.Join(" ", array.OrderBy(x => x)));
        break;
    case 2:
        Console.WriteLine(string.Join(" ", array.OrderByDescending(x => x)));
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
        Console.WriteLine(string.Join(" ", array));
        break;
    default:
        Console.WriteLine("Wrong number");
        break;
}

