using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public class MedicalProduct : Good
    {
        private decimal price;
        private string name;
        private decimal basictaxpercentrate = 0;
        private bool isimport;

        public MedicalProduct(bool import) : base(import, new Tax())
        {
            isimport = import;
        }

        public override decimal Price
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

        public override bool IsImport
        {
            get { return isimport; }
        }

        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public override decimal BasicTaxPercentRate
        {
            get
            {
                return basictaxpercentrate;
            }
        }

    }
}
