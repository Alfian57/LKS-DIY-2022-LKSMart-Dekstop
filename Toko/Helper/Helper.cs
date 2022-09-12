using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toko.Helper
{
    class Helper
    {
        public static Customer Customer { get; set; } = new Customer();

        public static Dictionary<int, int> Cart = new Dictionary<int, int>();

        public static void addCart(int id, int qty)
        {
            LKSMartDataContext db = new LKSMartDataContext();
            var product = (from p in db.Products
                           where p.id == id
                           select p).SingleOrDefault();

            foreach (var item in Cart)
            {
                if (item.Key == id)
                {
                    Cart[item.Key] += qty;

                    if (Cart[item.Key] > product.stock)
                    {
                        Cart[item.Key] = product.stock;
                    }

                    return;
                }
            }
            Cart.Add(id, qty);
        }

        public static void deleteCartAt(int key)
        {
            Cart.Remove(key);
        }

        public static void editQtyCartAt(int id, int qty)
        {
            Cart[id] = qty;
        }
    }
}
