﻿var price = (decimal)-1;

while (price < 0)
{
    Console.Write("Podaj cenę towaru: ");
    price = decimal.Parse(Console.ReadLine());
}

var installmentsCount = 1;

while (installmentsCount < 2 || installmentsCount > 24)
{
    Console.Write("Podaj liczbę rat (od 2 do 24): ");
    installmentsCount = int.Parse(Console.ReadLine());
}

var installmentPayDay = -1;
while (installmentPayDay < 0)
{
    Console.Write("Podaj dzień płatności raty (dzień dla każdego miesiąca, w którym ma być płatna rata): ");
    installmentPayDay = int.Parse(Console.ReadLine());
}

Console.Write("Podaj wpłatę klienta (od 0 zł): ");
var payment = decimal.Parse(Console.ReadLine());


var currentDate = DateTime.Now;

var basePayDate = new DateTime(
    currentDate.Year,
    currentDate.Month,
    installmentPayDay
    );

var payDates = CalculatePayDates(installmentsCount, basePayDate);

var interest = CalculateInterest(installmentPayDay);

var amountOfCredit = price + price * interest;

var instellmentAmount = (amountOfCredit / installmentsCount);

Console.WriteLine(" kwota wypłaty | data płatności | kwota kredytu | odsetki");
foreach (var date in payDates)
{
    amountOfCredit = amountOfCredit - instellmentAmount;
    Console.WriteLine($"{Math.Round(instellmentAmount,2)} | " +
        $"{date.ToString("dd'-'MMMM'-'yyyy")} " +
        $"| {Math.Round(amountOfCredit, 2)} | {interest}");
}

static decimal CalculateInterest(decimal installmentPayDay)
{
    if (installmentPayDay <= 8)
    {
        return 0;
    }
    if (installmentPayDay >= 9 && installmentPayDay <= 12)
    {
        return (decimal)0.05;
    }
    return (decimal)0.08;
}

static DateTime FindPayDate(DateTime payDate, int month)
{
    payDate = payDate.AddMonths(month);
    if (payDate.DayOfWeek.Equals(DayOfWeek.Saturday))
    {
        payDate = payDate.AddDays(2);
    }
    if (payDate.DayOfWeek.Equals(DayOfWeek.Sunday))
    {
        payDate = payDate.AddDays(1);
    }
    return payDate;
}

static List<DateTime> CalculatePayDates(int installmentsCount, DateTime basePayDate)
{
    var payDates = new List<DateTime>();
    for (int month = 0; month < installmentsCount; ++month)
    {
        var payDate = FindPayDate(basePayDate, month);
        payDates.Add(payDate);
    }
    return payDates;
}