using Evaluation_of_the_Film1.Data.Models;
using Evaluation_of_the_Film1.interaces;
using Evaluation_of_the_Film1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Evaluation_of_the_Film1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllSocks _socksrep;
        

        public HomeController(IAllSocks socksrep)
        {
            _socksrep = socksrep;
            
        }
        public ViewResult index()
        {
            return View();
        }

    }
}