﻿Console.WriteLine("Podaj wybierz operację: ");
Console.WriteLine("1) dodawanie");
Console.WriteLine("2) odejmowanie");
Console.WriteLine("3) mnożenie");
Console.WriteLine("4) dzielenie");
Console.WriteLine("5) reszta z dzielenia");
Console.WriteLine("6) przesunięcie bitowe w prawo");
Console.WriteLine("7) przesunięcie bitowe w lewo");
Console.WriteLine("8) uzupełnienie bitowe");
Console.WriteLine("9) and");
Console.WriteLine("10) xor");
Console.WriteLine("11) or");

var operationNumber = int.Parse(Console.ReadLine());

if(operationNumber == 8)
{
    Console.Write("Podaj liczbę: ");
    var number = int.Parse(Console.ReadLine());
    Console.WriteLine(~number);
}
else
{
    Console.Write("Podaj pierwszą liczbę: ");
    var number1 = int.Parse(Console.ReadLine());
    Console.Write("Podaj liczbę: ");
    var number2 = int.Parse(Console.ReadLine());
    if(operationNumber == 1)
    {
        Console.WriteLine(number1+number2);
    }
    if (operationNumber == 2)
    {
        Console.WriteLine(number1 - number2);

    }
    if (operationNumber == 3)
    {
        Console.WriteLine(number1 * number2);

    }
    if (operationNumber == 4)
    {
        Console.WriteLine(number1 / number2);

    }
    if (operationNumber == 5)
    {
        Console.WriteLine(number1 % number2);

    }
    if (operationNumber == 6)
    {
        Console.WriteLine(number1 >> number2);

    }
    if (operationNumber == 7)
    {
        Console.WriteLine(number1 << number2);

    }
    if (operationNumber == 9)
    {
        Console.WriteLine(number1 & number2);
    }
    if (operationNumber == 10)
    {
        Console.WriteLine(number1 ^ number2);
    }
    if (operationNumber == 11)
    {
        Console.WriteLine(number1 | number2);
    }
}
