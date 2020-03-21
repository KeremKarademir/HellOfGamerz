using HellOfGamerz.Models;
using HellOfGamerz.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

namespace HellOfGamerz.Controllers
{
    public class AuthorController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult LogIn(){
            return View("Login");
        }

        [HttpPost]
        public ActionResult LogIn(Author author) {
            var model = db.Authors.ToList().SingleOrDefault(a => a.Name == author.Name || a.LastName == author.LastName);
            if (model != null) 
            {
                ArticleAuthorViewModel viewmodel = new ArticleAuthorViewModel
                {
                    Author = model
                };
                Session["id"] = model.Id;
                Session["authorname"] = model.Name;
                return View("LoginSuccess", viewmodel);
            }
            
            return View("Login");
        }

        // GET: Author
        public ActionResult Index()
        {
            return View();
        }

        // GET: Author/Details/5
        public ActionResult Details()
        {
            try
            {
                var authorId = (int) Session["id"];

                var model = db.Authors.Include(a => a.Articles).ToList().SingleOrDefault(c => c.Id == authorId);

                return View("Details",model);
            }
            catch 
            {
                return Content("Please Log In To See Any Details");
            }
            
        }

        // GET: Author/Create
        public ActionResult SignUp()
        {
            return View("SignUp");
        }

        // POST: Author/Create
        [HttpPost]
        public ActionResult SignUp(Author author)
        {
            var authorInDb = db.Authors
                               .Where(a => a.Name == author.Name || a.LastName == author.LastName)
                               .ToList()
                               .Count;

            try
            {
                if (authorInDb == 0)
                {
                    // TODO: Add insert logic here
                    db.Authors.Add(author);
                    db.SaveChanges();

                    var model = new ArticleAuthorViewModel
                    {
                        Author = author
                    };
                    return View("LoginSuccess", model);
                }

                return View("SignUp");
            }
            catch
            {
                return View("SignUp");
            }
        }

        // GET: Author/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Author/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Author/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Author/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
