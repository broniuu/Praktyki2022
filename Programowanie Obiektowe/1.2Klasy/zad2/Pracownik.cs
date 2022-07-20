using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Pracownik
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private decimal Salary { get; set; }
        private int VacationDays { get; set; }
        private int UsedVacationDays { get; set; }


        public Pracownik(string name,
                         string surname,
                         decimal salary,
                         int vacationDays,
                         int usedVacationDays)
        {
            this.Name = name;
            this.Surname = surname;
            this.Salary = salary;
            this.VacationDays = vacationDays;
            this.UsedVacationDays = usedVacationDays;
        }

        public int getUnusedVacationDays()
        {
            return this.VacationDays - this.UsedVacationDays;
        }
    }
}
