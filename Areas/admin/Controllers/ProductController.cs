using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HocThemNetCoreB2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace HocThemNetCoreB2.Areas.admin.Controllers
{
    public class ProductController : Controller
    {
        [Area("admin")]
        public IActionResult Index()
        {
            //var lstdata = new List<Student>();
            //using (var dbcontext = new SchoolContext())
            //{
            //    lstdata = dbcontext.Students.ToList();

            //}
            //return View(lstdata);
            var lstdata = new List<Product>();
            using (var dbcontext = new SchoolContext())
            {
                //lstdata = dbcontext.Products.ToList();
                lstdata = dbcontext.Products.Where(x => x.IsDelete != true).ToList();

            }
            return View(lstdata);
        }

        [Area("admin")]
        public IActionResult Create()
        {
            var datamodel = new ProductModel();
            return View(datamodel);
        }
        [Area("admin")]
        [HttpPost]
        public IActionResult Create(Product model)
        {
            try {
                if (ModelState.IsValid)
                    {
                        using (var dbcontext = new SchoolContext())
                        {
                            dbcontext.Products.Add(model);
                            dbcontext.SaveChanges();
                        }
                        return RedirectToAction("Index");
                    }
                } catch( Exception ex)
                {
                TempData["StatusMessage"] = ex.Message;
                }
            return View(model);
        }
        [Area("admin")]
        public IActionResult Edit()
        {
            return View();
        }
    }
}
