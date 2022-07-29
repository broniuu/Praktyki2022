namespace BazaDanych.Model
{
    internal class Author
    {
        public Author(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Author()
        {
        }

        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public override string? ToString()
        {
            return $"{AuthorId} | {Name} |  {Surname}";
        }
    }
}