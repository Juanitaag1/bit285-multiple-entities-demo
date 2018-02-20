using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndyBooks.Models
{
    public class Author
    {
        public int AuthorID { get; set; }

        // TODO: Create at least three  appropriate properties
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string authorName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        // TODO: Add Property to represent the entity relationship: "An Author can write many Books"
        public virtual ICollection<Book> bookset { get; set; }
    }
}