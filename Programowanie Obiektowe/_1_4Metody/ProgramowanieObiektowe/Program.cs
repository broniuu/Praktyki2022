using ProgramowanieObiektowe;

static int Sum(int a, int b)
{
    return a + b;
}

static string Unite(string a, string b)
{
    return string.Concat(a.Concat(b));
}

static Human MakeHuman(string name, string surname, DateTime bornDate)
{
    return new Human
    {
        Name = name,
        Surname = surname,
        BornDate = bornDate,
    };
}
static void Nothing() { }
