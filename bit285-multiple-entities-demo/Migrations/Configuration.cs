namespace bit285_multiple_entities_demo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using IndyBooks.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<IndyBooks.Models.BookstoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "IndyBooks.Models.BookstoreDbContext";
        }

        protected override void Seed(IndyBooks.Models.BookstoreDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Books.AddOrUpdate(b => b.BookID,
                new Book()
                {
                    BookID = 1,
                    Title = "Pride and Prejudice",
                    AuthorID = 1,
                    Price = 9.99M
                },
                new Book()
                {
                    BookID = 2,
                    Title = "Northanger Abbey",
                    AuthorID = 1,
                    Price = 12.95M
                },
                new Book()
                {
                    BookID = 3,
                    Title = "David Copperfield",
                    AuthorID = 2,
                    Price = 15.00M
                },
                new Book()
                {
                    BookID = 4,
                    Title = "The Wizard of EarthSea",
                    AuthorID= 4,
                    Price = 8.95M
                },
                new Book()
                {
                    BookID = 5,
                    Title = "The Tombs of Atuan",
                    AuthorID = 4,
                    Price = 7.95M
                },
                new Book()
                {
                    BookID = 6,
                    Title = "The Farthest Shore",
                    AuthorID = 4,
                    Price = 9.95M

                });
            //TODO: Add several Author records
            context.Authors.AddOrUpdate(a => a.AuthorID,
               new Author() { AuthorID = 1, firstName = "Jane", lastName = "Austin" },
               new Author() { AuthorID = 2, firstName = "Charles", lastName = "Dickens" },
               new Author() { AuthorID = 3, firstName = "J.k.", lastName = "R" },
               new Author() { AuthorID = 4, firstName = "Ursula", lastName = "Le Guin"
               });
            //TODO: Add several Member records
            context.Members.AddOrUpdate(m => m.MemberID,
                new Member()
                { MemberID = 1, firstName = "Juanita", lastName = "A", 

    });
//TODO: Add additional Purchase records
context.Purchases.AddOrUpdate(p => p.PurchaseID,
                new Purchase()
                {
                    PurchaseID = 1,
                    Amount = 10.00M,
                    BookID = 6,
                    //TODO: Add the MemberID value
                    MemberID = 1
                });


        }
    }
}
