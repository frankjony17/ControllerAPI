using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControllerAPI.Controllers
{
    public class ResponseServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
