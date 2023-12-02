using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2.Models;

namespace Project2.Controllers
{
    public class InsertBookController : Controller
    {
        // GET: InsertBook
        Mvcproject1Entities dbobj = new Mvcproject1Entities();
        public ActionResult insert_Pageload()
        {
            return View();
        }
        
        public ActionResult insert_click(InsertBook objcls, HttpPostedFileBase file)
        {
            if(!ModelState.IsValid)
            {
                if (file.ContentLength > 0)
                {
                    string fname = Path.GetFileName(file.FileName);
                    var s = Server.MapPath("~/PHS");
                    string pa = Path.Combine(s, fname);
                    file.SaveAs(pa);

                    var fullpath = Path.Combine("~\\PHS", fname);
                    objcls.BImage = fullpath;//Set
                }
                //Get
                dbobj.sp_InsertBook(objcls.BName, objcls.BAuthor, objcls.BImage, objcls.BDescr, objcls.BPrice,objcls.BStatus);
                objcls.Msg = "Successfully inserted";
                //return View("insert_Pageload", objcls);
                return RedirectToAction("Home");
            }
            return View("insert_Pageload", objcls);
        }
    }
}