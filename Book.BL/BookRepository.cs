using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book.Data;
using Book.IBL;
using Book.Model;

namespace Book.BL
{
    public class BookRepository : IBookRepository
    {
        private BookDBEntities objBookDBEntities;

        public BookRepository()
        {
            objBookDBEntities = new BookDBEntities();
        }
        public int AddBook(BookModel objBookModel)
        {
            Data.Book objBook = new Data.Book()
            {
                Author = objBookModel.Author,
                BasePrice = (decimal)objBookModel.BasePrice,
                BookId = objBookModel.BookId,
                BookName = objBookModel.BookName,
                PublishYear = (int)objBookModel.PublishYear,
                Title = objBookModel.Title
            };
            objBookDBEntities.Books.Add(objBook);
            return objBookDBEntities.SaveChanges();
        }

        public IEnumerable<BookModel> GetAllBooks()
        {
            IEnumerable<BookModel> listOfBooks = (from objBook in objBookDBEntities.Books
                                                  select new BookModel()
                                                  {
                                                      Author = objBook.Author,
                                                      BasePrice = (decimal)objBook.BasePrice,
                                                      BookId = objBook.BookId,
                                                      BookName = objBook.BookName,
                                                      PublishYear = (int)objBook.PublishYear,
                                                      Title = objBook.Title
                                                  }).ToList();
            return listOfBooks;
        }

        public BookModel GetBookByBookId(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
