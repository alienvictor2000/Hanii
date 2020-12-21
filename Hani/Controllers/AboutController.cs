using System;
using System.Linq;
using Hani.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.Linq.SqlClient;

namespace Hani.Controllers
{

    public class AboutController : Controller
    {
        private DataContext db = new DataContext();

        public IActionResult Index()
        {
            ViewBag.categories = db.Categories.ToList();
            ViewBag.articles = db.Articles.ToList();

            return View();
        }

        public IActionResult SearchArticle(string searchInfo)
        {
            ViewBag.categories = db.Categories.ToList();

            if (searchInfo == null) searchInfo = " ";
            var query = (from a in db.Articles
                             where a.A_content.Contains(searchInfo)
                             select new Article
                             {
                                 a_name = a.A_name,
                                 a_content = a.A_content,
                                 a_avatar = a.A_avatar
                             });
            

            ViewBag.articles = query.ToList();

            return View();
        }
    }
}
