using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesApp.Panel.Web.Controllers
{
    public class RecordsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

    }
}
