namespace SchoolAppEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sid : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.students", new[] { "crs_cId" });
            RenameColumn(table: "dbo.courses", name: "crs_cId", newName: "std_sID");
            CreateIndex("dbo.courses", "std_sID");
            DropColumn("dbo.courses", "sID");
            DropColumn("dbo.students", "crs_cId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.students", "crs_cId", c => c.Int());
            AddColumn("dbo.courses", "sID", c => c.Int(nullable: false));
            DropIndex("dbo.courses", new[] { "std_sID" });
            RenameColumn(table: "dbo.courses", name: "std_sID", newName: "crs_cId");
            CreateIndex("dbo.students", "crs_cId");
        }
    }
}
