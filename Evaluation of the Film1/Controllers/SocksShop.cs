using Evaluation_of_the_Film1.interaces;
using Evaluation_of_the_Film1.Models;
using Evaluation_of_the_Film1.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Evaluation_of_the_Film1.Controllers
{
    public class SocksShopController : Controller
    {
        private readonly IAllSocks _allsocks; 

        private readonly ISocksfloor _socksfloor;

        private readonly ISocksCategory _socksCategory;

        public SocksShopController(IAllSocks iallsocks,ISocksfloor isocksfloor,ISocksCategory socksCategory)
        {
            _allsocks = iallsocks;
            _socksCategory = socksCategory;
            _socksfloor = isocksfloor;
        }

        [Route("SocksShop/list")]
        [Route("SocksShop/list/{category}")]
        public ViewResult list(string category)
        {
            
            string _category = category;

            IEnumerable<Socks>? socks = null;
            string sockscategor ="";
            
            if(string.IsNullOrEmpty(category))
            {
                socks = _allsocks.AllSocks.OrderBy(i => i.Id);
            }
            else
            {
                if(string.Equals("everyday", category,StringComparison.OrdinalIgnoreCase))
                {
                    socks = _allsocks.AllSocks.Where(i => i.SocksCategory.namecategory.Equals("everyday")).OrderBy(i => i.Id);
                    sockscategor = "Повседневные";
                }
                else if (string.Equals("sport", category, StringComparison.OrdinalIgnoreCase))
                {
                    socks = _allsocks.AllSocks.Where(i => i.SocksCategory.namecategory.Equals("sport")).OrderBy(i => i.Id);
                    sockscategor = "Спортивные";
                }
                
            }

            var socksobj = new SocksListView
            {
                getallsocks = socks,
                sockscategory = sockscategor
            };



            ViewBag.Title = "Cтраница с носками";
            return View(socksobj);
        }
    }
}
