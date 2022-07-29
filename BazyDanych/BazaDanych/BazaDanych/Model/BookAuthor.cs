using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanych.Model
{
    internal class BookAuthor
    {
        public BookAuthor(int auhtorId, int bookId)
        {
            AuhtorId = auhtorId;
            BookId = bookId;
        }

        public int AuhtorId { get; set; }
        public int BookId { get; set; }

        public override string? ToString()
        {
            return $"{AuthorId} | {BookId}";
        }
    }
}