using OnlineShopping.DAL.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.BLL.Services.CartServices
{
    public interface ICartServices
    {
        #region CartServices
        Cart GetCart(int id);

        List<Cart> GetItem(Expression<Func<Cart, bool>> Predicate);

        List<Cart> GetCart();

        void InsertCart(Cart _Cart);

        void UpdateCart(Cart _Cart);

        void DeleteCart(int id);
        #endregion
    }
}
