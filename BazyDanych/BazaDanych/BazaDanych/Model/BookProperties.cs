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
        [Column("AuthorName")]
        public string AuthorName { get; set; }

        [Column("AuthorSurname")]
        public string AuthorSurname { get; set; }

        [Column("BookID")]
        public int BookId { get; set; }

        [Column("BookName")]
        public string BookName { get; set; }

        [Column("DepartmentName")]
        public string DepartmentName { get; set; }
    }
}