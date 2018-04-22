namespace DzADO.NET_M.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Book",
                b => new
                {
                    Id = b.Int(nullable: false, identity: true),
                    Name = b.String(),
                })
                .PrimaryKey(b => b.Id);
            CreateTable(
                "dbo.Libary",
                l => new
                {
                    Id = l.Int(nullable: false, identity: true),
                    Name = l.String(),
                    Address = l.String()
                })
                .PrimaryKey(b => b.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Book");
            DropTable("dbo.Libary");
        }
    }
}
