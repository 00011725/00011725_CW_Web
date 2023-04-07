using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DatabaseAccess.DAL;
using DatabaseAccess.Models;
using DatabaseAccess.Repositories;
using System.Transactions;

namespace API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly IBookRepository __booksRepository;

        public BooksController(IBookRepository booksRepository)
        {
            __booksRepository = booksRepository;
        }

        // GET: Books
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(__booksRepository.RetrieveAllBooks());
        }
        [HttpGet("{id}", Name = "RetrieveByID")]
        public IActionResult RetrieveByID(int BookID)
        {
            return new OkObjectResult(__booksRepository.RetrieveByID(BookID));
        }



        // GET: Books/Create
        [HttpPost]
        public IActionResult CreateNewBook(Book book)
        {
            using (var scope = new TransactionScope())
            {
                __booksRepository.CreateNewBook(book);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { ID = book.Id }, book);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int BookID, [Bind("Id,BookName,Author,Replacement,ForRent,PublitionYear")] Book book)
        {
            if (book != null)
            {
                using (var scope = new TransactionScope())
                {
                    __booksRepository.UpdateBook(book);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        // GET: Books/Delete/5


        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int BookID)
        {

            __booksRepository.DeleteBookByID(BookID);
            return new OkResult();
        }

    }
}
