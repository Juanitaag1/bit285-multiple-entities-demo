namespace bit285_multiple_entities_demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedDbSetAuthors : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            AddColumn("dbo.Books", "Author_AuthorID", c => c.Int());
            CreateIndex("dbo.Books", "Author_AuthorID");
            AddForeignKey("dbo.Books", "Author_AuthorID", "dbo.Authors", "AuthorID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Author_AuthorID", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Author_AuthorID" });
            DropColumn("dbo.Books", "Author_AuthorID");
            DropTable("dbo.Authors");
        }
    }
}
