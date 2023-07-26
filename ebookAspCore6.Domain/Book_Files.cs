using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebookAspCore6.Domain
{
    public class Book_Files
    {
        public int Id { get; set; }
        public string blobUrl { get; set; }
        public string? FileName { get; set; }


        public Book? book { get; set; }


    }
}
