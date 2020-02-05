namespace Home.Controllers
{
  using System;
  using System.Linq;
  using System.Collections.Generic;
  using Microsoft.AspNetCore.Mvc;

  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}