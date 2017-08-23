using PartyinviteMVC5WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyinviteMVC5WebApp.Controllers
{
    public class PartyController : Controller
    {
        #region Waste
        
        public ViewResult Index()
        {
            int hours = DateTime.Now.Hour;
            ViewBag.Greet = hours < 16 ? "Good Afternoon" + DateTime.Now : "Good Evevning" + DateTime.Now;
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];
            ViewBag.RouteDetails = string.Format("{0}::{1} --- {2}",controller,action,id);

            return View();
        } 
        #endregion

        public JsonResult List()
        {
            var result = Json(new {Name ="Phantom",Email = "Phantom@gmail.com", Mobile = "987654321"});
            return result;
        }

        public string Greeting()
        {
            return string.Format("from {0} controller to {1} action","Party","Greeting");
        }

        public ViewResult RSVPForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RSVPForm(GuestResponse guestresponse)
        {
            if(string.IsNullOrEmpty(guestresponse.LasttName))
            {
                ModelState.AddModelError(string.Empty,"From Me last name can't be Null");
            }
            if (ModelState.IsValid)
            {
                return View("Thanks", guestresponse);
            }
            return View();
            }
	}
}