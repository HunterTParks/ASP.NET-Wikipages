using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wikipages.Models;

namespace Wikipages.Controllers
{
    public class GroupsController : Controller
    {
        private WikipagesContext db = new WikipagesContext();
        private BusinessContext bdb = new BusinessContext();

        public IActionResult Index()
        {
            return View(db.Groups.ToList());
        }

        //public IActionResult Businesses()
        //{
          //  return View(bdb.Businesses.ToList());
        //}

        public IActionResult Details(int id)
        {
            var thisGroup = db.Groups.FirstOrDefault(groups => groups.Id == id);
            return View(thisGroup);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Group group)
        {
            db.Groups.Add(group);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
