ChooseTask();

static void ChooseTask()
{
    Console.WriteLine("Spotkanie Firmowe - 1");
    Console.WriteLine("Rozmowa z nativespeakerem - 2");
    Console.WriteLine("Praca nad projektem - 3");

    var taskNumber = int.Parse(Console.ReadLine());

    Console.Clear();

    ChooseLogMethods(taskNumber);
}

static TimeSpan WorkLog(int taskNumber, int numberOfMinuts, int numberOfHours = 0, int numberOfDays = 0)
{
    Console.Clear();
    Console.WriteLine("----Zalogowano zadanie!----");
    Console.WriteLine($"numer zadania: {taskNumber}");

    if (numberOfDays != 0)
    {
        Console.WriteLine($"liczba dni: {numberOfDays}");
    }
    if(numberOfHours != 0)
    {
        Console.WriteLine($"liczba godzin: {numberOfHours}");
    }

    Console.WriteLine($"liczba minut: {numberOfMinuts}");

    return new TimeSpan(numberOfDays, numberOfHours, numberOfMinuts, 0);
}

static void ChooseLogMethods(int taskNumber)
{
    Console.WriteLine("Jakie dane chcesz podać?");
    Console.WriteLine("liczba dni, liczba godzin, liczba minut - 1");
    Console.WriteLine("liczba godzin, liczba minut - 2");
    Console.WriteLine("liczba minut - 3");

    int methodNumber;

    var success = int.TryParse(Console.ReadLine(), out methodNumber);

    if (!success)
        ChooseTask();
    

    if (methodNumber == 1)
    {
        LogDaysHoursAndMinutes(taskNumber);
    }
    else if (methodNumber == 2)
    {
        LogHoursAndMinutes(taskNumber);
    }
    else
    {
        LogMinutes(taskNumber);
    }
    GoBackToMenu(taskNumber);
}

static void LogDaysHoursAndMinutes(int taskNumber)
{
    Console.Write("Podaj liczbę dni: ");
    int numberOfDays;
    var dayParsingSuccess = int.TryParse(Console.ReadLine(), out numberOfDays);

    Console.Write("Podaj liczbę godzin: ");
    int numberOfHours;
    var hoursParsingSuccess = int.TryParse(Console.ReadLine(), out numberOfHours);

    Console.Write("Podaj liczbę minut: ");
    int numberOfMinutes;
    var minutesParsingSuccess = int.TryParse(Console.ReadLine(), out numberOfMinutes);

    if (!dayParsingSuccess || !hoursParsingSuccess || !minutesParsingSuccess)
    {
        Console.Write($"Nie udało się zalogować zadania numer {taskNumber}");
        GoBackToMenu(taskNumber);
    }

    WorkLog(taskNumber,numberOfMinutes,numberOfHours,numberOfDays);
}

static void LogHoursAndMinutes(int taskNumber)
{
    Console.Write("Podaj liczbę godzin: ");
    int numberOfHours;
    var hoursParsingSuccess = int.TryParse(Console.ReadLine(), out numberOfHours);

    Console.Write("Podaj liczbę minut: ");
    int numberOfMinutes;
    var minutesParsingSuccess = int.TryParse(Console.ReadLine(), out numberOfMinutes);

    if (!hoursParsingSuccess || !minutesParsingSuccess)
    {
        Console.Write($"Nie udało się zalogować zadania numer {taskNumber}");
        GoBackToMenu(taskNumber);
    }

    WorkLog(taskNumber, numberOfMinutes, numberOfHours);
}

static void LogMinutes(int taskNumber)
{

    Console.Write("Podaj liczbę minut: ");
    int numberOfMinutes;
    var minutesParsingSuccess = int.TryParse(Console.ReadLine(), out numberOfMinutes);

    if (!minutesParsingSuccess)
    {
        Console.Write($"Nie udało się zalogować zadania numer {taskNumber}");
        GoBackToMenu(taskNumber);
    }

    WorkLog(taskNumber, numberOfMinutes);
}

static void GoBackToMenu(int taskNumber)
{
    Thread.Sleep(5000);
    Console.Clear();
    ChooseTask();
}