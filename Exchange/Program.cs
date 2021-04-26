using System;

namespace Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Converted;
            string YN;
            Console.WriteLine("Welcome to the Currency Exchanger");

            do
            {
                Console.WriteLine("Select which currency your converting to(type the number of the corresponding convertion):");
                Console.WriteLine("1.USD to GBP\t2.USD to CAN\t3.USD to EUR");
                Console.WriteLine("4.GBP to USD\t5.GBP to CAN\t6.GBP to EUR");
                Console.WriteLine("7.CAN to USD\t8.CAN to GBP\t9.CAN to EUR");
                Console.WriteLine("10.EUR to USD\t11.EUR to GBP\t12.EUR to CAN");
                string input = Console.ReadLine();
                Console.WriteLine("Enter the amount you wish to convert:");
                decimal Currency = Convert.ToDecimal(Console.ReadLine());
                if (input == "1")
                {
                    Exchanger.USDtoGBP(Currency, out Converted);
                    Console.WriteLine("The conversion of " + Currency + " from USD to GBP is " + string.Format("{0:0.00}", Converted));
                }
                else if (input == "2")
                {
                    Exchanger.USDtoCAN(Currency, out Converted);
                    Console.WriteLine("The conversion of " + Currency + " from USD to CAN is " + string.Format("{0:0.00}", Converted));
                }
                else if (input == "3")
                {
                    Exchanger.USDtoEUR(Currency, out Converted);
                    Console.WriteLine("The conversion of " + Currency + " from USD to EUR is " + string.Format("{0:0.00}", Converted));
                }
                else if (input == "4")
                {
                    Exchanger.GBPtoUSD(Currency, out Converted);
                    Console.WriteLine("The conversion of " + Currency + " from GBP to USD is " + string.Format("{0:0.00}", Converted));
                }
                else if (input == "5")
                {
                    Exchanger.GBPtoCAN(Currency, out Converted);
                    Console.WriteLine("The conversion of " + Currency + " from USD to GBP is " + string.Format("{0:0.00}", Converted));
                }
                else if (input == "6")
                {
                    Exchanger.GBPtoEUR(Currency, out Converted);
                    Console.WriteLine("The conversion of " + Currency + " from GBP to EUR is " + string.Format("{0:0.00}", Converted));
                }
                else if (input == "7")
                {
                    Exchanger.CANtoUSD(Currency, out Converted);
                    Console.WriteLine("The conversion of " + Currency + " from CAN to USD is " + string.Format("{0:0.00}", Converted));
                }
                else if (input == "8")
                {
                    Exchanger.CANtoGBP(Currency, out Converted);
                    Console.WriteLine("The conversion of " + Currency + " from CAN to GBP is " + string.Format("{0:0.00}", Converted));
                }
                else if (input == "9")
                {
                    Exchanger.CANtoEUR(Currency, out Converted);
                    Console.WriteLine("The conversion of " + Currency + " from CAN to EUR is " + string.Format("{0:0.00}", Converted));
                }
                else if (input == "10")
                {
                    Exchanger.EURtoUSD(Currency, out Converted);
                    Console.WriteLine("The conversion of " + Currency + " from EUR to USD is " + string.Format("{0:0.00}", Converted));
                }
                else if (input == "11")
                {
                    Exchanger.EURtoGBP(Currency, out Converted);
                    Console.WriteLine("The conversion of " + Currency + " from EUR to GBP is " + string.Format("{0:0.00}", Converted));
                }
                else if (input == "12")
                {
                    Exchanger.EURtoCAN(Currency, out Converted);
                    Console.WriteLine("The conversion of " + Currency + " from EUR to CAN is " + string.Format("{0:0.00}", Converted));
                }
                Console.WriteLine("Do you wish to do another conversion? (Y/N)");
                YN = Console.ReadLine();
                Console.Clear();
            } while (YN.ToLower() == "y");
            Exchanger.GatherData(out decimal TotalMoney, out int Conversions);
            Console.WriteLine("Total conversions done: " + Convert.ToString(Conversions));
            Console.WriteLine("Total amount of all currency converted in USD: " + string.Format("{0:0.00}", TotalMoney));
        }
    
    }
}
