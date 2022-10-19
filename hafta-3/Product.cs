using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_3
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int   Price { get; set; }


        public Product(int productid,string productname,int price)
        {
            this.ProductId = productid;
            this.ProductName = productname;
            this.Price = price;
        }

        public Product()
        {
        }
    }


}
