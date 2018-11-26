using System;

namespace No2.Solution.Listeners
{
    public class Bank
    {
        public string Name { get; set; }

        public Bank(string name)
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
                eventArgs.Euro > 40
                    ? $"Bank {this.Name} sells euros; Euro rate:{eventArgs.Euro}"
                    : $"Bank {this.Name} is buying euros; Euro rate: {eventArgs.Euro}");
        }
    }
}