using DatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseAccess.Repositories
{
    public interface IBookRepository
    {
        // Create New
        /// <param name="book"></param>
        void CreateNewBook(Book book);

        // Retrieve all
        /// <returns></returns>
        IEnumerable<Book> RetrieveAllBooks();

        // Retreive one by ID
        /// <param name="BookID"></param>
        /// <returns></returns>
        Book RetrieveByID(int BookID);

        // Delete Book by ID
        /// <param name="BookID"></param>
        void DeleteBookByID(int BookID);

        // Update by ID
        /// <param name="book"></param>
        void UpdateBook(Book book);
    }
}
