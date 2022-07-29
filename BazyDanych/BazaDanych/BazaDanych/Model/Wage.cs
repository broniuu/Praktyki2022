using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDanych.Model
{
    internal class Wage
    {
        public Wage(decimal amount, int workerId)
        {
            Amount = amount;
            WorkerId = workerId;
        }

        public decimal Amount { get; set; }
        public int WageId { get; set; }
        public int WorkerId { get; set; }
    }
}