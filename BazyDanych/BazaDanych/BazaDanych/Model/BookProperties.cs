using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanych.Model
{
    internal class BookProperties
    {
        [Column("Author Name")]
        public string AuthorName { get; set; }

        [Column("Author Surname")]
        public string AuthorSurname { get; set; }

        [Column("BookID")]
        public int BookId { get; set; }

        [Column("Book Name")]
        public string BookName { get; set; }

        [Column("Department Name")]
        public string DepartmentName { get; set; }

        public override string? ToString()
        {
            return $"{BookId} | {BookName} | {AuthorName} | {AuthorSurname} | {DepartmentName}";
        }
    }
}