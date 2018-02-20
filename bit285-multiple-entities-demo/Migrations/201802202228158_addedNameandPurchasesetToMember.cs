namespace bit285_multiple_entities_demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedNameandPurchasesetToMember : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Purchases", "Member_MemberID", c => c.Int());
            AddColumn("dbo.Members", "firstName", c => c.String());
            AddColumn("dbo.Members", "lastName", c => c.String());
            CreateIndex("dbo.Purchases", "Member_MemberID");
            AddForeignKey("dbo.Purchases", "Member_MemberID", "dbo.Members", "MemberID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "Member_MemberID", "dbo.Members");
            DropIndex("dbo.Purchases", new[] { "Member_MemberID" });
            DropColumn("dbo.Members", "lastName");
            DropColumn("dbo.Members", "firstName");
            DropColumn("dbo.Purchases", "Member_MemberID");
        }
    }
}
