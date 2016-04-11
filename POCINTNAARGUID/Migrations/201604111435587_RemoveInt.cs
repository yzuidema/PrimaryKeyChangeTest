namespace POCINTNAARGUID.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveInt : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Ipsums", "Id");
            DropColumn("dbo.Lorems", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lorems", "Id", c => c.Int(nullable: false));
            AddColumn("dbo.Ipsums", "Id", c => c.Int(nullable: false));
        }
    }
}
