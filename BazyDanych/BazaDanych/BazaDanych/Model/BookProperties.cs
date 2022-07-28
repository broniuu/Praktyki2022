using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanych.Model
{
    internal class BookProperties
    {
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        public int BookId { get; set; }
        public int BookName { get; set; }
        public string DepartmentName { get; set; }
    }
}