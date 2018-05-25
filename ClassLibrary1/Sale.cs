using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBookShop
{
   public class Sale
    {
        public string Sale_Name { get; set; }
        public Sale(string Good_Name)
        {
            this.Sale_Name = Good_Name;
        }
        public override string ToString()
        {
            return Sale_Name;
        }
    }
}
