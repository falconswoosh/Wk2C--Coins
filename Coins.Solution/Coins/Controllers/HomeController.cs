using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Coins.Models;

namespace Coins.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}
