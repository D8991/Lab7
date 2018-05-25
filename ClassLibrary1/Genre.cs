using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBookShop
{
     public class Genre : Good, IGenre
    {
        public string Book_Author { get; set; }
        public string Book_Publisher { get; set; }
        public Good Book_Genre { get; set; }

        public Genre(Sale Good_Sale, string Book_Title, double Price, string Book_Author, string Book_Publisher, Sale Book_Genre) : base(Good_Sale, Book_Title, Price)
        {
            this.Book_Author = Book_Author;
            this.Book_Publisher = Book_Publisher;

        }
        public override string gd()
        {
            return "Наименоване товара: " + Good_Sale + "; " + "Заголовок: " + Book_Title + "; " + "Цена: " + Price + "; " + "Автор: " + Book_Author + "; " + "Издательство: " + Book_Publisher;
        }
    }
}
