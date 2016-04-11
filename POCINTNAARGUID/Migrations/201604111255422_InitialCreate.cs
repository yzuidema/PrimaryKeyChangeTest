namespace POCINTNAARGUID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ipsums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LoremId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Lorems", t => t.LoremId, cascadeDelete: true)
                .Index(t => t.LoremId);
            
            CreateTable(
                "dbo.Lorems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ipsums", "LoremId", "dbo.Lorems");
            DropIndex("dbo.Ipsums", new[] { "LoremId" });
            DropTable("dbo.Lorems");
            DropTable("dbo.Ipsums");
        }
    }
}
