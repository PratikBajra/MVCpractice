using System;
using MyMVCApplication.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class signinController : Controller
    {
        IList<signin> signinList = new List<signin>() {
                    new signin(){ URL="192.168.1.106", Database="John", LoginID = "asdad", Password = "qwerty" },
                    new signin(){ URL="192.168.1.107", Database="John", LoginID = "asdqwer", Password = "qwerty123" },
                };
        // GET: signin
        public ActionResult Index()
        {
            return View(signinList);
        }
    }
}