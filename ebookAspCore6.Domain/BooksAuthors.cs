using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebookAspCore6.Domain
{
    public class BooksAuthors
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book book { get; set; }

        public int AuthorID { get; set; }
        public Author author { get; set; }
    }
}
