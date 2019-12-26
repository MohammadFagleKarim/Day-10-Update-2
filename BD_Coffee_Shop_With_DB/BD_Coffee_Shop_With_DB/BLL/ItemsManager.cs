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
    public class ItemsManager
    {
        ItemsRepository _ItemsRepository = new ItemsRepository();

        public bool ItemsAdd(Items items)
        {
            return _ItemsRepository.ItemsAdd(items);
        }

        public bool IsItemNameExist(Items items)
        {
            return _ItemsRepository.IsItemNameExist(items);
        }

        public bool ItemsDelete(Items items)
        {
            return _ItemsRepository.ItemsDelete(items);
        }

        public bool ItemsUpdate(Items items)
        {
            return _ItemsRepository.ItemsUpdate(items);
        }

        public List<Items> Display()
        {
            return _ItemsRepository.Display();
        }

        public DataTable Search(Items items)
        {
            return _ItemsRepository.Search(items);
        }
    }
}
