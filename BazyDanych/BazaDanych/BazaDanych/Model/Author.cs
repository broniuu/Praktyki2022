namespace BazaDanych.Model
{
    internal class Author
    {
        public Author(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}