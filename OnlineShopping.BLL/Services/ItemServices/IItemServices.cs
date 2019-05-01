using OnlineShopping.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.BLL.Services.ItemServices
{
    public interface IItemServices
    {
        #region ItemServices
        Item GetItem(int id);

        List<Item> GetItem(Expression<Func<Item, bool>> Predicate);

        List<Item> GetItem();

        void InsertItem(Item _Item);

        void UpdateItem(Item _Item);

        void DeleteItem(int id);
        #endregion
    }
}
