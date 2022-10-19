using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hafta_3

{
    internal class ShoppingCart
    {
        List<CartItem> cartitems = new List<CartItem>();


        public void Add(CartItem cartitem)
        {
            cartitems.Add(cartitem);
        }
        public void GetBalance()
        {
            int balance = 0;
            for (int i = 0; i < cartitems.Count; i++)
            {
                balance += cartitems[i].Quantity *cartitems[i].Product.Price;
            }
           
            Console.WriteLine("toplam: {0}",balance);
        }
        public void GetList()
        {
            foreach (var item in cartitems)
            {
                Console.WriteLine(item);
            }

        }
        public void Remove(CartItem cartitem)
        {
            cartitems.Remove(cartitem);
        }
    }
}
