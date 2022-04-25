using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Book
{
    public class BookEditDTO
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public int Page { get; set; }
        public decimal Price { get; set; }
    }
}
