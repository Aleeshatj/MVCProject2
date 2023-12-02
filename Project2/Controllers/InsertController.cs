using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2.Models;

namespace Project2.Controllers
{
    public class InsertController : Controller
    {
        Mvcproject1Entities dbobj = new Mvcproject1Entities();
        // GET: Insert
        public ActionResult insert_Pageload()
        {
            return View();
        }
        public ActionResult insert_click(Insert objcls, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                //Get
                dbobj.sp_Insert(objcls.Name, objcls.Phone, objcls.Email, objcls.Username, objcls.Password);
                objcls.Msg = "Successfully inserted";
                return View("insert_Pageload", objcls);
            }

            return View("insert_Pageload", objcls);
        }
    }
}