using Evaluation_of_the_Film1.Data.Models;
using Evaluation_of_the_Film1.interaces;
using Evaluation_of_the_Film1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Evaluation_of_the_Film1.Controllers
{
    public class ShopSocksController:Controller
    {
        private readonly IAllSocks _socksrep;
        private readonly ShopSocks _shopsocks;

        public ShopSocksController(IAllSocks socksrep,ShopSocks shopsocks)
        {
            _socksrep = socksrep;
            _shopsocks = shopsocks;
        }

        public ViewResult Index()
        {
            var items = _shopsocks.Getshopitems();
            _shopsocks.listsocksitem = items;

            var obj = new ShopSocksViewModel
            {
                shopsocks = _shopsocks
            };
            return View(obj);
        }

        public RedirectToActionResult addtosocks(int id)
        {
            var item = _socksrep.AllSocks.FirstOrDefault(i=>i.Id==id);
            if(item != null)
            {
                _shopsocks.AddtoSocks(item);
            }
            return RedirectToAction("Index");
        }
    }
}
