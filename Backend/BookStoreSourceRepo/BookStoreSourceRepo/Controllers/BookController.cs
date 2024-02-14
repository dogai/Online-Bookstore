using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSourceRepo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        public static List<Book> BookList = new List<Book>();
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
            //BookList.Add(new Book("Körlük", "Sarı Kitap", "Jose Saramago", "image", 39));
            //BookList.Add(new Book("Satranç", "Zeki kitap", "Stefan Zweig", "image", 7));
            //BookList.Add(new Book("1984", "Kırmızı Kitap", "George Orwell", "image", 27));
        }

        [HttpGet("GetAll")]
        public IEnumerable<Book> GetAll()
        {
            return BookList;
        }

        [HttpPost]
        public bool CreateBook([FromBody] Book book)
        {
            BookList.Add(book);
            return true;
        }

    }
}
