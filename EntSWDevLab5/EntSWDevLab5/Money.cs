using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntSWDevLab5
{
    public struct Money
    {
        public enum CurrencyTypes {
            Euro, Dollar, Yen
        }

        public Money(CurrencyTypes currency, double amount) : this()
        {
            this.Currency = Currency;
            this.Amount = amount;
        }

        public double Convert(CurrencyTypes tcurrency)
        {
            if (tcurrency == Currency)
            {
                return Amount;
            }
            if (tcurrency == CurrencyTypes.Dollar)
                return Amount*EuroToDollarRate;
            else if (tcurrency == CurrencyTypes.Euro)
                return Amount*DollarToEuroRate;
            else if (Currency == CurrencyTypes.Dollar)
                return (Amount*DollarToEuroRate)*EuroToYenRate;

                return Amount*EuroToYenRate;
        }

        public CurrencyTypes Currency { get; set; }
        public double Amount { get; set; }

        private const double EuroToDollarRate = 1.12;
        private const double DollarToEuroRate = 0.89;
        private const double EuroToYenRate = 134.57;

        public static Money operator +(Money lhs, Money rhs)
        {
            return lhs.Currency == rhs.Currency ? new Money(lhs.Currency, lhs.Amount + rhs.Amount) : new Money(lhs.Currency, rhs.Convert(lhs.Currency) + lhs.Amount);
        }
    }
}
