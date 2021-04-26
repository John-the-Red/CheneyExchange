using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange
{
    static class Exchanger
    {
        static ExchangeMonitor EM = new ExchangeMonitor();
        public static void USDtoGBP(decimal currency, out decimal converted)
        {
            double temp = Convert.ToDouble(currency) * 0.72523;
            converted = Convert.ToDecimal(temp);
            EM.Monitor(currency);
        }
        public static void USDtoCAN(decimal currency, out decimal converted)
        {
            double temp = Convert.ToDouble(currency) * 1.25427;
            converted = Convert.ToDecimal(temp);
            EM.Monitor(currency);
        }
        public static void USDtoEUR(decimal currency, out decimal converted)
        {
            double temp = Convert.ToDouble(currency) * 0.83572;
            converted = Convert.ToDecimal(temp);
            EM.Monitor(currency);
        }
        public static void GBPtoUSD(decimal currency, out decimal converted)
        {
            double temp = Convert.ToDouble(currency) * 1.37887;
            converted = Convert.ToDecimal(temp);
            EM.Monitor(converted);
        }
        public static void GBPtoCAN(decimal currency, out decimal converted)
        {
            double temp = Convert.ToDouble(currency) * 1.72947;
            converted = Convert.ToDecimal(temp);
            decimal monitornum = Convert.ToDecimal((Convert.ToDouble(converted) * 0.79728));
            EM.Monitor(monitornum);
        }
        public static void GBPtoEUR(decimal currency, out decimal converted)
        {
            double temp = Convert.ToDouble(currency) * 1.15195;
            converted = Convert.ToDecimal(temp);
            decimal monitornum = Convert.ToDecimal((Convert.ToDouble(converted) * 1.19648));
            EM.Monitor(monitornum);
        }
        public static void CANtoUSD(decimal currency, out decimal converted)
        {
            double temp = Convert.ToDouble(currency) * 0.79728;
            converted = Convert.ToDecimal(temp);
            EM.Monitor(converted);
        }
        public static void CANtoGBP(decimal currency, out decimal converted)
        {
            double temp = Convert.ToDouble(currency) * 0.57848;
            converted = Convert.ToDecimal(temp);
            decimal monitornum = Convert.ToDecimal((Convert.ToDouble(converted) * 1.37887));
            EM.Monitor(monitornum);
        }
        public static void CANtoEUR(decimal currency, out decimal converted)
        {
            double temp = Convert.ToDouble(currency) * 0.66645;
            converted = Convert.ToDecimal(temp);
            decimal monitornum = Convert.ToDecimal((Convert.ToDouble(converted) * 1.19648));
            EM.Monitor(monitornum);
        }
        public static void EURtoUSD(decimal currency, out decimal converted)
        {
            double temp = Convert.ToDouble(currency) * 1.19648;
            converted = Convert.ToDecimal(temp);
            EM.Monitor(converted);
        }
        public static void EURtoGBP(decimal currency, out decimal converted)
        {
            double temp = Convert.ToDouble(currency) * 0.86826;
            converted = Convert.ToDecimal(temp);
            decimal monitornum = Convert.ToDecimal(Convert.ToDouble(converted) * 1.37887);
            EM.Monitor(monitornum);
        }
        public static void EURtoCAN(decimal currency, out decimal converted)
        {
            double temp = Convert.ToDouble(currency) * 1.50040;
            converted = Convert.ToDecimal(temp);
            decimal monitornum = Convert.ToDecimal((Convert.ToDouble(converted) * 0.79728));
            EM.Monitor(monitornum);
        }
        public static void GatherData(out decimal TotalMNY, out int Conv)
        {
            TotalMNY = EM.TotalMoney();
            Conv = EM.ConvCounter();
        }
    }
}
