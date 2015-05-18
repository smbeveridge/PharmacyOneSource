using Core;
using Core.Interfaces;
using Core.Model;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PharmacyOneSource
{
    class Program
    {
        private readonly IShoppingCart shoppingcart;
        private ShoppingCartService cartservice;

        public Program(IShoppingCart icart)
        {
            shoppingcart = icart;
            cartservice = new ShoppingCartService(shoppingcart);
        }
        public Program() 
            : this(new ShoppingCart())
        {
        }



        static void Main(string[] args)
        {
            Program program = new Program();
            program.cartservice.OrderCompleted += new CompleteOrderDelegate(PrintReceipt);

            Book book1 = new Book(false);
            book1.Name = "book";
            book1.Price = 12.49m;
            program.cartservice.Goods.Add(book1);
            MusicCD cd1 = new MusicCD(false);
            cd1.Name = "music CD";
            cd1.Price = 14.99m;
            program.cartservice.Goods.Add(cd1);
            Food chocolatebar1 = new Food(false);
            chocolatebar1.Name = "chocolate bar";
            chocolatebar1.Price = 0.85m;
            program.cartservice.Goods.Add(chocolatebar1);
            program.cartservice.CompleteOrder();
            program.cartservice.Goods.Clear();
            Console.WriteLine();

            Food boxchoc = new Food(true);
            boxchoc.Name = "imported box of chocolates";
            boxchoc.Price = 10.00m;
            program.cartservice.Goods.Add(boxchoc);
            Perfume perfume = new Perfume(true);
            perfume.Name = "imported bottle of perfume";
            perfume.Price = 47.50m;
            program.cartservice.Goods.Add(perfume);
            program.cartservice.CompleteOrder();
            program.cartservice.Goods.Clear();
            Console.WriteLine();

            Perfume perfume2 = new Perfume(true);
            perfume2.Name = "imported bottle of perfume";
            perfume2.Price = 27.99m;
            program.cartservice.Goods.Add(perfume2);
            Perfume perfume3 = new Perfume(false);
            perfume3.Name = "bottle of perfume";
            perfume3.Price = 18.99m;
            program.cartservice.Goods.Add(perfume3);
            MedicalProduct pills = new MedicalProduct(false);
            pills.Name = "headache pills";
            pills.Price = 9.75m;
            program.cartservice.Goods.Add(pills);
            Food boxchoc2 = new Food(true);
            boxchoc2.Name = "imported box of chocolates";
            boxchoc2.Price = 11.25m;
            program.cartservice.Goods.Add(boxchoc2);
            program.cartservice.CompleteOrder();
           
            Console.ReadLine();
        }

        private static Receipt PrintReceipt(object sender, EventArgs args)
        {
            return new Receipt((ShoppingCart)sender);
        }
    }
}


