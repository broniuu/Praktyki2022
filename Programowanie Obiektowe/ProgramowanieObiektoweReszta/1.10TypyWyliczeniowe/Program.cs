using _1._10TypyWyliczeniowe;

Console.WriteLine("---zad1---");
Console.WriteLine();
Employee[] employees = new Employee[4]
{
    new Employee() { Name = "John", ContractType = ContractType.Trial },
    new Employee() { Name = "Bob", ContractType = ContractType.Trial },
    new Employee() { Name = "Steve", ContractType = ContractType.Intership },
    new Employee() { Name = "Jim", ContractType = ContractType.Other },
};
foreach (var employee in employees)
{
    Console.WriteLine("Employee name is : {0} and contract type is {1}", employee.Name, employee.ContractType);
}

Console.WriteLine();
Console.WriteLine("---zad2---");

Console.WriteLine((int)Day.Thursday);

Console.WriteLine();
Console.WriteLine("---zad3---");

Days MyDays = Days.Nd | Days.Pt;

Console.WriteLine(MyDays);
Console.WriteLine((int)MyDays);
Console.Read();

internal enum Day
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday = 10,
    Friday,
    Saturday,
    Sunday
};

[Flags]
internal enum Days
{
    Pn = 1,
    Wt = 2,
    Śr = 4,
    Czw = 8,
    Pt = 16,
    So = 32,
    Nd = 64
};