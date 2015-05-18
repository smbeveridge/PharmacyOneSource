using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Interfaces
{
    public interface IReceipt
    {
         IShoppingCart ShoppingCart { get; }
         void Create();
    }
}
