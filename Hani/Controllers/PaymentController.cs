using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hani.Models;

namespace Hani.Controllers
{
    public class PaymentController : Controller
    {
        private DataContext db = new DataContext();

        public IActionResult Index()
        {   
            return View();
        }

        public IActionResult Success()
        {
            return View();
        }
        [HttpGet]
        public IActionResult InsertTransaction()
        {
            return View("InsertTransaction");
        }
        [HttpPost]
        public IActionResult InsertTransaction(Transaction tr)
        {
            db.Transactions.Add(tr);
            db.SaveChanges();
            return RedirectToAction("Success");
        }
    }
}
