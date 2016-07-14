using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.Controllers;

namespace WebDeveloper.Areas.Internal.Controllers
{
    public class InternalController : BaseAccountController
    {
        // GET: Internal/Internal
        public ActionResult Index()
        {
            return View(UserManager.Users.ToList());
        }



    }
}