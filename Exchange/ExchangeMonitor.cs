using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange
{
    class ExchangeMonitor
    {
        public decimal Total;
        public int Counter;

        public void Monitor(decimal currentAmount)
        {
            Total = Total + currentAmount;
            Counter++;
        }
        public decimal TotalMoney()
        {
            return Total;
        }
        public int ConvCounter()
        {
            return Counter;
        }
    }
}
