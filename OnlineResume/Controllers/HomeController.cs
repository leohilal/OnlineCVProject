//-------------------------------------------------------------
// Name : HomeController.cs
// Purpose : C# code for Home controller
// Developer : Hilal Paray
// BA : Hilal Paray
// Dated : 2015/10/06
// Updated :
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using OnlineResume.Models;

namespace OnlineResume.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Main profile page and first landing page of online resume
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}