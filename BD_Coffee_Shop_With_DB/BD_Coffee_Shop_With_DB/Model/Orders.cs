using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Coffee_Shop_With_DB.Model
{
    public class Orders
    {
        public int OrdersId { get; set; }
        public int CustomersId { get; set; }
        public int ItemsId { get; set; }
        public string Customer { set; get; }
        public string Item { set; get; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
    }
}
