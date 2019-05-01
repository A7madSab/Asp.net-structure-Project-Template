using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineShopping.BLL.Services.CartServices;
using OnlineShopping.DAL.Domain;

namespace OnlineShopping.Controllers
{
    public class CartController : Controller
    {
        readonly ICartServices cartServices;

        public CartController (ICartServices _cartServices)
        {
            this.cartServices = _cartServices;
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}