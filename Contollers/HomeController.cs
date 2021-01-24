using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AcoApp.webui.Models;
using AcoApp.webui.ViewModels;

namespace AcoApp.webui.Contollers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product {Name="Iphone 12",Price=20000,Description="iyi telefon",IsApproved=false},
                new Product {Name="Iphone 11",Price=15000,Description="çok iyi telefon",IsApproved=true},
                new Product {Name="Iphone xs",Price=9000,Description="çok iyi telefon",IsApproved=true},
                new Product {Name="Iphone x",Price=7000,Description="çok iyi telefon"},
            };


            var productViewModel = new ProductViewModel()
            {
                Products = products
            };

            return View(productViewModel);
        }

        // localhost:5000/home/about
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View("Contact");
        }
    }
}
