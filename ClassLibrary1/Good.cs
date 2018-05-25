using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBookShop
{
  public abstract class Good
    {
        public Sale Good_Sale { get; set; }
        public string Book_Title { get; set; }

        public double Price { get; set; }

        public Good(Sale Good_Sale, string Book_Title, double Price)
        {
            this.Good_Sale = Good_Sale;
            this.Book_Title = Book_Title;
            this.Price = Price;
        }
        public abstract string gd();

    }
}

