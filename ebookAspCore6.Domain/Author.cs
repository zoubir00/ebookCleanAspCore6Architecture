using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebookAspCore6.Domain
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ImageURL { get; set; }

        // Navigation
        public List<BooksAuthors> booksAuthors { get; set; }
    }
}
