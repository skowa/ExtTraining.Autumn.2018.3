using System;

namespace No2.Solution.Listeners
{
    public class Broker
    {
        public string Name { get; set; }

        public Broker(string name)
        {
            this.Name = name;
        }

        public void Register(Stock stock)
        {
            if (stock == null)
            {
                throw new ArgumentNullException($"{nameof(stock)} is null");
            }

            stock.CurrencyChanged += Update;
        }

        public void UnRegister(Stock stock)
        {
            if (stock == null)
            {
                throw new ArgumentNullException($"{nameof(stock)} is null");
            }

            stock.CurrencyChanged -= Update;
        }

        private void Update(object sender, StockInfoEventArgs eventArgs)
        {
            Console.WriteLine(
                eventArgs.USD > 30
                    ? $"Broker {this.Name} sells dollars; Dollar rate: {eventArgs.USD}"
                    : $"Broker {this.Name} buys dollars; Dollar rate: {eventArgs.USD}");
        }
    }
}