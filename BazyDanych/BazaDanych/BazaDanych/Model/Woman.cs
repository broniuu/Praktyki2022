using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanych.Model
{
    internal class Woman
    {
        public string WomanName { get; }
        public string WomanSurname { get; }

        public override string? ToString()
        {
            return $"{WomanName} |  {WomanSurname}";
        }
    }
}