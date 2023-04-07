using DatabaseAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using DatabaseAccess.DAL;
using System.Linq;

namespace DatabaseAccess.Repositories
{
    public class RentRepository : IRentRepository
    {
        private readonly BookDbContext __dbContext;

        public RentRepository(BookDbContext dbContext)
        {
            __dbContext = dbContext;
        }
        public void Save()
        {
            __dbContext.SaveChanges();
        }

        public void CreateNewRent(Rent rent)
        {
            __dbContext.Add(rent);
            Save();
        }

        public void DeleteRentByID(int RentID)
        {
            var foundBookForRent = __dbContext.Rents.Find(RentID);
            __dbContext.Rents.Remove(foundBookForRent);
            Save();
        }

        public IEnumerable<Rent> RetrieveAllRents()
        {
            return __dbContext.Rents.ToList();
        }

        public Book RetrieveByRentID(int RentID)
        {
            return __dbContext.Books.Find(RentID);
        }

        public void UpdateRent(Rent rent)
        {
            __dbContext.Entry(rent).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }
    }
}
