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
    //- I expected to create dollars and cents as private. However in Add method I cannot create new object and assignt them values. So I had to set them as public 
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

        public int _dollars;
        public int _cents;
        public double _double;

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
            Currency newCurrency = new Currency();
            newCurrency._dollars = this._dollars + currency._dollars;
            newCurrency._cents = this._cents + currency._cents;
            newCurrency._double = this._double+ currency._double;
            return newCurrency;
        }

        public Currency Multiply(int multiplier)
        {
            Currency newCurrency = new Currency();
            newCurrency._dollars = this._dollars * multiplier;
            newCurrency._cents = this._cents * multiplier;
            newCurrency._double = this._double * multiplier;
            return newCurrency;
        }

        public override string ToString()
        {
            return (String.Format("{0}.{1}", Dollars, Cents));
        }

    }
}
