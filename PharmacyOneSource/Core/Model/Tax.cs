using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Tax : ITax
    {
        private decimal price;
        private decimal basetaxrate;
        private decimal basetaxvalue;
        private decimal importtaxrate;
        private decimal importtaxvalue;
        public Tax()
        {
          
        }
        public decimal BaseTaxValue
        {
            get
            {
                return basetaxvalue = RoundSalesTax(((basetaxrate * price) / 100));
            }
        }
        public decimal ImportTaxValue
        {
            get
            {
                return importtaxvalue = RoundSalesTax(((importtaxrate * price) / 100));
            }
        }
        public decimal ImportTaxRate
        {
            get
            {
                return importtaxrate;
            }
            set
            {
                importtaxrate = value;
            }
        }
        public decimal BaseTaxRate
        {
            get
            {
                return basetaxrate;
            }
            set
            {
                basetaxrate = value;
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
       
        private decimal RoundSalesTax(decimal value)
        {
            return Math.Ceiling(value * 20) / 20;
        }
    }
}
