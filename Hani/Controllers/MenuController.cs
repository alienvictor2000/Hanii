using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hani.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hani.Controllers
{
    public class MenuController : Controller
    {
        private DataContext db = new DataContext();

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

            for (int i = 0; i < countCate; i++)
            {
                var query = (from c in db.Categories
                             join p in db.Products on c.Id equals p.Pro_category_id
                             where c.Id == query3[i]
                             select new ProductJoinCate
                             {
                                 Id = c.Id,
                                 PRODUCT_NAME = p.Pro_name,
                                 CATE_NAME = c.C_name,
                                 PRODUCT_PRICE = p.Pro_price,
                                 PRODUCT_AVATAR = p.Pro_avatar
                             });
                myList.Add(query.ToList());
            }
            ViewBag.productJoinCate = myList;
            ViewBag.countCate = countCate;
            ViewBag.Cate = query2;

            return View();
        }

        public IActionResult Order1()
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

            for (int i = 0; i < countCate; i++)
            {
                var query = (from c in db.Categories
                             join p in db.Products on c.Id equals p.Pro_category_id
                             where c.Id == query3[i]
                             select new ProductJoinCate
                             {
                                 Id = c.Id,
                                 PRODUCT_ID = p.Id,
                                 PRODUCT_NAME = p.Pro_name,
                                 CATE_NAME = c.C_name,
                                 PRODUCT_PRICE = p.Pro_price,
                                 PRODUCT_AVATAR = p.Pro_avatar,
                                 PRODUCT_SLUG = p.Pro_slug,
                                 PRODUCT_DES = p.Pro_description
                             });
                myList.Add(query.ToList());
            }
            ViewBag.productJoinCate = myList;
            ViewBag.countCate = countCate;
            ViewBag.Cate = query2;

            return View();
        }

        public IActionResult Payment()
        {
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
                             Pro_slug = p.Pro_slug
                         });

            ViewBag.Products = query.ToList();

            return View();
        }
    }
}
