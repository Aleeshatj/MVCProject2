using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2.Models;

namespace Project2.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Mvcproject1Entities dbobj = new Mvcproject1Entities();
        // GET: Login
        public ActionResult Login_Pageload()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Login_click(Login objcls)
        {
            if (ModelState.IsValid)
            {
                ObjectParameter op = new ObjectParameter("status", typeof(int));
                dbobj.sp_Login(objcls.Username, objcls.Password, op);//Get
                int val = Convert.ToInt32(op.Value);
                if (val == 1)
                {
                    Session["uname"] = objcls.Username;
                    return RedirectToAction("Home");
                }
                else
                {
                    ModelState.Clear();
                    //objcls.Msg = "Invalid Login";
                    return View("Login_Pageload", objcls);
                }
            }
            return View("Login_Pageload", objcls);
        }
    }
}