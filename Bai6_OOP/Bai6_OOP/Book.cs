using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6_OOP
{
    public class Book : ICloneable
    {
        private string id;
        private string title;
        private string authorname;
        private DateTime publisheddate;
        private string publisher;
        private int numofpages;
        private uint price;
        private byte quantity;
        public string Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public byte Quantity { get => quantity; set => quantity = value; }
        public Book(string id, string title, string authorname, DateTime publisheddate, string publisher, int numofpages, uint price, byte quantity)
        {
            this.id = id;
            this.title = title;
            this.authorname = authorname;
            this.publisheddate = publisheddate;
            this.publisher = publisher;
            this.numofpages = numofpages;
            this.price = price;
            this.quantity = quantity;
        }
        public object Clone()
        {
            return new Book(Id, Title, authorname, publisheddate, publisher, numofpages, price, Quantity);
        }
        public bool find(string keyword)
        {
            return Title.IndexOf(keyword) >= 0 || authorname.IndexOf(keyword) >= 0;
        }
        public void update(string title, string authorname, DateTime publisheddate, string publisher, int numofpages, uint price, byte quantity)
        {
            this.title = title;
            this.authorname = authorname;
            this.publisheddate = publisheddate;
            this.publisher = publisher;
            this.numofpages = numofpages;
            this.price = price;
            this.quantity = quantity;
        }
        public override string ToString()
        {
            return "Book("+ Id +", "+ Title +", "+ authorname +", "+ publisheddate.ToShortDateString() +", "+ publisher +", "+ numofpages +", "+ price +", "+ Quantity +")";
        }
    }
}
