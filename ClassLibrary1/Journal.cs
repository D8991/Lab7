using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBookShop
{
  public class Journal : Good
    {
        public DateTime DataOfPublic { get; set; }


        public Journal(Sale Good_Sale, string Book_Title, double Price, DateTime DataOfPublic) : base(Good_Sale, Book_Title, Price)
        {
            this.DataOfPublic = DataOfPublic;

        }
        public override string gd()
        {

            return "Название товара: " + Good_Sale + ";" + "Заголовок: " + Book_Title + ";" + "Цена: " + Price + ";" + "Дата издания: " + DataOfPublic;

        }
    }
}
