using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BD_Coffee_Shop_With_DB.Model;
using BD_Coffee_Shop_With_DB.Repository;

namespace BD_Coffee_Shop_With_DB.BLL
{
    public class OrdersManager
    {
        OrdersRepository _OrdersRepository = new OrdersRepository();

        public bool OrdersAdd(Orders orders)
        {
            return _OrdersRepository.OrdersAdd(orders);
        }

        //public bool IsCustomerNameExist(Orders orders)
        //{
        //    return _OrdersRepository.IsCustomerNameExist(orders);
        //}

        public DataTable Display()
        {
            return _OrdersRepository.Display();
        }

        public DataTable CustomerCombo()
        {
            return _OrdersRepository.CustomerCombo();
        }

        public DataTable ItemCombo()
        {
            return _OrdersRepository.ItemCombo();
        }
    }
}
