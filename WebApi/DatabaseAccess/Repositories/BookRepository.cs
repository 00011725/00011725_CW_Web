using DatabaseAccess.DAL;
using DatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatabaseAccess.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext __dbContext;

        public BookRepository(BookDbContext dbContext)
        {
            __dbContext = dbContext;
        }
        public void Save()
        {
            __dbContext.SaveChanges();
        }


        public void CreateNewBook(Book book)
        {
            __dbContext.Add(book);
            Save();
        }

        public void DeleteBookByID(int BookID)
        {
            var foundBook = __dbContext.Books.Find(BookID);
            __dbContext.Books.Remove(foundBook);
            Save();
        }

        public IEnumerable<Book> RetrieveAllBooks()
        {
            return __dbContext.Books.ToList();
        }

        public Book RetrieveByID(int BookID)
        {
            return __dbContext.Books.Find(BookID);
        }

        public void UpdateBook(Book book)
        {
            __dbContext.Entry(book).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
    }
}
