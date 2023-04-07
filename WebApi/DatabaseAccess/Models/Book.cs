using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DatabaseAccess.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string BookName { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Replacement { get; set; }

        [Required]
        public bool ForRent { get; set; }

        [Required]
        public DateTime PublitionYear { get; set; }

    }
}
