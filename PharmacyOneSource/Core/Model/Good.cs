using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public abstract class Good
    {
        private decimal basictaxpercentrate = 10;
        private decimal importtaxpercentrate = 5;
        private bool isimport;
        private ITax tax;

        public Good(bool import, ITax t)
        {
            isimport = import;
            tax = t;
        }

        public abstract decimal Price
        {
            get;
            set;
        }

        public abstract string Name
        {
            get;
            set;
        }

        public virtual decimal BasicTaxPercentRate
        {
            get
            {
                return basictaxpercentrate;
            }
        }

        public virtual decimal ImportTaxPercentRate
        {
            get
            {
                return importtaxpercentrate;
            }
        }

        public abstract bool IsImport
        {
            get;        
        }

        public virtual decimal PriceWithTax
        {
            get
            {
                tax.BaseTaxRate = this.BasicTaxPercentRate;
                tax.Price = this.Price;
                if (this.IsImport)
                {
                    tax.ImportTaxRate = this.ImportTaxPercentRate;
                    return tax.BaseTaxValue + tax.ImportTaxValue + this.Price;
                }
                return tax.BaseTaxValue + this.Price;
            }
        }

        
        
    }
}
