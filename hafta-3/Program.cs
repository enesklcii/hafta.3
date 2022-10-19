
using hafta_3;

Product product = new Product(1,"telefon",5220);
Product product1 = new Product(2,"monitör",3000);
CartItem cartitem = new CartItem(1, product, 200);
CartItem cartitem1 = new CartItem(1, product1, 300);

ShoppingCart shoppingCart = new ShoppingCart();
shoppingCart.Add(cartitem);
shoppingCart.Add(cartitem1);
shoppingCart.GetBalance();
shoppingCart.Remove(cartitem);
shoppingCart.GetList();