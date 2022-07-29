using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanych.Model
{
    internal class Worker
    {
        public Worker(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int WorkerId { get; set; }

        public override string? ToString()
        {
            return $"{WorkerId} |  {Name} | {WorkerId}";
        }
    }
}