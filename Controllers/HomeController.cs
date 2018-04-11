using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpPost]
        [Route("process")]
        public IActionResult Process(User NewUser){
            if(ModelState.IsValid){
                // in cshtml use != null to check if TempData has value.
                TempData["success"] = "Successfully Registered";
                return RedirectToAction("Index");
            }
            return View("Index");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
