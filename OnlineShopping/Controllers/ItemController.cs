using OnlineShopping.BLL.Services.ItemServices;
using OnlineShopping.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShopping.Controllers
{
    [RoutePrefix("item")]
    public class ItemController : Controller
    {
        private readonly IItemServices ItemService;
        public ItemController(IItemServices ItemService)
        {
            this.ItemService = ItemService;
        }

        [Route("GetAll")]
        public ActionResult Index()
        {
            var Items = ItemService.GetItem().Select(x => new ItemModel
            {
                ID = x.ID,
                Name = x.Name,
                Description = x.Description,
                
            }).ToList();

            return View(Items);
        }
    }
}