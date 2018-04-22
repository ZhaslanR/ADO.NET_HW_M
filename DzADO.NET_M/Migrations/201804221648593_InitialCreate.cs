namespace DzADO.NET_M.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LibaryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Libaries", t => t.LibaryId, cascadeDelete: true)
                .Index(t => t.LibaryId);
            
            CreateTable(
                "dbo.Libaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.Int(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "LibaryId", "dbo.Libaries");
            DropIndex("dbo.Books", new[] { "LibaryId" });
            DropTable("dbo.Libaries");
            DropTable("dbo.Books");
        }
    }
}
