using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3PolaKlasyZad2
{
    internal class Invoice
    {
        private int InvoiceId { get; set; }
        private string SellerName { get; set; }
        private string BuyerName { get; set; }

        private string NameGood { get; set; }
        public DateTime DayOfIssue { get; set; }
        public decimal UnitPrice { get; set; }
        private decimal TaxesSum { get; set; }

    }
}
