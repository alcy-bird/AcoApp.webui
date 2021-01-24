
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AcoApp.webui.Models;
using AcoApp.webui.ViewModels;

namespace AcoApp.webui.Contollers
{
    public class ProductController:Controller
    {
        public IActionResult Index()
        {
         var product = new Product{Name="Iphone 12",Price=20000,Description="nice pone"};
          // ViewData["Category"] = "Telefonlar";
            // ViewData["Product"] = product;

            ViewBag.Category = "Telefonlar";
            // ViewBag.Product = product;

            // ViewBag.Product
            return View(product);
        }
        public IActionResult list()
        {
            var products = new List<Product>()
            {
                new Product {Name="Iphone 12",Price=20000,Description="iyi telefon",IsApproved=false},
                new Product {Name="Iphone 11",Price=15000,Description="çok iyi telefon",IsApproved=true},
                new Product {Name="Iphone xs",Price=9000,Description="çok iyi telefon",IsApproved=true},
                new Product {Name="Iphone x",Price=7000,Description="çok iyi telefon"},
            };

            var categories = new List<Category>()
            {
                new Category { Name = "Telefon", Description = "telefonlar" },
                new Category { Name = "Bilgisayar", Description = "Bilgisayarlar" },
                new Category { Name = "Tablet", Description = "Tabletler" }
            };
           

            var productViewModel = new ProductViewModel()
            {
                Categories = categories,
                Products = products
            };

            return View(productViewModel);
        }

       

        public IActionResult Detail()
        {
            return View("Details");
        }
    }
}
