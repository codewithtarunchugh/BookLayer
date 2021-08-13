using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Book.BL;
using Book.IBL;
using Book.Model;

namespace WebAppMVCBook.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository iBookRepository;
        public HomeController(IBookRepository _iBookRepository)
        {
            iBookRepository = _iBookRepository;
        }
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<BookModel> listOfBookModels = iBookRepository.GetAllBooks();
            return View(listOfBookModels);
        }
        public ActionResult AddBook()
        {
            BookModel objBookModel = new BookModel()
            {
                Author = "Tarun Chugh",
                BasePrice = 5400,
                BookName = "VB.Net",
                PublishYear = 2121,
                Title = "VB by Tarun chugh"
            };
            int result = iBookRepository.AddBook(objBookModel);
            return RedirectToAction("Index");
        }
    }
}