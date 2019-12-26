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
    public class CustomersManager
    {
        CustomersRepository _CustomersRepository = new CustomersRepository();

        public bool CustomersAdd(Customers customers)
        {
            return _CustomersRepository.CustomersAdd(customers);
        }

        public bool IsCustomerNameExist(Customers customers)
        {
            return _CustomersRepository.IsCustomerNameExist(customers);
        }

        public bool CustomersDelete(Customers customers)
        {
            return _CustomersRepository.CustomersDelete(customers);
        }

        public bool CustomersUpdate(Customers customers)
        {
            return _CustomersRepository.CustomersUpdate(customers);
        }

        public List<Customers> Display()
        {
            return _CustomersRepository.Display();
        }

        public DataTable Search(Customers customers)
        {
            return _CustomersRepository.Search(customers);
        }
    }
}
