using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using OnlineShopping.DAL.Domain;

namespace OnlineShopping.DAL
{
    public class ShoppingModel : DbContext
    {
        public ShoppingModel()
            : base("name=OnlineShoppingConnection")
        {
        }


        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }

        //public System.Data.Entity.DbSet<OnlineShopping.Models.ItemModel> ItemModels { get; set; }
    }
}
