using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp2.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            CourseApp2.Models.Request model = new Request();

            model.Name = "Tayfun Karaveli";
            model.Email = "tayfunkaraveli@hotmail.com";
            model.Phone = "0123456789";
            model.Message = "Kursa katılmak istiyorum.";

            return View(model);
        }
    }
}