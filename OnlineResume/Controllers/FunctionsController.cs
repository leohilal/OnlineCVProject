//-------------------------------------------------------------
    // Name : FunctionController.cs
    // Purpose : C# code for Function controller
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

using System.Net;
using System.Net.Mail;

using OnlineResume.Models;

namespace OnlineResume.Controllers
{
    public class FunctionsController : Controller
    {

        /// <summary>
        /// Display my resume
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult MyResume()
        {
            return View();
        }

        /// <summary>
        /// Display Projects
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult MyProjects()
        {
            return View();
        }

        /// <summary>
        /// For displaying social links on the page
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult SocialLinks()
        {
            return View();
        }

        /// <summary>
        /// Fill contact form
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ContactMe()
        {
            return View();
        }

        /// <summary>
        /// Sending contact form to me by email
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ContactMe(ProfileModule profilemodule)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("leohilal@hotmail.com"));  // your email address
                message.From = new MailAddress(profilemodule.ContactEmail);  // sender email address
                message.Subject = "Email from my online Resume";
                message.Body = string.Format(body, profilemodule.ContactName, profilemodule.ContactEmail, profilemodule.ContactComment);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "leohilal@hotmail.com",  // email id
                        Password = "ilovemyhome"  // password
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Send(message);
                    //return RedirectToAction("Sent");
                    ViewBag.Message = OnlineResumeRes.Emailhassend; //"Your message has been sent";
                    return (ActionResult)this.RedirectToAction("Index", "Home");
                }
            }

            return View(profilemodule);
        }
    }
}