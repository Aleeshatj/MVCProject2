using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2.Models;


namespace Project2.Controllers
{
    public class AdminHomeController : Controller
    {
        // GET: AdminHome
        Mvcproject1Entities dbobj = new Mvcproject1Entities();
        public ActionResult Home()
        {
            return View();
        }
    }
}