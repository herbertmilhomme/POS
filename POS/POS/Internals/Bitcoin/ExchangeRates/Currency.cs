﻿using System;
using System.Linq;

namespace Info.Blockchain.API.ExchangeRates
{
    /// <summary>
    /// This class is used in the response of the `GetTicker` method in the `ExchangeRates` class.
    /// </summary>
    public class Currency
    {
        public Currency(double buy, double sell, double last, double price15m, string symbol)
        {
            this.Buy = buy;
            this.Sell = sell;
            this.Last = last;
            this.Price15m = price15m;
            this.Symbol = symbol;
        }

        /// <summary>
        /// Current buy price
        /// </summary>
        public double Buy { get; private set; }

        /// <summary>
        /// Current sell price
        /// </summary>
        public double Sell { get; private set; }

        /// <summary>
        /// Most recent market price
        /// </summary>
        public double Last { get; private set; }

        /// <summary>
        /// 15 minutes delayed market price
        /// </summary>
        public double Price15m { get; private set; }

        /// <summary>
        /// Currency symbol
        /// </summary>
        public string Symbol { get; private set; }
    }
}