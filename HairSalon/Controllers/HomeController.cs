using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.solution.Controllers;

public class HomeController : Controller
{
   


    public IActionResult Index()
    {
        return View();
    
    }
}
