using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IndyBooks.Models
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }  //Database requires a Primary Key field
        [Required]
        public string Title { get; set; }
        [Required]

        public int AuthorID { get; set; }
        public string Edition { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Display(Name = "Publication Year")]
        public string Publication { get; set; }

        // Property to represent the entity relationship: "A Book can have many Purchases"
        public virtual ICollection<Purchase> SalesHistory { get; set; }

        public virtual Book b { get; set; }
    }
}