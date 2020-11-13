using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Create()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Create(User user)
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Create([Bind(Prefix ="address")]address address)
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Create(string[] data)
        //{
        //    return View();
        //}
        [HttpPost]
        public IActionResult Create(List<UserSummery> users)
        {
            return View();
        }
        public IActionResult Createl()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Createl(Product product)
        {
            return View();
        }
    }
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public address address { get; set; }
    }
    public class address
    {
        public string City { get; set; }
        public string street { get; set; }
    }
    public class UserSummery
    {
        public string Name { get; set; }
        public string Password { get; set; }
        [BindNever]
        public int RoleId { get; set; }
    }
    public class Product
    {
        public string Name { get; set; }
        public int amount { get; set; }
        public double Price { get; set; }
        public List<address> addresses { get; set; }
    }
    }
