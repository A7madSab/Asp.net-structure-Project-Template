using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DaleelElkheir.DAL.Repository;
using OnlineShopping.DAL.Domain;

namespace OnlineShopping.BLL.Services.ItemServices
{
    public class ItemServices : IItemServices
    {
        private readonly IUnitOfWork unitOfWork;

        public ItemServices(IUnitOfWork _unitOfWork)
        {
            this.unitOfWork = _unitOfWork;
        }

        public void DeleteItem(int id)
        {
            unitOfWork.Repository<Item>().Delete(id);
            unitOfWork.Save();
        }

        public Item GetItem(int id)
        {
            return unitOfWork.Repository<Item>().GetById(id);
        }

        public List<Item> GetItem(Expression<Func<Item, bool>> Predicate)
        {
            return unitOfWork.Repository<Item>().Get(Predicate);
        }

        public List<Item> GetItem()
        {
            return unitOfWork.Repository<Item>().GetAll();
        }

        public void InsertItem(Item _Item)
        {
            unitOfWork.Repository<Item>().Insert(_Item);
            unitOfWork.Save();
        }

        public void UpdateItem(Item _Item)
        {
            unitOfWork.Repository<Item>().Update(_Item);
            unitOfWork.Save();
        }
    }
}
