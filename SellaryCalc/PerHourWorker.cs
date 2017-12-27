using System;
using System.Collections.Generic;
using System.Text;

namespace SellaryCalc
{
    public class PerHourWorker : Worker
    {
        private double _perHourSellary = 50;

        public override double GatYearSellary()
        {
            return 12 * GatMonthSellary();
        }

        public override double GatMonthSellary()
        {
            return 21 * 8 * _perHourSellary;
        }
    }
}
