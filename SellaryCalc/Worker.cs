using System;
using System.Collections.Generic;
using System.Text;

namespace SellaryCalc
{
    public abstract class Worker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract double GatMonthSellary();

        public abstract double GatYearSellary();
    }
}
