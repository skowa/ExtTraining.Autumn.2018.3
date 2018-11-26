using System;

namespace No2.Solution
{
    public class Stock
    {
        public event EventHandler<StockInfoEventArgs> CurrencyChanged = delegate { };

        public void Market()
        {
            Random rnd = new Random();
            StockInfoEventArgs stocksInfo = new StockInfoEventArgs {USD = rnd.Next(20, 40), Euro = rnd.Next(30, 50)};

            OnCurrencyChanged(stocksInfo);
        }

        protected virtual void OnCurrencyChanged(StockInfoEventArgs e)
        {
            if (e == null)
            {
                throw new ArgumentNullException(nameof(e));
            }

            CurrencyChanged(this, e);
        }
    }

    public class StockInfoEventArgs : EventArgs
    {
        public int USD { get; set; }
        public int Euro { get; set; }
    }
}