using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        //Создаём контекст данных
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            //Получаем из бд все объекты Books
            IEnumerable<Book> books = db.Books;

            //Передаём все объекты в динамическое свойство  Books в ViewBag
            ViewBag.Books = books;

            // Возвращаем представление
            return View();
        }
    }
}