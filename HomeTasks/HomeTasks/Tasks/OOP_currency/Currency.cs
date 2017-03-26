using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTasks
{
    //Notes to OOP hometask 1:
    //- what is connection between double and dollars and cents? 
    //- a.i: what does it mean "pokazujut"?
    //

    public class Currency
    {
        public Currency()
        {
            _dollars = 0;
            _cents = 0;
            _double = 0;
        }

        public Currency(int dollars, int cents)
        {
            _dollars = dollars;
            _cents = cents;
        }

        public Currency(int @double)
        {
            _double = @double;
        }

        private int _dollars;
        private int _cents;
        private double _double;

        public int Dollars 
        {
            get { return _dollars; }
        }

        public int Cents
        {
            get { return _cents; }
        }

        public double ToDouble()
        {
            return _double;
        }

        public Currency Add(Currency currency)
        {
            return new Currency(currency.Dollars + this.Dollars, currency.Cents + this.Cents);
        }

        public Currency Multiply(int multiplier)
        {
            return new Currency(this.Dollars*multiplier, this.Cents*multiplier);
        }

        public override string ToString()
        {
            return (String.Format("{0}.{1}", Dollars, Cents));
        }

    }
}
