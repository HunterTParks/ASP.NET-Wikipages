using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wikipages.Models;

namespace Wikipages.Controllers
{
    public class BusinessController : Controller
    {
        private BusinessContext db = new BusinessContext();
        public IActionResult Index()
        {
            return View(db.Businesses.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisBusiness = db.Businesses.FirstOrDefault(business => business.Id == id);
            return View(thisBusiness);
        }
    }
}
