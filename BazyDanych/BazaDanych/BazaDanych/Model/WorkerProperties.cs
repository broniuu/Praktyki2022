using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanych.Model
{
    internal class WorkerProperties
    {
        public decimal Amount { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int WorkerId { get; set; }

        public override string? ToString()
        {
            return $"{WorkerId} |  {Name} |  {Surname} | {Amount}";
        }
    }
}