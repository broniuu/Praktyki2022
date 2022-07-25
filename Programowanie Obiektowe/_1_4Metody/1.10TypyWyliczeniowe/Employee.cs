namespace _1._10TypyWyliczeniowe
{
    public class Employee
    {
        public string Name { get; set; }
        public ContractType ContractType { get; set; }
    }
    public enum ContractType
    {
        Trial, Intership, Temporaty, Other
    }

}
