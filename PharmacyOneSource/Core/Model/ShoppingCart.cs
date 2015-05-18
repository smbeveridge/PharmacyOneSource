using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class ShoppingCart : IShoppingCart
    {
        public List<Good> Goods { get; set; }
        public event CompleteOrderDelegate OrderCompleted;

        public ShoppingCart()
        {
            this.Goods = new List<Good>();
        }
        public decimal SubTotal
        {
            get
            {
                return this.Goods.Select(x => x.Price).Sum();
            }
        }
        public decimal SalesTaxes
        {
            get
            {
                return this.Goods.Select(x => x.PriceWithTax).Sum() - this.SubTotal;
            }
        }
        public decimal Total
        {
            get
            {
                return this.Goods.Select(x => x.PriceWithTax).Sum();
            }
        }

        public void CompleteOrder()
        {
            if (OrderCompleted != null)
            {
                OrderCompleted(this, new EventArgs());
            }
        }
       
    }
}
