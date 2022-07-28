using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanych.Model
{
    internal class Wage
    {
        public double Amount { get; set; }
        public int WageId { get; set; }
        public int WorkerId { get; set; }
    }
}