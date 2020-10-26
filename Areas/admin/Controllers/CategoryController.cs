using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HocThemNetCoreB2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HocThemNetCoreB2.Areas.admin.Controllers
{
    [Area("admin")]
    public class CategoryController : Controller
    {
        // GET: CategoryController
        public ActionResult Index()
        {
            var lstdata = new List<Category>();
            using (var dbcontext = new SchoolContext())
            {
                //lstdata = dbcontext.Products.ToList();
                lstdata = dbcontext.Categories.Where(x => x.IsDeleted != true).ToList();

            }
            return View(lstdata);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            var datamodel = new Category();
            return View(datamodel);
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var dbcontext = new SchoolContext())
                    {
                        dbcontext.Categories.Add(model);
                        dbcontext.SaveChanges();
                    }
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                TempData["StatusMessage"] = ex.Message;
            }
            return View(model);
        }
        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category model)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category model)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
