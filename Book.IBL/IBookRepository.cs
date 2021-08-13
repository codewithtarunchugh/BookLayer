using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book.Model;

namespace Book.IBL
{
    public interface IBookRepository
    {
        IEnumerable<BookModel> GetAllBooks();
        int AddBook(BookModel objBookModel);
        BookModel GetBookByBookId(int bookId);
    }
}
