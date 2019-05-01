using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DaleelElkheir.DAL.Repository;
using OnlineShopping.DAL.Domain;

namespace OnlineShopping.BLL.Services.CartServices
{
    public class CartServices : ICartServices
    {
        private readonly IUnitOfWork unitOfWork;

        public CartServices(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
        }
        
        public void DeleteCart(int id)
        {
            unitOfWork.Repository<Cart>().Delete(id);
            unitOfWork.Save();
        }

        public Cart GetCart(int id)
        {
            return unitOfWork.Repository<Cart>().GetById(id);
        }

        public List<Cart> GetCart()
        {
            return unitOfWork.Repository<Cart>().GetAll();
        }

        public List<Cart> GetItem(Expression<Func<Cart, bool>> Predicate)
        {
            return unitOfWork.Repository<Cart>().Get(Predicate);
        }

        public void InsertCart(Cart _Cart)
        {
            unitOfWork.Repository<Cart>().Insert(_Cart);
            unitOfWork.Save();
        }

        public void UpdateCart(Cart _Cart)
        {
            unitOfWork.Repository<Cart>().Update(_Cart);
            unitOfWork.Save();
        }
    }
}
