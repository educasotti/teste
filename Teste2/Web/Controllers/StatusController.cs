using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Helpers;
using Web.Models;

namespace Web.Controllers
{
    public class StatusController : Controller
    {
        private readonly StatusHelper _statusHelper = new StatusHelper();
        // GET: Status
        public ActionResult Index()
        {
            return View(Mapper.Map<IEnumerable<Status>,IEnumerable<StatusViewModel>>(_statusHelper.GetStatus()));
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(StatusViewModel model)
        {
            _statusHelper.AddStatus(Mapper.Map<StatusViewModel, Status>(model));
            return View()
        }
    }
}