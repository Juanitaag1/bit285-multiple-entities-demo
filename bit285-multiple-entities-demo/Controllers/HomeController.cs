using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IndyBooks.Models;

namespace IndyBooks.Controllers
{
    public class HomeController : Controller
    {
        BookstoreDbContext db = new BookstoreDbContext();

        /*
         * Purchase Creation and List
         */
        public ActionResult Purchase()
        {
             return View();
        }
        [HttpPost]
        public ActionResult Purchase(Purchase purchase)
        {
            if(ModelState.IsValid)
            {
                db.Purchases.Add(purchase);
                db.SaveChanges();
                return View("Purchases", db.Purchases);
            }
            return View();
        }
        /*
         * Book Creation and List
         * TODO: Update methods and Views to Book create and list Books 
         */
        public ActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            
            db.Books.Add(book);
            db.SaveChanges();
            return View(db.Books.ToList());
        }
        /*
          * Author Creation and List
          * TODO: Develop methods and Views to create and list Authors 
          */
          public ActionResult addAuthor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addAuthor(Author author)
        {
            db.Authors.Add(author);
            db.SaveChanges();
            return View(db.Authors.ToList());
        }
        /*
          * Member Creation and List
          * TODO: Develop methods and Views to create and list Members 
          */
          public ActionResult Members()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Members(Member m)
        {
            db.Members.Add(m);
            db.SaveChanges();
            return View(db.Members.ToList());
        }
        //Get viewmodel
        public ActionResult Booklist()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Booklist(bit285_multiple_entities_demo.ViewModels.BookListViewmodel booklistVM)
        {

            return View(booklistVM);
        }
    }
}