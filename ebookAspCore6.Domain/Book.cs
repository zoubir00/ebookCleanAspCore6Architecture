using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ebookAspCore6.Domain
{
    public class Book
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genre { get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }
        public double Price { get; set; }


        // navigation
        public int PublisherId { get; set; }
        public Publisher publisher { get; set; }

        public Book_Files? file { get; set; }

        public List<BooksAuthors> booksAuthors { get; set; }


    }
}
