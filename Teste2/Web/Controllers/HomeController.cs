using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Domain.Entities;
using Web.Models;
using Web.Helpers;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly InTaskHelper _inTaskHelper = new InTaskHelper();
        public ActionResult Index()
        {            
            return View(Mapper.Map<IEnumerable<InTask>, IEnumerable<InTaskViewModel>>(_inTaskHelper.GetTasks()));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}