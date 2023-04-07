using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseAccess.Models
{
    public class Rent
    {
        public int Id { get; set; }
        [Required]
        public string BookName { get; set; }


        [Required]
        public bool RentState { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }

    }
}
