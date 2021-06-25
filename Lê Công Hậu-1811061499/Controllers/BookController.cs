using _1811061499.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1811061499.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var BookList = new List<Book>
            {
                new Book(){BookID = 1, BookName = "A", Page = 10},
                new Book(){BookID = 1, BookName = "A", Page = 10},
                new Book(){BookID = 1, BookName = "A", Page = 10},
                new Book(){BookID = 1, BookName = "A", Page = 10},
                new Book(){BookID = 1, BookName = "A", Page = 10},
                new Book(){BookID = 1, BookName = "A", Page = 10},
            };
            return View(BookList);
        }
    }
}
