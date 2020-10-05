using System;

namespace ExchangeRateApiCall
{
    class Program
    {
        static void Main(string[] args)
        {
            Container c = new Container();
            c.getExchangeRates();
            Console.ReadLine();
        }
    }
}
