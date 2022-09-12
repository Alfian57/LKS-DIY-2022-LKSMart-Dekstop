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
