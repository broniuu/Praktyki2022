namespace BazaDanych.Model
{
    internal class Book
    {
        public Book(string name, int departmentId)
        {
            Name = name;
            DepartmentId = departmentId;
        }

        public int BookId { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public override string? ToString()
        {
            return $"{BookId} | {DepartmentId} |  {Name}";
        }
    }
}