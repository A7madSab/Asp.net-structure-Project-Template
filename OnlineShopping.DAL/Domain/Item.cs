using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.DAL.Domain
{
    [Table("Item")]
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public float Price1 { get; set; }
        public float Price2 { get; set; }
        public string Description { get; set; }
    }
}
