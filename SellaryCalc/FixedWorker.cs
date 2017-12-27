using System;
using System.Collections.Generic;
using System.Text;

namespace SellaryCalc
{
    public class FixedWorker : Worker
    {
        private double _fixedSallary = 1000;

        public override double GatYearSellary()
        {
            return 12 * GatMonthSellary();
        }

        public override double GatMonthSellary()
        {
            return 21 * 8 * _fixedSallary;
        }
    }
}
