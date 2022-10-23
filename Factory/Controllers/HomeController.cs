using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {

    private readonly FactoryContext _db;

    public HomeController(FactoryContext db) 
    {
      _db = db; 
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.Engineer = new List<Engineer>(_db.Engineers);
      ViewBag.Machine = new List<Machine>(_db.Machines);
      return View(ViewBag.Machine);
    }
  }
}