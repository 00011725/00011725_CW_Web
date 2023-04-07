using DatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseAccess.Repositories
{
    public interface IRentRepository
    {
        // Create New
        /// <param name="rent"></param>
        void CreateNewRent(Rent rent);

        // Retrieve all
        /// <returns></returns>
        IEnumerable<Rent> RetrieveAllRents();

        // Retreive one by ID
        /// <param name="RentID"></param>
        /// <returns></returns>
        Book RetrieveByRentID(int RentID);

        // Delete book by ID
        /// <param name="RentID"></param>
        void DeleteRentByID(int RentID);

        // Update book ID
        /// <param name="rent"></param>
        void UpdateRent(Rent rent);
    }
}
