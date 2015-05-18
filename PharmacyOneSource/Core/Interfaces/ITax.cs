using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Interfaces
{
    public interface ITax
    {
        decimal BaseTaxRate { get; set; }
        decimal ImportTaxRate { get; set; }
        decimal BaseTaxValue { get;  }
        decimal ImportTaxValue { get;  }
        decimal Price { get; set; }
    }
}
