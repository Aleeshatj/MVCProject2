using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2.Models;

namespace Project2.Controllers
{
    public class AllBooksController : Controller
    {
        Mvcproject1Entities dbobj = new Mvcproject1Entities();
        // GET: AllBooks
        public ActionResult DisplayAll_Load(Book ob)
        {
            return View(dbobj.Books.ToList());
        }
    }
}