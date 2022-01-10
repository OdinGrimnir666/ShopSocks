using Evaluation_of_the_Film1.Data.interaces;
using Evaluation_of_the_Film1.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Evaluation_of_the_Film1.Controllers
{
    public class OrderController : Controller
    {

        private readonly IALlordercs alloders;
        private readonly ShopSocks shopsocks;

        public OrderController(IALlordercs allorders, ShopSocks shopsocks)
        {
            this.alloders = allorders;
            this.shopsocks = shopsocks;
        }

        
        public IActionResult Checkout()
        {
            return View();
        }
         [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopsocks.listsocksitem = shopsocks.Getshopitems();

            if(shopsocks.listsocksitem.Count==0)
            {
                ModelState.AddModelError("","у вас должны быть товары");
            }
            if(ModelState.IsValid)
            {
                alloders.createOder(order);
                return RedirectToAction("Complete");   
            }
            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ успешно обработан";
            return View();
        }
    }
}
