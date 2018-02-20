namespace bit285_multiple_entities_demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMemberIDinPurchaseModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Purchases", "Member_MemberID", "dbo.Members");
            DropIndex("dbo.Purchases", new[] { "Member_MemberID" });
            RenameColumn(table: "dbo.Purchases", name: "Member_MemberID", newName: "MemberID");
            AlterColumn("dbo.Purchases", "MemberID", c => c.Int(nullable: false));
            CreateIndex("dbo.Purchases", "MemberID");
            AddForeignKey("dbo.Purchases", "MemberID", "dbo.Members", "MemberID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "MemberID", "dbo.Members");
            DropIndex("dbo.Purchases", new[] { "MemberID" });
            AlterColumn("dbo.Purchases", "MemberID", c => c.Int());
            RenameColumn(table: "dbo.Purchases", name: "MemberID", newName: "Member_MemberID");
            CreateIndex("dbo.Purchases", "Member_MemberID");
            AddForeignKey("dbo.Purchases", "Member_MemberID", "dbo.Members", "MemberID");
        }
    }
}
