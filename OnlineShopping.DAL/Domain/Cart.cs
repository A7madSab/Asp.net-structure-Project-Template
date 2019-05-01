using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.DAL.Domain
{
    public class Cart
    {
        public int ID { get; set; }

        public int Key { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
