using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Receipt : IReceipt
    {
        private IShoppingCart shoppingcart;
        public Receipt(IShoppingCart cart)
        {
            shoppingcart = cart;
            this.Create();
        }

        public IShoppingCart ShoppingCart
        {
            get
            {
                return shoppingcart;
            }
        }

        public void Create()
        {
            foreach (Good good in shoppingcart.Goods)
            {
                Console.WriteLine("1 " + good.Name + ": " + good.PriceWithTax);
            }
            Console.WriteLine("Sales Taxes: " + shoppingcart.SalesTaxes);
            Console.WriteLine("Total: " + shoppingcart.Total);
        }

    }
}
