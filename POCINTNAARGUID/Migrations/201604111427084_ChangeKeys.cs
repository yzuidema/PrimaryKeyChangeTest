namespace POCINTNAARGUID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeKeys : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ipsums", "LoremId", "dbo.Lorems");
            DropIndex("dbo.Ipsums", new[] { "LoremId" });
          //  DropColumn("dbo.Ipsums", "LoremUniqueIdentifier");
           // RenameColumn(table: "dbo.Ipsums", name: "LoremId", newName: "LoremUniqueIdentifier");
            DropPrimaryKey("dbo.Ipsums");
            DropPrimaryKey("dbo.Lorems");
           // AlterColumn("dbo.Ipsums", "Id", c => c.Int(nullable: false));
           // AlterColumn("dbo.Ipsums", "LoremUniqueIdentifier", c => c.Guid(nullable: false));
           // AlterColumn("dbo.Lorems", "Id", c => c.Int(nullable: false  ));
            AddPrimaryKey("dbo.Ipsums", "UniqueIdentifier");
            AddPrimaryKey("dbo.Lorems", "UniqueIdentifier");
            CreateIndex("dbo.Ipsums", "LoremUniqueIdentifier");
            AddForeignKey("dbo.Ipsums", "LoremUniqueIdentifier", "dbo.Lorems", "UniqueIdentifier", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ipsums", "LoremUniqueIdentifier", "dbo.Lorems");
            DropIndex("dbo.Ipsums", new[] { "LoremUniqueIdentifier" });
            DropPrimaryKey("dbo.Lorems");
            DropPrimaryKey("dbo.Ipsums");
            //AlterColumn("dbo.Lorems", "Id", c => c.Int(nullable: false, identity: true));
           // AlterColumn("dbo.Ipsums", "LoremUniqueIdentifier", c => c.Int(nullable: false));
           // AlterColumn("dbo.Ipsums", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Lorems", "Id");
            AddPrimaryKey("dbo.Ipsums", "Id");
           // RenameColumn(table: "dbo.Ipsums", name: "LoremUniqueIdentifier", newName: "LoremId");
           // AddColumn("dbo.Ipsums", "LoremUniqueIdentifier", c => c.Guid(nullable: false));
            CreateIndex("dbo.Ipsums", "LoremId");
            AddForeignKey("dbo.Ipsums", "LoremId", "dbo.Lorems", "Id", cascadeDelete: true);
        }
    }
}
