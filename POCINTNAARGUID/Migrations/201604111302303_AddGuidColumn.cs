namespace POCINTNAARGUID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGuidColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ipsums", "UniqueIdentifier", c => c.Guid(nullable: false));
            AddColumn("dbo.Ipsums", "LoremUniqueIdentifier", c => c.Guid(nullable: false));
            AddColumn("dbo.Lorems", "UniqueIdentifier", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lorems", "UniqueIdentifier");
            DropColumn("dbo.Ipsums", "LoremUniqueIdentifier");
            DropColumn("dbo.Ipsums", "UniqueIdentifier");
        }
    }
}
