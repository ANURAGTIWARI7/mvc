using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nimap.Models;
using System.Data.Entity;


namespace Nimap.Controllers
{
    public class DataAccessHomeController : Controller
    {
        // GET: DataAccessHome
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult Update()
        {
            Database1Entities entities = new Database1Entities();
            List<product> ListCategory = entities.products.ToList();

            entities.Dispose();
            return View(ListCategory);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Add(product product)
        {
            Database1Entities entities = new Database1Entities();
            entities.products.Add(product);

            entities.SaveChanges();
            entities.Dispose();
            return Redirect("Update");
        }
        public ActionResult Edit(int Id)
        {
            Database1Entities entities = new Database1Entities();
            product p = entities.products.Where(i => i.ProductId == Id).FirstOrDefault();

            entities.Dispose();

            return View(p);
        }
        public ActionResult Save(product s)
        {
            Database1Entities entities = new Database1Entities();
            product p = entities.products.Where(i => i.ProductId == s.ProductId).FirstOrDefault();

           
            p.ProductName = s.ProductName;
            p.CategoryId = s.CategoryId;
            p.CategoryName = s.CategoryName;

            entities.SaveChanges();
            entities.Dispose();

            return Redirect("Update");
        }

        public ActionResult Details(int Id)
        {

            Database1Entities entities = new Database1Entities();
            product p = entities.products.Where(i => i.ProductId == Id).FirstOrDefault();

            entities.Dispose();

            return View(p);
        }
        public ActionResult Delete(int Id)
        {

            Database1Entities entities = new Database1Entities();
            product p = entities.products.Where(i => i.ProductId == Id).FirstOrDefault();

            entities.Dispose();

            return View(p);
        }
        public ActionResult Remove(product s)
        {

            Database1Entities entities = new Database1Entities();
            product p = entities.products.Where(i => i.ProductId == s.ProductId).FirstOrDefault();


            entities.products.Remove(p);
            entities.SaveChanges();
            entities.Dispose();

            return Redirect("Update");
        }
    }
}