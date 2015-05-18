using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Interfaces
{
    public interface IShoppingCart
    {
        List<Good> Goods { get; }
        decimal SubTotal { get; }
        decimal SalesTaxes { get; }
        decimal Total { get; }
        event CompleteOrderDelegate OrderCompleted;
    }
}
