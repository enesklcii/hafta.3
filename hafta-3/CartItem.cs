using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_3
{
    public class CartItem
    {
       
        public int CartId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public CartItem(int cartid, Product product, int quantity)
        {
            this.Product = product;
            this.CartId = cartid;
            this.Quantity = quantity;
        }

       

        public override string ToString()
        {
            return $"{Product.Price} {Product.ProductId}{Product.ProductName}";
        }
        public CartItem()
        {

        }
    }
}
