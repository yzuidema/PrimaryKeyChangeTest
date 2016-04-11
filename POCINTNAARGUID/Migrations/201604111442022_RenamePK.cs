namespace POCINTNAARGUID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamePK : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Ipsums", "LoremUniqueIdentifier", "dbo.Lorems");
            RenameColumn(table: "dbo.Ipsums", name: "LoremUniqueIdentifier", newName: "LoremId");
            RenameColumn(table: "dbo.Ipsums", name: "UniqueIdentifier", newName: "Id");

            //RenameIndex(table: "dbo.Ipsums", name: "IX_LoremUniqueIdentifier", newName: "IX_LoremId");
            // DropPrimaryKey("dbo.Lorems");
            // AddColumn("dbo.Lorems", "Id", c => c.Guid(nullable: false));
            // AddPrimaryKey("dbo.Lorems", "Id");
            // AddForeignKey("dbo.Ipsums", "LoremId", "dbo.Lorems", "Id", cascadeDelete: true);
            // DropColumn("dbo.Lorems", "UniqueIdentifier");
        }
        
        public override void Down()
        {
            // AddColumn("dbo.Lorems", "UniqueIdentifier", c => c.Guid(nullable: false));
            // DropForeignKey("dbo.Ipsums", "LoremId", "dbo.Lorems");
            //DropPrimaryKey("dbo.Lorems");
            // DropColumn("dbo.Lorems", "Id");
            // AddPrimaryKey("dbo.Lorems", "UniqueIdentifier");
            // RenameIndex(table: "dbo.Ipsums", name: "IX_LoremId", newName: "IX_LoremUniqueIdentifier");
            RenameColumn(table: "dbo.Ipsums", name: "Id", newName: "UniqueIdentifier");
            RenameColumn(table: "dbo.Ipsums", name: "LoremId", newName: "LoremUniqueIdentifier");
           // AddForeignKey("dbo.Ipsums", "LoremUniqueIdentifier", "dbo.Lorems", "UniqueIdentifier", cascadeDelete: true);
        }
    }
}
