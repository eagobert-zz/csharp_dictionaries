using System;
using System.Linq;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("");

            //Create a dictionary w/ ticker symbols and stock names
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("EA", "Electronic Arts");
            stocks.Add("AAPL","Apple Inc");
            stocks.Add("AMZN", "Amazon");
            stocks.Add("GOOGL", "Alphabet Inc");

            // var dict = from stock in stocks
            // select stock;
            // Console.WriteLine("");

            //Can use bracket notation to find key values in dictionary
            string GM = stocks["GM"];
            string EA = stocks["EA"];

            Console.WriteLine(GM);
            Console.WriteLine(EA);
            Console.WriteLine("");

            //Create a list of ValueTuples that represent stock purchases
            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GE", shares: 150, price: 23.21));
            purchases.Add((ticker: "GE", shares: 32, price: 17.87));
            purchases.Add((ticker: "GE", shares: 80, price: 19.02));
            purchases.Add((ticker: "GOOGL", shares: 50, price: 1107.53));
            purchases.Add((ticker: "EA", shares: 100, price: 112.32));
            purchases.Add((ticker: "AMZN", shares: 45, price: 1263.53));

            /* Define a new Dictionary to hold the aggregated purchase information. */
            Dictionary<string, double> StockPurchases = new Dictionary<string, double>();

            /* - The key should be a string that is the full company name.
            - The value will be the valuation of each stock (price*amount) */
         
            // Iterate over the purchases and update the valuation for each stock
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                // Does the company name key already exist in the report dictionary?
                if (stocks.Keys == purchases.ticker)
                // If it does, update the total valuation

                // If not, add the new key and set its value
            }


            

        }
    }
}
