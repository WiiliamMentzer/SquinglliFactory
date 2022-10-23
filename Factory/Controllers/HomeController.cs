using Factory.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;

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
      ViewBag.Machine = _db.Machines.ToList();
      ViewBag.Engineer = _db.Engineers.ToList();
      return View(ViewBag.Machine);
    }
  }
}