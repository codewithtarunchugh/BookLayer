using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Model
{
    public class BookModel
    {
        public int BookId { get; set; }

        public string BookName { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int PublishYear { get; set; }

        public decimal BasePrice { get; set; }
    }
}
