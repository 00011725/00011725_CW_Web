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
    public class RentsController : Controller
    {
        private readonly IRentRepository __rentRepository;

        public RentsController(IRentRepository rentRepository)
        {
            __rentRepository = rentRepository;
        }

        [HttpGet]

        // GET: Books
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(__rentRepository.RetrieveAllRents());
        }
        [HttpPost]
        [HttpGet("{id}", Name = "RetrieveByRentID")]
        public IActionResult RetrieveByRentID(int RentID)
        {
            return new OkObjectResult(__rentRepository.RetrieveByRentID(RentID));
        }



        // GET: Books/Create
        [HttpPost]
        public IActionResult CreateNewRent(Rent rent)
        {
            using (var scope = new TransactionScope())
            {
                __rentRepository.CreateNewRent(rent);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { ID = rent.Id }, rent);
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBookForRent(int RentID, [Bind("Id,BookName,RentState,OrderDate")] Rent rent)
        {
            if (rent != null)
            {
                using (var scope = new TransactionScope())
                {
                    __rentRepository.UpdateRent(rent);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }

        // GET: Books/Delete/5


        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int RentID)
        {

            __rentRepository.DeleteRentByID(RentID);
            return new OkResult();
        }
    }
}
