using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hani.Models;

namespace Hani.Controllers
{
    public class HomeController : Controller
    {
        private DataContext db = new DataContext();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var query2 = (from c in db.Categories
                          orderby c.Id
                          select c.C_name
                          ).ToList();

            var query3 = (from c in db.Categories
                          orderby c.Id
                          select c.Id
                          ).ToList();

            int countCate = query2.Count();
            List<List<ProductJoinCate>> myList = new List<List<ProductJoinCate>>();

            for (int i=0; i < countCate; i++)
            {
                var query = (from c in db.Categories
                             join p in db.Products on c.Id equals p.Pro_category_id
                             where c.Id == query3[i]
                             select new ProductJoinCate
                             {
                                 Id = c.Id,
                                 PRODUCT_NAME = p.Pro_name,
                                 CATE_NAME = c.C_name,
                                 PRODUCT_PRICE = p.Pro_price
                             });
               myList.Add(query.ToList());
            }
            ViewBag.productJoinCate = myList;
            ViewBag.countCate = countCate;
            ViewBag.Cate = query2;

            return View();
        }

        public IActionResult SearchProduct(string searchInfo)
        {
            ViewBag.Cate = db.Categories.ToList();

            if (searchInfo == null) searchInfo = " ";
            var query = (from p in db.Products
                         where p.Pro_name.Contains(searchInfo)
                         select new Product
                         {
                             Pro_avatar = p.Pro_avatar,
                             Pro_name = p.Pro_name,
                             Pro_price = p.Pro_price,
                         });

            ViewBag.Products = query.ToList();

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
    }
}
