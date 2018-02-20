using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndyBooks.Models
{
    public class Member
    {
        public int MemberID { get; set; }

        // TODO: Create at least three  appropriate properties
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string memberName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }

        // TODO: Add Property to represent the entity relationship: "A Member can have many Purchases"
        public virtual ICollection<Purchase> memberPurchase { get; set; }
    }
}