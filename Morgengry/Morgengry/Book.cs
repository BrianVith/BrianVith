using System;
using System.Collections.Generic;
using System.Text;

namespace Morgengry
{
    public class Book : Merchandise
    {

        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Book(string itemId, string title, double price)
        {
            base.ItemId = itemId;
            this.title = title;
            this.price = price;
        }

        public Book(string itemid, string title) : 
            this (itemid, title, 0)
        {
        }

        public Book(string itemId) : 
            this (itemId, "", 0)
        {
        }

        public override string ToString()
        {
            return $"ItemId: {base.ItemId}, Title: {title}, Price: {price}";
        }



    }
}
