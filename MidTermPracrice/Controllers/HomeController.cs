using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MidTermPracrice.Data;
using MidTermPracrice.Models;

namespace MidTermPracrice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.Interpolates.ToList();
            return View("Index", model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]
        public IActionResult Create(Models.Interpolate num)
        {
            num.ResultOfInterpolation = num.NumberOne * num.NumberTwo;
            num.DateTime = DateTime.Now;
            _context.Interpolates.Add(num);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
