using Core.Interfaces;
using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Services
{
    public class ShoppingCartService : IShoppingCart
    {
        private IShoppingCart ishoppingcart;
        
        public event CompleteOrderDelegate OrderCompleted;

        public ShoppingCartService(IShoppingCart cart)
        {
            ishoppingcart = cart;
        }

        public List<Good> Goods
        {
            get
            {
                return ishoppingcart.Goods;
            }
        }
        public decimal SubTotal
        {
            get
            {
                return ishoppingcart.SubTotal;
            }
        }
        public decimal SalesTaxes
        {
            get
            {
                return ishoppingcart.SalesTaxes;
            }
        }
        public decimal Total
        {
            get
            {
                return ishoppingcart.Total;
            }
        }
        public void CompleteOrder()
        {
            if (OrderCompleted != null)
            {
                OrderCompleted(ishoppingcart, new EventArgs());
            }
        }
    }
}
